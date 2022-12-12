using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace KountDataCollector
{
	// @interface KDataCollector : NSObject
	[BaseType (typeof(NSObject))]
	interface KDataCollector
	{
		// +(KDataCollector * _Nonnull)sharedCollector;
		[Static]
		[Export ("sharedCollector")]
		KDataCollector SharedCollector { get; }

		// @property NSInteger merchantID;
		[Export ("merchantID")]
		nint MerchantID { get; set; }

		// @property KLocationCollectorConfig locationCollectorConfig;
		[Export ("locationCollectorConfig", ArgumentSemantic.Assign)]
		KLocationCollectorConfig LocationCollectorConfig { get; set; }

		// @property BOOL debug;
		[Export ("debug")]
		bool Debug { get; set; }

		// @property NSInteger timeoutInMS;
		[Export ("timeoutInMS")]
		nint TimeoutInMS { get; set; }

		// @property KEnvironment environment;
		[Export ("environment", ArgumentSemantic.Assign)]
		KEnvironment Environment { get; set; }

		// @property NSDictionary *deviceDataForAnalytics;
		[Export ("deviceDataForAnalytics", ArgumentSemantic.Strong)]
		NSDictionary DeviceDataForAnalytics { get; set; }

		// -(void)collectForSession:(NSString * _Nonnull)sessionID completion:(void (^ _Nullable)(NSString * _Nonnull, BOOL, NSError * _Nullable))completionBlock;
		[Export ("collectForSession:completion:")]
		void CollectForSession (string sessionID, [NullAllowed] Action<NSString, bool, NSError> completionBlock);
	}

	// @interface KountAnalyticsViewController : UIViewController <UITextFieldDelegate, UITextViewDelegate, UISearchBarDelegate> {
	[BaseType (typeof(UIViewController))]
	interface KountAnalyticsViewController : IUITextFieldDelegate, IUITextViewDelegate, IUISearchBarDelegate
	{
		// + (id)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		KountAnalyticsViewController SharedInstance { get; }

		// + (void)setColorWellButtonType;
		[Static]
		[Export ("setColorWellButtonType")]
		void SetColorWellButtonType();

		// - (NSString *)getColorWellButtonType;
		[Export ("getColorWellButtonType")]
		string GetColorWellButtonType();

		// + (NSString *)getAppSessionID;
		[Static]
		[Export ("getAppSessionID")]
		string GetAppSessionID();

		// - (BOOL)checkIsDeviceJailbroken;
		[Export ("checkIsDeviceJailbroken")]
		bool CheckIsDeviceJailbroken();

		// - (void)appear;
		[Export ("appear")]
		void Appear();

		// - (void)disappear;
		[Export ("disappear")]
		void Disappear();

		// - (int64_t)getEpochTime;
		[Export ("getEpochTime")]
		long GetEpochTime();

		// - (void)storeDeletionTime;
		[Export ("storeDeletionTime")]
		void StoreDeletionTime();

		// - (void)storeStartingTime;
		[Export ("storeStartingTime")]
		void StoreStartingTime();

		// - (void)msDifferenceBetweenCharacter;
		[Export ("msDifferenceBetweenCharacter")]
		void MsDifferenceBetweenCharacter();
		
		// - (void)allMsDifferenceBetweenKeys;
		[Export ("allMsDifferenceBetweenKeys")]
		void AllMsDifferenceBetweenKeys();

		// - (void)assignInputData;
		[Export ("assignInputData")]
		void AssignInputData();

		// - (void)deviceDidRotate:(NSNotification *)notification;
		[Export ("deviceDidRotate:")]
		void DeviceDidRotate(NSNotification notification);

		// - (void)collectBatteryData;
		[Export ("collectBatteryData")]
		void CollectBatteryData();

		// - (void)getBatteryState;
		[Export ("getBatteryState")]
		void GetBatteryState();

		// - (void)getBatteryLevel;
		[Export ("getBatteryLevel")]
		void GetBatteryLevel();

		// - (void)getLowPowerModeStatus;
		[Export ("getLowPowerModeStatus")]
		void GetLowPowerModeStatus();

		// - (void)didChangeBatteryState:(NSNotification *)notification;
		[Export ("didChangeBatteryState:")]
		void DidChangeBatteryState(NSNotification notification);

		// - (void)didChangeBatteryLevel:(NSNotification *)notification;
		[Export ("didChangeBatteryLevel:")]
		void DidChangeBatteryLevel(NSNotification notification);

		// - (void)didChangePowerMode:(NSNotification *)notification;
		[Export ("didChangePowerMode:")]
		void DidChangePowerMode(NSNotification notification);

		// - (void)assignBatteryData;
		[Export ("assignBatteryData")]
		void AssignBatteryData();

		// - (void)getDeviceOrientationData;
		[Export ("getDeviceOrientationData")]
		void GetDeviceOrientationData();

		// - (void)collectDeviceOrientationData;
		[Export ("collectDeviceOrientationData")]
		void CollectDeviceOrientationData();

		// - (void)assignDeviceOrientationData;
		[Export ("assignDeviceOrientationData")]
		void AssignDeviceOrientationData();

		// - (void)checkForDeviceMotion;
		[Export ("checkForDeviceMotion")]
		void CheckForDeviceMotion();

		// - (void)collect:(NSString *)sessionID analyticsSwitch:(BOOL)analyticsData completion:(nullable void (^)(NSString *_Nonnull sessionID, BOOL success, NSError *_Nullable error))completionBlock;
		[Export ("collect:analyticsSwitch:completion:")]
		void Collect(string sessionId, bool analyticsData, Action<string, bool, NSError> completion);

		// - (NSString *)getSessionID;
		[Export ("getSessionID")]
		string GetSessionID();

		// - (void)createJsonObjectFormat;
		[Export ("createJsonObjectFormat")]
		void CreateJsonObjectFormat();

		// - (void)storeLogInEvents:(BOOL)logInStatus;
		[Export ("storeLogInEvents:")]
		void StoreLogInEvents(bool logInStatus);

		// - (void)assignFormData;
		[Export ("assignFormData")]
		void AssignFormData();

		// - (void)setEnvironmentForAnalytics:(KEnvironment)env;
		[Export ("setEnvironmentForAnalytics:")]
		void SetEnvironmentForAnalytics(KEnvironment env);

		// - (void)registerBackgroundTask;
		[Export ("registerBackgroundTask")]
		void RegisterBackgroundTask();

		// - (void)appInBackground;
		[Export ("appInBackground")]
		void AppInBackground();
	}
}
