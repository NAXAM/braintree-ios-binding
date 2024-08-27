namespace X;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	[Export("window")]
	public UIWindow Window { get; set; }

	[Export ("application:didFinishLaunchingWithOptions:")]
	public bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// Override point for customization after application launch.
		// If not required for your application you can safely delete this method
		return true;
	}
}

