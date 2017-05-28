using System;
using BraintreeCore;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace BraintreeCore
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

	// @interface BTClientMetadata : NSObject <NSCopying, NSMutableCopying>
	[BaseType (typeof(NSObject))]
	interface BTClientMetadata : INSCopying, INSMutableCopying
	{
		// @property (readonly, assign, nonatomic) BTClientMetadataIntegrationType integration;
		[Export ("integration", ArgumentSemantic.Assign)]
		BTClientMetadataIntegrationType Integration { get; }

		// @property (readonly, assign, nonatomic) BTClientMetadataSourceType source;
		[Export ("source", ArgumentSemantic.Assign)]
		BTClientMetadataSourceType Source { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sessionId;
		[Export ("sessionId")]
		string SessionId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull integrationString;
		[Export ("integrationString")]
		string IntegrationString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sourceString;
		[Export ("sourceString")]
		string SourceString { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nonnull parameters;
		[Export ("parameters", ArgumentSemantic.Strong)]
		NSDictionary Parameters { get; }
	}

	// @interface BTMutableClientMetadata : BTClientMetadata
	[BaseType (typeof(BTClientMetadata))]
	interface BTMutableClientMetadata
	{
		// -(void)setIntegration:(BTClientMetadataIntegrationType)integration;
		[Export ("setIntegration:")]
		void SetIntegration (BTClientMetadataIntegrationType integration);

		// -(void)setSource:(BTClientMetadataSourceType)source;
		[Export ("setSource:")]
		void SetSource (BTClientMetadataSourceType source);

		// -(void)setSessionId:(NSString * _Nonnull)sessionId;
		[Export ("setSessionId:")]
		void SetSessionId (string sessionId);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTJSONErrorDomain;
		[Field ("BTJSONErrorDomain", "__Internal")]
		NSString BTJSONErrorDomain { get; }
	}

	// @interface BTJSON : NSObject
	[BaseType (typeof(NSObject))]
	interface BTJSON
	{
		// -(instancetype _Nonnull)initWithValue:(id _Nonnull)value;
		[Export ("initWithValue:")]
		IntPtr Constructor (NSObject value);

		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		IntPtr Constructor (NSData data);

		// -(id _Nonnull)objectForKeyedSubscript:(NSString * _Nonnull)key;
		[Export ("objectForKeyedSubscript:")]
		NSObject ObjectForKeyedSubscript (string key);

		// -(BTJSON * _Nonnull)objectAtIndexedSubscript:(NSUInteger)idx;
		[Export ("objectAtIndexedSubscript:")]
		BTJSON ObjectAtIndexedSubscript (nuint idx);

		// @property (readonly, assign, nonatomic) BOOL isError;
		[Export ("isError")]
		bool IsError { get; }

		// -(NSError * _Nullable)asError;
		[NullAllowed, Export ("asError")]
		[Verify (MethodToProperty)]
		NSError AsError { get; }

		// -(NSData * _Nullable)asJSONAndReturnError:(NSError * _Nullable * _Nullable)error;
		[Export ("asJSONAndReturnError:")]
		[return: NullAllowed]
		NSData AsJSONAndReturnError ([NullAllowed] out NSError error);

		// -(NSString * _Nullable)asPrettyJSONAndReturnError:(NSError * _Nullable * _Nullable)error;
		[Export ("asPrettyJSONAndReturnError:")]
		[return: NullAllowed]
		string AsPrettyJSONAndReturnError ([NullAllowed] out NSError error);

		// -(NSString * _Nullable)asString;
		[NullAllowed, Export ("asString")]
		[Verify (MethodToProperty)]
		string AsString { get; }

		// -(NSArray<BTJSON *> * _Nullable)asArray;
		[NullAllowed, Export ("asArray")]
		[Verify (MethodToProperty)]
		BTJSON[] AsArray { get; }

		// -(NSDecimalNumber * _Nullable)asNumber;
		[NullAllowed, Export ("asNumber")]
		[Verify (MethodToProperty)]
		NSDecimalNumber AsNumber { get; }

		// -(NSURL * _Nullable)asURL;
		[NullAllowed, Export ("asURL")]
		[Verify (MethodToProperty)]
		NSUrl AsURL { get; }

		// -(NSArray<NSString *> * _Nullable)asStringArray;
		[NullAllowed, Export ("asStringArray")]
		[Verify (MethodToProperty)]
		string[] AsStringArray { get; }

		// -(NSDictionary * _Nullable)asDictionary;
		[NullAllowed, Export ("asDictionary")]
		[Verify (MethodToProperty)]
		NSDictionary AsDictionary { get; }

		// -(NSInteger)asIntegerOrZero;
		[Export ("asIntegerOrZero")]
		[Verify (MethodToProperty)]
		nint AsIntegerOrZero { get; }

		// -(NSInteger)asEnum:(NSDictionary * _Nonnull)mapping orDefault:(NSInteger)defaultValue;
		[Export ("asEnum:orDefault:")]
		nint AsEnum (NSDictionary mapping, nint defaultValue);

		// @property (readonly, assign, nonatomic) BOOL isString;
		[Export ("isString")]
		bool IsString { get; }

		// @property (readonly, assign, nonatomic) BOOL isNumber;
		[Export ("isNumber")]
		bool IsNumber { get; }

		// @property (readonly, assign, nonatomic) BOOL isArray;
		[Export ("isArray")]
		bool IsArray { get; }

		// @property (readonly, assign, nonatomic) BOOL isObject;
		[Export ("isObject")]
		bool IsObject { get; }

		// @property (readonly, assign, nonatomic) BOOL isTrue;
		[Export ("isTrue")]
		bool IsTrue { get; }

		// @property (readonly, assign, nonatomic) BOOL isFalse;
		[Export ("isFalse")]
		bool IsFalse { get; }

		// @property (readonly, assign, nonatomic) BOOL isNull;
		[Export ("isNull")]
		bool IsNull { get; }
	}

	// @interface BTConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTConfiguration
	{
		// -(instancetype _Nonnull)initWithJSON:(BTJSON * _Nonnull)json __attribute__((objc_designated_initializer));
		[Export ("initWithJSON:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTJSON json);

		// @property (readonly, nonatomic, strong) BTJSON * _Nonnull json;
		[Export ("json", ArgumentSemantic.Strong)]
		BTJSON Json { get; }

		// +(BOOL)isBetaEnabledPaymentOption:(NSString * _Nonnull)paymentOption __attribute__((deprecated("Pay with Venmo is no longer in beta")));
		[Static]
		[Export ("isBetaEnabledPaymentOption:")]
		bool IsBetaEnabledPaymentOption (string paymentOption);

		// +(void)setBetaPaymentOption:(NSString * _Nonnull)paymentOption isEnabled:(BOOL)isEnabled __attribute__((deprecated("Pay with Venmo is no longer in beta")));
		[Static]
		[Export ("setBetaPaymentOption:isEnabled:")]
		void SetBetaPaymentOption (string paymentOption, bool isEnabled);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTAPIClientErrorDomain;
		[Field ("BTAPIClientErrorDomain", "__Internal")]
		NSString BTAPIClientErrorDomain { get; }
	}

	// @interface BTAPIClient : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTAPIClient
	{
		// -(instancetype _Nullable)initWithAuthorization:(NSString * _Nonnull)authorization;
		[Export ("initWithAuthorization:")]
		IntPtr Constructor (string authorization);

		// -(instancetype _Nonnull)copyWithSource:(BTClientMetadataSourceType)source integration:(BTClientMetadataIntegrationType)integration;
		[Export ("copyWithSource:integration:")]
		BTAPIClient CopyWithSource (BTClientMetadataSourceType source, BTClientMetadataIntegrationType integration);

		// -(void)fetchOrReturnRemoteConfiguration:(void (^ _Nonnull)(BTConfiguration * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("fetchOrReturnRemoteConfiguration:")]
		void FetchOrReturnRemoteConfiguration (Action<BTConfiguration, NSError> completionBlock);

		// -(void)fetchPaymentMethodNonces:(void (^ _Nonnull)(NSArray<BTPaymentMethodNonce *> * _Nullable, NSError * _Nullable))completion;
		[Export ("fetchPaymentMethodNonces:")]
		void FetchPaymentMethodNonces (Action<NSArray<BTPaymentMethodNonce>, NSError> completion);

		// -(void)fetchPaymentMethodNonces:(BOOL)defaultFirst completion:(void (^ _Nonnull)(NSArray<BTPaymentMethodNonce *> * _Nullable, NSError * _Nullable))completion;
		[Export ("fetchPaymentMethodNonces:completion:")]
		void FetchPaymentMethodNonces (bool defaultFirst, Action<NSArray<BTPaymentMethodNonce>, NSError> completion);

		// -(void)GET:(NSString * _Nonnull)path parameters:(NSDictionary<NSString *,NSString *> * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("GET:parameters:completion:")]
		void GET (string path, [NullAllowed] NSDictionary<NSString, NSString> parameters, [NullAllowed] Action<BTJSON, NSHTTPURLResponse, NSError> completionBlock);

		// -(void)POST:(NSString * _Nonnull)path parameters:(NSDictionary * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("POST:parameters:completion:")]
		void POST (string path, [NullAllowed] NSDictionary parameters, [NullAllowed] Action<BTJSON, NSHTTPURLResponse, NSError> completionBlock);
	}

	// @interface BTAppSwitch : NSObject
	[BaseType (typeof(NSObject))]
	interface BTAppSwitch
	{
		// @property (copy, nonatomic) NSString * _Nonnull returnURLScheme;
		[Export ("returnURLScheme")]
		string ReturnURLScheme { get; set; }

		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		BTAppSwitch SharedInstance ();

		// +(void)setReturnURLScheme:(NSString * _Nonnull)returnURLScheme;
		[Static]
		[Export ("setReturnURLScheme:")]
		void SetReturnURLScheme (string returnURLScheme);

		// +(BOOL)handleOpenURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication;
		[Static]
		[Export ("handleOpenURL:sourceApplication:")]
		bool HandleOpenURL (NSUrl url, [NullAllowed] string sourceApplication);

		// +(BOOL)handleOpenURL:(NSURL * _Nonnull)url options:(NSDictionary * _Nonnull)options;
		[Static]
		[Export ("handleOpenURL:options:")]
		bool HandleOpenURL (NSUrl url, NSDictionary options);

		// -(void)registerAppSwitchHandler:(Class<BTAppSwitchHandler> _Nonnull)handler;
		[Export ("registerAppSwitchHandler:")]
		void RegisterAppSwitchHandler (BTAppSwitchHandler handler);

		// -(void)unregisterAppSwitchHandler:(Class<BTAppSwitchHandler> _Nonnull)handler;
		[Export ("unregisterAppSwitchHandler:")]
		void UnregisterAppSwitchHandler (BTAppSwitchHandler handler);

		// -(BOOL)handleOpenURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nonnull)sourceApplication;
		[Export ("handleOpenURL:sourceApplication:")]
		bool HandleOpenURL (NSUrl url, string sourceApplication);
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

	// @protocol BTAppSwitchDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTAppSwitchDelegate
	{
		// @required -(void)appSwitcherWillPerformAppSwitch:(id _Nonnull)appSwitcher;
		[Abstract]
		[Export ("appSwitcherWillPerformAppSwitch:")]
		void AppSwitcherWillPerformAppSwitch (NSObject appSwitcher);

		// @required -(void)appSwitcher:(id _Nonnull)appSwitcher didPerformSwitchToTarget:(BTAppSwitchTarget)target;
		[Abstract]
		[Export ("appSwitcher:didPerformSwitchToTarget:")]
		void AppSwitcher (NSObject appSwitcher, BTAppSwitchTarget target);

		// @required -(void)appSwitcherWillProcessPaymentInfo:(id _Nonnull)appSwitcher;
		[Abstract]
		[Export ("appSwitcherWillProcessPaymentInfo:")]
		void AppSwitcherWillProcessPaymentInfo (NSObject appSwitcher);
	}

	// @protocol BTAppSwitchHandler
	[Protocol, Model]
	interface BTAppSwitchHandler
	{
		// @required +(BOOL)canHandleAppSwitchReturnURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nonnull)sourceApplication;
		[Static, Abstract]
		[Export ("canHandleAppSwitchReturnURL:sourceApplication:")]
		bool CanHandleAppSwitchReturnURL (NSUrl url, string sourceApplication);

		// @required +(void)handleAppSwitchReturnURL:(NSURL * _Nonnull)url;
		[Static, Abstract]
		[Export ("handleAppSwitchReturnURL:")]
		void HandleAppSwitchReturnURL (NSUrl url);

		// @optional -(BOOL)isiOSAppAvailableForAppSwitch;
		[Export ("isiOSAppAvailableForAppSwitch")]
		[Verify (MethodToProperty)]
		bool IsiOSAppAvailableForAppSwitch { get; }
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

	// @interface BTClientToken : NSObject <NSCoding, NSCopying>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTClientToken : INSCoding, INSCopying
	{
		// @property (readonly, nonatomic, strong) BTJSON * _Nonnull json;
		[Export ("json", ArgumentSemantic.Strong)]
		BTJSON Json { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull authorizationFingerprint;
		[Export ("authorizationFingerprint")]
		string AuthorizationFingerprint { get; }

		// @property (readonly, nonatomic, strong) NSURL * _Nonnull configURL;
		[Export ("configURL", ArgumentSemantic.Strong)]
		NSUrl ConfigURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull originalValue;
		[Export ("originalValue")]
		string OriginalValue { get; }

		// -(instancetype _Nullable)initWithClientToken:(NSString * _Nonnull)clientToken error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export ("initWithClientToken:error:")]
		[DesignatedInitializer]
		IntPtr Constructor (string clientToken, [NullAllowed] out NSError error);
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

	// @interface BTLogger : NSObject
	[BaseType (typeof(NSObject))]
	interface BTLogger
	{
		// +(instancetype)sharedLogger;
		[Static]
		[Export ("sharedLogger")]
		BTLogger SharedLogger ();

		// @property (assign, nonatomic) BTLogLevel level;
		[Export ("level", ArgumentSemantic.Assign)]
		BTLogLevel Level { get; set; }
	}

	// @interface BTPostalAddress : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface BTPostalAddress : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable recipientName;
		[NullAllowed, Export ("recipientName")]
		string RecipientName { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull streetAddress;
		[Export ("streetAddress")]
		string StreetAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable extendedAddress;
		[NullAllowed, Export ("extendedAddress")]
		string ExtendedAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull locality;
		[Export ("locality")]
		string Locality { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull countryCodeAlpha2;
		[Export ("countryCodeAlpha2")]
		string CountryCodeAlpha2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable region;
		[NullAllowed, Export ("region")]
		string Region { get; set; }
	}

	// @interface BTPaymentMethodNonce : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPaymentMethodNonce
	{
		// -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce localizedDescription:(NSString * _Nullable)description type:(NSString * _Nonnull)type;
		[Export ("initWithNonce:localizedDescription:type:")]
		IntPtr Constructor (string nonce, [NullAllowed] string description, string type);

		// -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce localizedDescription:(NSString * _Nullable)description;
		[Export ("initWithNonce:localizedDescription:")]
		IntPtr Constructor (string nonce, [NullAllowed] string description);

		// -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce localizedDescription:(NSString * _Nonnull)description type:(NSString * _Nonnull)type isDefault:(BOOL)isDefault;
		[Export ("initWithNonce:localizedDescription:type:isDefault:")]
		IntPtr Constructor (string nonce, string description, string type, bool isDefault);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull nonce;
		[Export ("nonce")]
		string Nonce { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedDescription;
		[Export ("localizedDescription")]
		string LocalizedDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; }

		// @property (readonly, assign, nonatomic) BOOL isDefault;
		[Export ("isDefault")]
		bool IsDefault { get; }
	}

	// @interface BTPaymentMethodNonceParser : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPaymentMethodNonceParser
	{
		// +(instancetype _Nonnull)sharedParser;
		[Static]
		[Export ("sharedParser")]
		BTPaymentMethodNonceParser SharedParser ();

		// @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nonnull allTypes;
		[Export ("allTypes", ArgumentSemantic.Strong)]
		string[] AllTypes { get; }

		// -(BOOL)isTypeAvailable:(NSString * _Nonnull)type;
		[Export ("isTypeAvailable:")]
		bool IsTypeAvailable (string type);

		// -(void)registerType:(NSString * _Nonnull)type withParsingBlock:(BTPaymentMethodNonce * _Nullable (^ _Nonnull)(BTJSON * _Nonnull))jsonParsingBlock;
		[Export ("registerType:withParsingBlock:")]
		void RegisterType (string type, Func<BTJSON, BTPaymentMethodNonce> jsonParsingBlock);

		// -(BTPaymentMethodNonce * _Nullable)parseJSON:(BTJSON * _Nonnull)json withParsingBlockForType:(NSString * _Nonnull)type;
		[Export ("parseJSON:withParsingBlockForType:")]
		[return: NullAllowed]
		BTPaymentMethodNonce ParseJSON (BTJSON json, string type);
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

	// @interface BTTokenizationService : NSObject
	[BaseType (typeof(NSObject))]
	interface BTTokenizationService
	{
		// +(instancetype _Nonnull)sharedService;
		[Static]
		[Export ("sharedService")]
		BTTokenizationService SharedService ();

		// -(void)registerType:(NSString * _Nonnull)type withTokenizationBlock:(void (^ _Nonnull)(BTAPIClient * _Nonnull, NSDictionary * _Nullable, void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable)))tokenizationBlock;
		[Export ("registerType:withTokenizationBlock:")]
		void RegisterType (string type, Action<BTAPIClient, NSDictionary, Action<BTPaymentMethodNonce, NSError>> tokenizationBlock);

		// -(BOOL)isTypeAvailable:(NSString * _Nonnull)type;
		[Export ("isTypeAvailable:")]
		bool IsTypeAvailable (string type);

		// -(void)tokenizeType:(NSString * _Nonnull)type withAPIClient:(BTAPIClient * _Nonnull)apiClient completion:(void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable))completion;
		[Export ("tokenizeType:withAPIClient:completion:")]
		void TokenizeType (string type, BTAPIClient apiClient, Action<BTPaymentMethodNonce, NSError> completion);

		// -(void)tokenizeType:(NSString * _Nonnull)type options:(NSDictionary<NSString *,id> * _Nullable)options withAPIClient:(BTAPIClient * _Nonnull)apiClient completion:(void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable))completion;
		[Export ("tokenizeType:options:withAPIClient:completion:")]
		void TokenizeType (string type, [NullAllowed] NSDictionary<NSString, NSObject> options, BTAPIClient apiClient, Action<BTPaymentMethodNonce, NSError> completion);

		// @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nonnull allTypes;
		[Export ("allTypes", ArgumentSemantic.Strong)]
		string[] AllTypes { get; }
	}

	// @protocol BTViewControllerPresentingDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTViewControllerPresentingDelegate
	{
		// @required -(void)paymentDriver:(id _Nonnull)driver requestsPresentationOfViewController:(UIViewController * _Nonnull)viewController;
		[Abstract]
		[Export ("paymentDriver:requestsPresentationOfViewController:")]
		void RequestsPresentationOfViewController (NSObject driver, UIViewController viewController);

		// @required -(void)paymentDriver:(id _Nonnull)driver requestsDismissalOfViewController:(UIViewController * _Nonnull)viewController;
		[Abstract]
		[Export ("paymentDriver:requestsDismissalOfViewController:")]
		void RequestsDismissalOfViewController (NSObject driver, UIViewController viewController);
	}
}
