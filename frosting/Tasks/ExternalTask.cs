using Path = System.IO.Path;

[TaskName("external")]
[IsDependentOn(typeof(BinderateTask))]
public sealed class ExternalTask : FrostingTask<BuildContext>
{
	// Podfile basic structure
	static readonly string[] PODFILE_BEGIN = new[] {
		"platform :ios, '{0}'",
		"install! 'cocoapods', :integrate_targets => false",
		"use_frameworks!",
	};
	static readonly string[] PODFILE_TARGET = new[] {
		"target 'DotnetBraintree' do",
	};
	static readonly string[] PODFILE_END = new[] {
		"end",
	};
	static readonly string[] dynamicFrameworkLines = new[] {
		"=begin",
		"This override the static_framework flag to false,",
		"in order to be able to build dynamic frameworks.",
		"=end",
		"pre_install do |installer|",
		"\tinstaller.pod_targets.each do |pod|",
		"\tputs \"Forcing a static_framework to false for #{pod.name}\"",
		"\t\tif Pod::VERSION >= \"1.7.0\"",
		"\t\t\tif pod.build_as_static?",
		"\t\t\t\tdef pod.build_as_static?; false end",
		"\t\t\t\tdef pod.build_as_static_framework?; false end",
		"\t\t\t\tdef pod.build_as_dynamic?; true end",
		"\t\t\t\tdef pod.build_as_dynamic_framework?; true end",
		"\t\t\tend",
		"\t\telse",
		"\t\t\tdef pod.static_framework?; false end",
		"\t\tend",
		"\tend",
		"end",
	};

	public override void Run(BuildContext context)
	{
		context.EnsureDirectoryExists(Path.Combine(context.BasePath, "externals"));

		foreach (var project in context.ProjectModels)
		{
			CreateAndInstallPodfile(context, project);

			BuildSdkOnPodfileV2(context, project);
		}
	}

	void BuildSdkOnPodfileV2(BuildContext context, BindingProjectModel project)
	{
		var platforms = new[] {
			PlatformV2.Create (Sdk.iPhoneOS),
			PlatformV2.Create (Sdk.iPhoneSimulator),
		};
		var podsProject = "./Pods/Pods.xcodeproj";
		var workingDirectory = (DirectoryPath)Path.Combine(
			project.Config.BasePath,
			$"externals/build",
			project.Name);

		var targetName = project.Spec.IsSubspec ? project.Spec.ParentSpec.Name : project.Spec.Name;
		var scheme = project.Spec.Name.Replace("/", string.Empty).Replace("-", string.Empty);

		var frameworkName = $"{scheme}.framework";
		var frameworkPaths = GlobbingAliases.GetDirectories(context, $"{workingDirectory}/Pods/**/{frameworkName}");

		var xcframeworkName = $"{scheme}.xcframework";
		var xcframeworkPaths = GlobbingAliases.GetDirectories(context, $"{workingDirectory}/Pods/**/{xcframeworkName}");

		BuildXcodeXcframework(context, podsProject, project.Spec, platforms, workingDirectory: workingDirectory);

		DirectoryAliases.CopyDirectory(context, $"{workingDirectory}/{xcframeworkName}", $"./externals/{xcframeworkName}");
	}


	void BuildXcodeXcframework(BuildContext context, FilePath xcodeProject, CocoaPods.PodSpecDto spec, PlatformV2[] platforms, DirectoryPath workingDirectory, Dictionary<string, string> buildSettings = null)
	{
		if (!Cake.Common.EnvironmentAliases.IsRunningOnMacOs(context))
		{
			context.Log.Warning("{0} is not available on the current platform.", "xcodebuild");
			return;
		}

		buildSettings = buildSettings ?? new Dictionary<string, string>();

		context.Log.Information($"Building the following framework: {spec.Name}...");

		var targetName = spec.IsSubspec ? spec.ParentSpec.Name : spec.Name;
		var frameworkName = spec.Name.Replace("/", string.Empty).Replace("-", string.Empty);

		var buildDirectory = workingDirectory.Combine(spec.Name);
		var xcodeBuildArgs = new ProcessArgumentBuilder();
		xcodeBuildArgs.Append("-create-xcframework");
		xcodeBuildArgs.Append($"-output {workingDirectory}/{frameworkName}.xcframework");

		foreach (var platform in platforms)
		{
			context.Log.Information($"Building {spec.Name} framework with {platform.Sdk} platform SDK...");

			var sdk = string.Equals(platform.Sdk, Sdk.macCatalyst) ? Sdk.macOS : platform.Sdk;
			var archs = platform.Archs;
			var archiveDirectory = buildDirectory.Combine($"{platform.Sdk}.xcarchive");
			var archiveFrameworksDirectory = archiveDirectory.Combine("Products/Library/Frameworks");
			xcodeBuildArgs.Append($"-framework {archiveFrameworksDirectory}/{frameworkName}.framework");

			if (DirectoryAliases.DirectoryExists(context, archiveDirectory))
				continue;

			var buildSettingsCopy = new Dictionary<string, string>(buildSettings);
			buildSettingsCopy["SKIP_INSTALL"] = "NO";
			buildSettingsCopy["BUILD_LIBRARIES_FOR_DISTRIBUTION"] = "YES";

			if (string.Equals(platform.Sdk, Sdk.macCatalyst))
				buildSettingsCopy["SUPPORTS_MACCATALYST"] = "YES";

			var xcodeBuildSettings = new XCodeBuildSettings
			{
				Project = workingDirectory.CombineWithFilePath(xcodeProject).ToString(),
				Scheme = targetName,
				Archive = true,
				ArchivePath = archiveDirectory.ToString(),
				Sdk = sdk.Value,
				Verbose = true,
				BuildSettings = buildSettingsCopy
			};

			if (archs != null)
				xcodeBuildSettings.Arch = string.Join(',', archs.Select(a => a.Value).ToArray());

			XCodeAliases.XCodeBuild(context, xcodeBuildSettings);

			context.Log.Information($"Done building {spec.Name} framework with {platform.Sdk} platform SDK...");

			var builtFrameworkDirectories = GlobbingAliases.GetDirectories(context, archiveFrameworksDirectory.Combine("*.framework").ToString());

			context.Log.Information($"Copying the following built frameworks to its respective archives:");
			context.Log.Information(string.Join(",\n", builtFrameworkDirectories.Select(b => b.ToString()).ToArray()));

			foreach (var directory in builtFrameworkDirectories)
			{
				var builtFrameworkName = directory.GetDirectoryName().Replace(".framework", "");

				if (string.Equals(builtFrameworkName, frameworkName))
					continue;

				DirectoryPath destinationDirectory = DirectoryAliases.Directory(context, archiveFrameworksDirectory.ToString().Replace($"{frameworkName}", $"{builtFrameworkName}"));

				destinationDirectory = destinationDirectory.Combine($"{builtFrameworkName}.framework");

				context.Log.Information($"Copying {directory} to {destinationDirectory}");

				DirectoryAliases.CopyDirectory(context, directory, destinationDirectory);
			}

			context.Log.Information($"Building {frameworkName} xcframework...");

			ProcessAliases.StartProcess(context, "xcodebuild", new ProcessSettings { Arguments = xcodeBuildArgs });
		}
	}


	static void CreateAndInstallPodfile(BuildContext context, BindingProjectModel project)
	{
		var podfile = new List<string>();
		var podfileBegin = new List<string>(PODFILE_BEGIN);

		podfileBegin[0] = string.Format(podfileBegin[0], project.Config.PlatformVersion);
		podfile.AddRange(podfileBegin);

		// TODO Need to check if it's required
		podfile.AddRange(dynamicFrameworkLines);

		podfile.AddRange(PODFILE_TARGET);

		podfile.AddRange(project.Spec.BuildPodLines());

		if (project.Spec.Dependencies?.Count > 0)
		{
			foreach (var dependency in project.Spec.Dependencies)
			{
				podfile.AddRange(dependency.BuildPodLines());
			}
		}

		if (podfile.Count == PODFILE_BEGIN.Length + PODFILE_TARGET.Length + dynamicFrameworkLines.Length)
			return;

		podfile.AddRange(PODFILE_END);

		var podfilePath = Path.Combine(project.Config.BasePath, $"./externals/build/{project.Name}");
		context.EnsureDirectoryExists(podfilePath);

		Cake.FileHelpers.FileHelperAliases.FileWriteLines(context, $"{podfilePath}/Podfile", podfile.ToArray());
		Cake.CocoaPods.CocoaPodAliases.CocoaPodInstall(context, podfilePath);
	}
}


struct Arch
{
	public static Arch ArmV7 { get; } = new Arch("armv7");
	public static Arch ArmV7k { get; } = new Arch("armv7k");
	public static Arch Arm64 { get; } = new Arch("arm64");
	public static Arch Arm64e { get; } = new Arch("arm64e");
	public static Arch Arm64_32 { get; } = new Arch("arm64_32");
	public static Arch i386 { get; } = new Arch("i386");
	public static Arch x86_64 { get; } = new Arch("x86_64");

	public string Value { get; private set; }

	Arch(string value)
	{
		Value = value;
	}

	public override string ToString() => Value;
}

struct Sdk
{
	public static Sdk iPhoneOS { get; } = new Sdk("iphoneos");
	public static Sdk iPhoneSimulator { get; } = new Sdk("iphonesimulator");
	public static Sdk macCatalyst { get; } = new Sdk("maccatalyst");
	public static Sdk macOS { get; } = new Sdk("macosx");
	public static Sdk tvOS { get; } = new Sdk("appletvos");
	public static Sdk tvSimulator { get; } = new Sdk("appletvsimulator");
	public static Sdk watchOS { get; } = new Sdk("watchos");
	public static Sdk watchSimulator { get; } = new Sdk("watchsimulator");

	public string Value { get; private set; }

	Sdk(string value)
	{
		Value = value;
	}

	public override string ToString() => Value;
}

struct PlatformV2
{
	#region Properties

	public Sdk Sdk { get; private set; }
	// If null, default archs will be used at build time.
	public Arch[] Archs { get; private set; }

	#endregion

	#region Constructors

	PlatformV2(Sdk sdk, Arch[] archs)
	{
		Sdk = sdk;
		Archs = archs;
	}

	#endregion

	#region Public Functionality

	public static PlatformV2 Create(Sdk sdk, Arch[] archs = null) => new PlatformV2(sdk, archs);
	public override string ToString() => $"{Sdk} => {string.Join(", ", Archs)}";

	#endregion
}
