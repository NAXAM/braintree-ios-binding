using System;
using BraintreeCore;
using BraintreeDataCollector;
using Foundation;
using ObjCRuntime;

namespace BraintreeDataCollector
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreeCoreVersionNumber;
		[Field ("BraintreeCoreVersionNumber", "__Internal")]
		double BraintreeCoreVersionNumber { get; }

		// extern const unsigned char [] BraintreeCoreVersionString;
		[Field ("BraintreeCoreVersionString", "__Internal")]
		byte[] BraintreeCoreVersionString { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTJSONErrorDomain;
		[Field ("BTJSONErrorDomain", "__Internal")]
		NSString BTJSONErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTAPIClientErrorDomain;
		[Field ("BTAPIClientErrorDomain", "__Internal")]
		NSString BTAPIClientErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTAppSwitchWillSwitchNotification;
		[Field ("BTAppSwitchWillSwitchNotification", "__Internal")]
		NSString BTAppSwitchWillSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchDidSwitchNotification;
		[Field ("BTAppSwitchDidSwitchNotification", "__Internal")]
		NSString BTAppSwitchDidSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchWillProcessPaymentInfoNotification;
		[Field ("BTAppSwitchWillProcessPaymentInfoNotification", "__Internal")]
		NSString BTAppSwitchWillProcessPaymentInfoNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchNotificationTargetKey;
		[Field ("BTAppSwitchNotificationTargetKey", "__Internal")]
		NSString BTAppSwitchNotificationTargetKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTClientTokenKeyVersion;
		[Field ("BTClientTokenKeyVersion", "__Internal")]
		NSString BTClientTokenKeyVersion { get; }

		// extern NSString *const _Nonnull BTClientTokenErrorDomain;
		[Field ("BTClientTokenErrorDomain", "__Internal")]
		NSString BTClientTokenErrorDomain { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyAuthorizationFingerprint;
		[Field ("BTClientTokenKeyAuthorizationFingerprint", "__Internal")]
		NSString BTClientTokenKeyAuthorizationFingerprint { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyConfigURL;
		[Field ("BTClientTokenKeyConfigURL", "__Internal")]
		NSString BTClientTokenKeyConfigURL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTCustomerInputBraintreeValidationErrorsKey;
		[Field ("BTCustomerInputBraintreeValidationErrorsKey", "__Internal")]
		NSString BTCustomerInputBraintreeValidationErrorsKey { get; }

		// extern NSString *const BTHTTPErrorDomain;
		[Field ("BTHTTPErrorDomain", "__Internal")]
		NSString BTHTTPErrorDomain { get; }

		// extern NSString *const BTHTTPURLResponseKey;
		[Field ("BTHTTPURLResponseKey", "__Internal")]
		NSString BTHTTPURLResponseKey { get; }

		// extern NSString *const BTHTTPJSONResponseBodyKey;
		[Field ("BTHTTPJSONResponseBodyKey", "__Internal")]
		NSString BTHTTPJSONResponseBodyKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTTokenizationServiceErrorDomain;
		[Field ("BTTokenizationServiceErrorDomain", "__Internal")]
		NSString BTTokenizationServiceErrorDomain { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceAppSwitchDelegateOption;
		[Field ("BTTokenizationServiceAppSwitchDelegateOption", "__Internal")]
		NSString BTTokenizationServiceAppSwitchDelegateOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceViewPresentingDelegateOption;
		[Field ("BTTokenizationServiceViewPresentingDelegateOption", "__Internal")]
		NSString BTTokenizationServiceViewPresentingDelegateOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServicePayPalScopesOption;
		[Field ("BTTokenizationServicePayPalScopesOption", "__Internal")]
		NSString BTTokenizationServicePayPalScopesOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceAmountOption;
		[Field ("BTTokenizationServiceAmountOption", "__Internal")]
		NSString BTTokenizationServiceAmountOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceNonceOption;
		[Field ("BTTokenizationServiceNonceOption", "__Internal")]
		NSString BTTokenizationServiceNonceOption { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreeDataCollectorVersionNumber;
		[Field ("BraintreeDataCollectorVersionNumber", "__Internal")]
		double BraintreeDataCollectorVersionNumber { get; }

		// extern const unsigned char [] BraintreeDataCollectorVersionString;
		[Field ("BraintreeDataCollectorVersionString", "__Internal")]
		byte[] BraintreeDataCollectorVersionString { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTDataCollectorKountErrorDomain;
		[Field ("BTDataCollectorKountErrorDomain", "__Internal")]
		NSString BTDataCollectorKountErrorDomain { get; }
	}

	// @interface BTDataCollector : NSObject
	[BaseType (typeof(NSObject))]
	interface BTDataCollector
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		BTDataCollectorDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BTDataCollectorDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithEnvironment:(BTDataCollectorEnvironment)environment __attribute__((deprecated("Use BTDataCollector initWithAPIClient: instead")));
		[Export ("initWithEnvironment:")]
		IntPtr Constructor (BTDataCollectorEnvironment environment);

		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient;
		[Export ("initWithAPIClient:")]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)collectFraudData:(void (^ _Nonnull)(NSString * _Nonnull))completion;
		[Export ("collectFraudData:")]
		void CollectFraudData (Action<NSString> completion);

		// -(void)collectCardFraudData:(void (^ _Nonnull)(NSString * _Nonnull))completion;
		[Export ("collectCardFraudData:")]
		void CollectCardFraudData (Action<NSString> completion);

		// -(void)setFraudMerchantId:(NSString * _Nonnull)fraudMerchantId;
		[Export ("setFraudMerchantId:")]
		void SetFraudMerchantId (string fraudMerchantId);

		// -(void)setCollectorUrl:(NSString * _Nonnull)url __attribute__((deprecated("The collector URL is no longer used. The environment will be automatically chosen.")));
		[Export ("setCollectorUrl:")]
		void SetCollectorUrl (string url);

		// +(NSString * _Nullable)payPalClientMetadataId __attribute__((deprecated("Integrate PayPalDataCollector and use PPDataCollector +clientMetadataID instead.")));
		[Static]
		[NullAllowed, Export ("payPalClientMetadataId")]
		[Verify (MethodToProperty)]
		string PayPalClientMetadataId { get; }

		// -(NSString * _Nonnull)collectCardFraudData __attribute__((deprecated("Use BTDataCollector -collectCardFraudData: instead")));
		[Export ("collectCardFraudData")]
		[Verify (MethodToProperty)]
		string CollectCardFraudData { get; }

		// -(NSString * _Nonnull)collectPayPalClientMetadataId __attribute__((deprecated("Integrate PayPalDataCollector and use PPDataCollector +collectPayPalDeviceData instead.")));
		[Export ("collectPayPalClientMetadataId")]
		[Verify (MethodToProperty)]
		string CollectPayPalClientMetadataId { get; }

		// -(NSString * _Nonnull)collectFraudData __attribute__((deprecated("Use BTDataCollector -collectFraudData: instead")));
		[Export ("collectFraudData")]
		[Verify (MethodToProperty)]
		string CollectFraudData { get; }
	}

	// @protocol BTDataCollectorDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTDataCollectorDelegate
	{
		// @required -(void)dataCollectorDidComplete:(BTDataCollector * _Nonnull)dataCollector;
		[Abstract]
		[Export ("dataCollectorDidComplete:")]
		void DataCollectorDidComplete (BTDataCollector dataCollector);

		// @optional -(void)dataCollectorDidStart:(BTDataCollector * _Nonnull)dataCollector;
		[Export ("dataCollectorDidStart:")]
		void DataCollectorDidStart (BTDataCollector dataCollector);

		// @optional -(void)dataCollector:(BTDataCollector * _Nonnull)dataCollector didFailWithError:(NSError * _Nonnull)error;
		[Export ("dataCollector:didFailWithError:")]
		void DataCollector (BTDataCollector dataCollector, NSError error);
	}
}
