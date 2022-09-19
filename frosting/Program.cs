using System.Collections.Generic;
using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.Frosting;
using CocoaPods.Binderator;
using System.IO;

public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}

public class BuildContext : FrostingContext
{
    public bool IsLocalBuild { get; set; }
    public List<BindingProjectModel> ProjectModels { get; set; }

    public string ConfigPath => Path.Combine(BasePath ?? string.Empty, "config.json");
	public string BasePath { get; set; }

	public BuildContext(ICakeContext context)
        : base(context)
    {
        IsLocalBuild = string.IsNullOrWhiteSpace (Environment.GetEnvironmentVariable("AGENT_ID"));

		Log.Information($"Is a local build? {IsLocalBuild}");

    	BasePath = context.Arguments.GetArgument("base-path") ?? "../";
		Log.Information($"BASE_PATH: {BasePath}");
	}
}