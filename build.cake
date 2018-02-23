#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0

// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=2.0.0

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var VERSION = "4.11.0";

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var solutionPath = "./braintree-ios.sln";
var artifacts = new [] {
    new Artifact {
        AssemblyInfoPath = "./Naxam.Braintree3DSecure.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-3dsecure.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCard.iOS"
        },
        Name = "3DSecure"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeAmericanExpress.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-americanexpress.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCore.iOS"
        },
        Name = "Core"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeApplePay.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-applepay.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCore.iOS"
        },
        Name = "ApplyPay"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeCard.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-card.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCore.iOS"
        },
        Name = "Card"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeCore.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-core.nuspec",
        Dependencies = new string [] { 
        }
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeDataCollector.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-datacollector.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCore.iOS"
        },
        Name = "DataCollector"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreePaymentFlow.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-paymentflow.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCard.iOS"
        },
        Name = "PaymentFlow"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreePayPal.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-paypal.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCore.iOS",
            "Naxam.PayPalOneTouch.iOS"
        },
        Name = "PayPal"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeUI.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-ui.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCore.iOS"
        },
        Name = "UI"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeUnionPay.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-unionpay.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCard.iOS"
        },
        Name = "UnionPay"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeVenmo.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-venmo.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeCard.iOS"
        },
        Name = "Venmo"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.PayPal.Risk.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./paypal-risk.nuspec",
        Dependencies = new string[] { 
        },
        Name = "PayPal Risk"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.PayPalDataCollector.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./paypal-datacollector.nuspec",
        Dependencies = new [] { 
            "Naxam.PayPal.Risk.iOS",
            "Naxam.PayPalUtils.iOS"
        }
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.PayPalOneTouch.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./paypal-onetouch.nuspec",
        Dependencies = new string[] { 
            "Naxam.BraintreeCore.iOS",
            "Naxam.PayPalDataCollector.iOS"
        },
        Name = "PayPal OneTouch"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.PayPalUtils.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./paypal-utils.nuspec",
        Dependencies = new string[] {
        },
        Name = "PayPal Utils"
    },
};

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
{
    CleanDirectory("./packages");

    var nugetPackages = GetFiles("./*.nupkg");

    foreach (var package in nugetPackages)
    {
        DeleteFile(package);
    }
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore(solutionPath);
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{
    MSBuild(solutionPath, settings => settings.SetConfiguration(configuration));
});

Task("UpdateVersion")
    .Does(() => 
{
    foreach(var artifact in artifacts) {
        ReplaceRegexInFiles(artifact.AssemblyInfoPath, "\\[assembly\\: AssemblyVersion([^\\]]+)\\]", string.Format("[assembly: AssemblyVersion(\"{0}\")]", VERSION));
    }
});

Task("Pack")
    .IsDependentOn("UpdateVersion")
    .IsDependentOn("Build")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        NuGetPack(artifact.NuspecPath, new NuGetPackSettings {
            Version = VERSION,
            ReleaseNotes = new [] {
                string.Format("Braintree iOS SDK v{0} - {1}", VERSION, artifact.Name)
            },
            Dependencies = artifact.Dependencies.Select(x =>
                new NuSpecDependency {
                    Id = x,
                    Version = VERSION
                }).ToArray()
        });
    }
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Pack");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);

class Artifact {
    public string AssemblyInfoPath { get; set; }

    public string NuspecPath { get; set; }

    public string[] Dependencies { get; set; }

    public string Name { get; set; }
}