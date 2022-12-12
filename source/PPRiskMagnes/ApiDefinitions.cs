using Foundation;
using PPRiskMagnes;
using UIKit;

namespace PPRiskMagnes
{
	// @interface MagnesCryptoUtil : NSObject
	[BaseType (typeof(NSObject))]
	interface MagnesCryptoUtil
	{
		// +(NSString *)getDCIdWithAppGuid:(NSString *)appGuid withTimestamp:(NSString *)timestamp;
		[Static]
		[Export ("getDCIdWithAppGuid:withTimestamp:")]
		string GetDCIdWithAppGuid (string appGuid, string timestamp);

		// +(NSString *)getMGIdWithAppGuid:(NSString *)appGuid withTimeStamp:(NSString *)timestampN withPairingId:(NSString *)pairingId withMGIDKey:(NSString *)mgIdKey;
		[Static]
		[Export ("getMGIdWithAppGuid:withTimeStamp:withPairingId:withMGIDKey:")]
		string GetMGIdWithAppGuid (string appGuid, string timestampN, string pairingId, string mgIdKey);
	}

	// @interface MagnesSystemConfigUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface MagnesSystemConfigUtils
	{
		// +(NSString *)getCPUType;
		[Static]
		[Export ("getCPUType")]
		string CPUType { get; }

		// +(NSString *)getCPUName;
		[Static]
		[Export ("getCPUName")]
		string CPUName { get; }

		// +(NSString *)getHardwareModel;
		[Static]
		[Export ("getHardwareModel")]
		string HardwareModel { get; }

		// +(NSString *)getKernelVersion;
		[Static]
		[Export ("getKernelVersion")]
		string KernelVersion { get; }
	}

	// @interface MagnesResult : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC12PPRiskMagnes12MagnesResult")]
	[DisableDefaultCtor]
	interface MagnesResult
	{
		// -(NSDictionary<NSString *,id> * _Nonnull)getDeviceInfo __attribute__((warn_unused_result("")));
		[Export ("getDeviceInfo")]
		NSDictionary<NSString, NSObject> DeviceInfo { get; }

		// -(NSString * _Nonnull)getPayPalClientMetaDataId __attribute__((warn_unused_result("")));
		[Export ("getPayPalClientMetaDataId")]
		string PayPalClientMetaDataId { get; }
	}

	// @interface MagnesSDK : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC12PPRiskMagnes9MagnesSDK")]
	[DisableDefaultCtor]
	interface MagnesSDK
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull appIdErrorMessage;
		[Export ("appIdErrorMessage")]
		string AppIdErrorMessage { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull cmidErrorMessage;
		[Export ("cmidErrorMessage")]
		string CmidErrorMessage { get; }

		// +(MagnesSDK * _Nonnull)shared __attribute__((warn_unused_result("")));
		[Static]
		[Export ("shared")]
		MagnesSDK Shared { get; }

		// -(BOOL)setUpWithSetEnviroment:(enum Environment)env setOptionalAppGuid:(NSString * _Nonnull)appGuid setOptionalAPNToken:(NSString * _Nonnull)apnToken disableRemoteConfiguration:(BOOL)isRemoteConfigDisabled disableBeacon:(BOOL)isBeaconDisabled magnesSource:(enum MagnesSource)source error:(NSError * _Nullable * _Nullable)error;
		[Export ("setUpWithSetEnviroment:setOptionalAppGuid:setOptionalAPNToken:disableRemoteConfiguration:disableBeacon:magnesSource:error:")]
		bool SetUpWithSetEnviroment (Environment env, string appGuid, string apnToken, bool isRemoteConfigDisabled, bool isBeaconDisabled, MagnesSource source, [NullAllowed] out NSError error);

		// -(MagnesResult * _Nonnull)collect __attribute__((warn_unused_result("")));
		[Export ("collect")]
		MagnesResult Collect { get; }

		// -(MagnesResult * _Nullable)collectWithPayPalClientMetadataId:(NSString * _Nonnull)cmid withAdditionalData:(NSDictionary<NSString *,NSString *> * _Nonnull)additionalData error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("collectWithPayPalClientMetadataId:withAdditionalData:error:")]
		[return: NullAllowed]
		MagnesResult CollectWithPayPalClientMetadataId (string cmid, NSDictionary<NSString, NSString> additionalData, [NullAllowed] out NSError error);

		// -(MagnesResult * _Nonnull)collectAndSubmit __attribute__((warn_unused_result("")));
		[Export ("collectAndSubmit")]
		MagnesResult CollectAndSubmit { get; }

		// -(MagnesResult * _Nullable)collectAndSubmitWithPayPalClientMetadataId:(NSString * _Nonnull)cmid withAdditionalData:(NSDictionary<NSString *,NSString *> * _Nonnull)additionalData error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export ("collectAndSubmitWithPayPalClientMetadataId:withAdditionalData:error:")]
		[return: NullAllowed]
		MagnesResult CollectAndSubmitWithPayPalClientMetadataId (string cmid, NSDictionary<NSString, NSString> additionalData, [NullAllowed] out NSError error);

		// -(void)registerTelemetryOn:(UITextField * _Nonnull)textField withViewId:(NSString * _Nonnull)viewId withPayPalClientMetadataId:(NSString * _Nonnull)cmid;
		[Export ("registerTelemetryOn:withViewId:withPayPalClientMetadataId:")]
		void RegisterTelemetryOn (UITextField textField, string viewId, string cmid);

		// -(void)unregisterTelemetryOn:(UITextField * _Nonnull)textField;
		[Export ("unregisterTelemetryOn:")]
		void UnregisterTelemetryOn (UITextField textField);

		// -(void)collectTelemetryDataWithTextField:(UITextField * _Nonnull)textField range:(NSRange)range replacementString:(NSString * _Nonnull)replacementString;
		[Export ("collectTelemetryDataWithTextField:range:replacementString:")]
		void CollectTelemetryDataWithTextField (UITextField textField, NSRange range, string replacementString);

		// -(void)collectTouchData:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event forTouchPhase:(enum UITouchPhase)phase withPayPalClientMetadataId:(NSString * _Nonnull)cmid;
		[Export ("collectTouchData:withEvent:forTouchPhase:withPayPalClientMetadataId:")]
		void CollectTouchData (NSSet<UITouch> touches, [NullAllowed] UIEvent @event, UITouchPhase phase, string cmid);
	}
}
