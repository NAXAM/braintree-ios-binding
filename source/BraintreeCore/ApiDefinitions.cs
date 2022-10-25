using System;
using BraintreeCore;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace BraintreeCore
{
	[Static]
	partial interface BTAPIClientConstants
	{
		// extern NSString *const _Nonnull BTAPIClientErrorDomain;
		[Field ("BTAPIClientErrorDomain", "__Internal")]
		NSString ErrorDomain { get; }
	}

	// @interface BTAPIClient : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTAPIClient
	{
		// -(instancetype _Nullable)initWithAuthorization:(NSString * _Nonnull)authorization;
		[Export ("initWithAuthorization:")]
		IntPtr Constructor (string authorization);

		// -(instancetype _Nonnull)copyWithSource:(id)source integration:(id)integration;
		[Export ("copyWithSource:integration:")]
		BTAPIClient CopyWithSource (NSObject source, NSObject integration);

		// -(void)fetchOrReturnRemoteConfiguration:(void (^ _Nonnull)(BTConfiguration * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("fetchOrReturnRemoteConfiguration:")]
		void FetchOrReturnRemoteConfiguration (Action<BTConfiguration, NSError> completionBlock);

		// -(void)fetchPaymentMethodNonces:(void (^ _Nonnull)(NSArray<BTPaymentMethodNonce *> * _Nullable, NSError * _Nullable))completion;
		[Export ("fetchPaymentMethodNonces:")]
		void FetchPaymentMethodNonces (Action<NSArray, NSError> completion);

		// -(void)fetchPaymentMethodNonces:(BOOL)defaultFirst completion:(void (^ _Nonnull)(NSArray<BTPaymentMethodNonce *> * _Nullable, NSError * _Nullable))completion;
		[Export ("fetchPaymentMethodNonces:completion:")]
		void FetchPaymentMethodNonces (bool defaultFirst, Action<NSArray, NSError> completion);

		// -(void)GET:(NSString * _Nonnull)path parameters:(NSDictionary<NSString *,NSString *> * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHttpUrlResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("GET:parameters:completion:")]
		void GET (string path, [NullAllowed] NSDictionary<NSString, NSString> parameters, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)POST:(NSString * _Nonnull)path parameters:(NSDictionary * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHttpUrlResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("POST:parameters:completion:")]
		void POST (string path, [NullAllowed] NSDictionary parameters, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)GET:(NSString * _Nonnull)path parameters:(NSDictionary<NSString *,NSString *> * _Nullable)parameters httpType:(BTAPIClientHTTPType)httpType completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHttpUrlResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("GET:parameters:httpType:completion:")]
		void GET (string path, [NullAllowed] NSDictionary<NSString, NSString> parameters, BTAPIClientHTTPType httpType, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)POST:(NSString * _Nonnull)path parameters:(NSDictionary * _Nullable)parameters httpType:(BTAPIClientHTTPType)httpType completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHttpUrlResponse * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("POST:parameters:httpType:completion:")]
		void POST (string path, [NullAllowed] NSDictionary parameters, BTAPIClientHTTPType httpType, [NullAllowed] Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

		// -(void)sendAnalyticsEvent:(NSString * _Nonnull)eventName;
		[Export ("sendAnalyticsEvent:")]
		void SendAnalyticsEvent (string eventName);
	}

	// @protocol BTAppContextSwitchDriver
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	//partial interface IBTAppContextSwitchDriver { }

	//[Protocol, Model]
	//[BaseType(typeof(NSObject))]
	//interface BTAppContextSwitchDriver
	//{
	//	// @required +(BOOL)canHandleReturnURL:(NSUrl * _Nonnull)url __attribute__((swift_name("canHandleReturnURL(_:)")));
	//	[Static, Abstract]
	//	[Export ("canHandleReturnURL:")]
	//	bool CanHandleReturnURL (NSUrl url);

	//	// @required +(void)handleReturnURL:(NSUrl * _Nonnull)url __attribute__((swift_name("handleReturnURL(_:)")));
	//	[Static, Abstract]
	//	[Export ("handleReturnURL:")]
	//	void HandleReturnURL (NSUrl url);
	//}

	// @interface BTAppContextSwitcher : NSObject
	[BaseType (typeof(NSObject))]
	interface BTAppContextSwitcher
	{
		// @property (copy, nonatomic) NSString * _Nonnull returnURLScheme;
		[Export ("returnURLScheme")]
		string ReturnURLScheme { get; set; }

		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		BTAppContextSwitcher SharedInstance ();

		// +(void)setReturnURLScheme:(NSString * _Nonnull)returnURLScheme;
		[Static]
		[Export ("setReturnURLScheme:")]
		void SetReturnURLScheme (string returnURLScheme);

		// +(BOOL)handleOpenURL:(NSUrl * _Nonnull)url __attribute__((swift_name("handleOpenURL(_:)")));
		[Static]
		[Export ("handleOpenURL:")]
		bool HandleOpenURL (NSUrl url);

		// +(BOOL)handleOpenURLContext:(UIOpenUrlContext * _Nonnull)URLContext __attribute__((availability(ios, introduced=13.0))) __attribute__((swift_name("handleOpenURLContext(_:)")));
		//[iOS (13,0)]
		[Static]
		[Export ("handleOpenURLContext:")]
		bool HandleOpenURLContext (UIOpenUrlContext urlContext);

		//// -(void)registerAppContextSwitchDriver:(Class<BTAppContextSwitchDriver> _Nonnull)driver;
		//[Export ("registerAppContextSwitchDriver:")]
		//void RegisterAppContextSwitchDriver (IBTAppContextSwitchDriver driver);
	}

	// @interface BTBinData : NSObject
	[BaseType (typeof(NSObject))]
	interface BTBinData
	{
		// -(instancetype _Nonnull)initWithJSON:(BTJSON * _Nonnull)json;
		[Export ("initWithJSON:")]
		IntPtr Constructor (BTJSON json);

		// @property (readonly, copy, nonatomic) NSString * _Nullable prepaid;
		[NullAllowed, Export ("prepaid")]
		string Prepaid { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable healthcare;
		[NullAllowed, Export ("healthcare")]
		string Healthcare { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable debit;
		[NullAllowed, Export ("debit")]
		string Debit { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable durbinRegulated;
		[NullAllowed, Export ("durbinRegulated")]
		string DurbinRegulated { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable commercial;
		[NullAllowed, Export ("commercial")]
		string Commercial { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable payroll;
		[NullAllowed, Export ("payroll")]
		string Payroll { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable issuingBank;
		[NullAllowed, Export ("issuingBank")]
		string IssuingBank { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable countryOfIssuance;
		[NullAllowed, Export ("countryOfIssuance")]
		string CountryOfIssuance { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable productID;
		[NullAllowed, Export ("productID")]
		string ProductID { get; }
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

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sessionID;
		[Export ("sessionID")]
		string SessionID { get; }

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

		// -(void)setSessionID:(NSString * _Nonnull)sessionID;
		[Export ("setSessionID:")]
		void SetSessionID (string sessionID);
	}

	[Static]
	partial interface BTClientTokenConstants
	{
		// extern NSString *const _Nonnull BTClientTokenKeyVersion;
		[Field ("BTClientTokenKeyVersion", "__Internal")]
		NSString KeyVersion { get; }

		// extern NSString *const _Nonnull BTClientTokenErrorDomain;
		[Field ("BTClientTokenErrorDomain", "__Internal")]
		NSString ErrorDomain { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyAuthorizationFingerprint;
		[Field ("BTClientTokenKeyAuthorizationFingerprint", "__Internal")]
		NSString KeyAuthorizationFingerprint { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyConfigURL;
		[Field ("BTClientTokenKeyConfigURL", "__Internal")]
		NSString KeyConfigURL { get; }
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

		// @property (readonly, nonatomic, strong) NSUrl * _Nonnull configURL;
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

		// @property (readonly, copy, nonatomic) NSString * _Nullable environment;
		[NullAllowed, Export ("environment")]
		string Environment { get; }
	}

	[Static]
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
	partial interface BTJSONConstants
	{
		// extern NSString *const _Nonnull BTJSONErrorDomain;
		[Field ("BTJSONErrorDomain", "__Internal")]
		NSString ErrorDomain { get; }
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

		// -(BTJSON * _Nonnull)objectForKeyedSubscript:(NSString * _Nonnull)key;
		[Export ("objectForKeyedSubscript:")]
		BTJSON ObjectForKeyedSubscript (string key);

		// -(BTJSON * _Nonnull)objectAtIndexedSubscript:(NSUInteger)idx;
		[Export ("objectAtIndexedSubscript:")]
		BTJSON ObjectAtIndexedSubscript (nuint idx);

		// @property (readonly, assign, nonatomic) BOOL isError;
		[Export ("isError")]
		bool IsError { get; }

		// -(NSError * _Nullable)asError;
		[NullAllowed, Export("asError")]
		NSError AsError();

		// -(NSData * _Nullable)asJSONAndReturnError:(NSError * _Nullable * _Nullable)error;
		[Export ("asJSONAndReturnError:")]
		[return: NullAllowed]
		NSData AsJSONAndReturnError ([NullAllowed] out NSError error);

		// -(NSString * _Nullable)asPrettyJSONAndReturnError:(NSError * _Nullable * _Nullable)error;
		[Export ("asPrettyJSONAndReturnError:")]
		[return: NullAllowed]
		string AsPrettyJSONAndReturnError ([NullAllowed] out NSError error);

		// -(NSString * _Nullable)asString;
		[NullAllowed, Export("asString")]
		string AsString();

		// -(NSArray<BTJSON *> * _Nullable)asArray;
		[NullAllowed, Export("asArray")]
		BTJSON[] AsArray();

		// -(NSDecimalNumber * _Nullable)asNumber;
		[NullAllowed, Export("asNumber")]
		NSDecimalNumber AsNumber();

		// -(NSUrl * _Nullable)asURL;
		[NullAllowed, Export("asURL")]
		NSUrl AsURL();

		// -(NSArray<NSString *> * _Nullable)asStringArray;
		[NullAllowed, Export("asStringArray")]
		string[] AsStringArray();

		// -(NSDictionary * _Nullable)asDictionary;
		[NullAllowed, Export("asDictionary")]
		NSDictionary AsDictionary();

		// -(NSInteger)asIntegerOrZero;
		[Export("asIntegerOrZero")]
		nint AsIntegerOrZero();

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

		// @property (readonly, assign, nonatomic) BOOL isBool;
		[Export ("isBool")]
		bool IsBool { get; }

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

	// @interface BTPaymentMethodNonce : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPaymentMethodNonce
	{
		// -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce;
		[Export ("initWithNonce:")]
		IntPtr Constructor (string nonce);

		// -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce type:(NSString * _Nonnull)type;
		[Export ("initWithNonce:type:")]
		IntPtr Constructor (string nonce, string type);

		// -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce type:(NSString * _Nonnull)type isDefault:(BOOL)isDefault;
		[Export ("initWithNonce:type:isDefault:")]
		IntPtr Constructor (string nonce, string type, bool isDefault);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull nonce;
		[Export ("nonce")]
		string Nonce { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; }

		// @property (readonly, assign, nonatomic) BOOL isDefault;
		[Export ("isDefault")]
		bool IsDefault { get; }
	}

	// @interface BTPostalAddress : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface BTPostalAddress : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable recipientName;
		[NullAllowed, Export ("recipientName")]
		string RecipientName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable streetAddress;
		[NullAllowed, Export ("streetAddress")]
		string StreetAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable extendedAddress;
		[NullAllowed, Export ("extendedAddress")]
		string ExtendedAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable locality;
		[NullAllowed, Export ("locality")]
		string Locality { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable countryCodeAlpha2;
		[NullAllowed, Export ("countryCodeAlpha2")]
		string CountryCodeAlpha2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable region;
		[NullAllowed, Export ("region")]
		string Region { get; set; }
	}

	// @interface BTPreferredPaymentMethods : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTPreferredPaymentMethods
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer)) __attribute__((availability(macos_app_extension, unavailable))) __attribute__((availability(ios_app_extension, unavailable)));
		//[Unavailable (PlatformName.MacOSXAppExtension)]
		//[Unavailable (PlatformName.iOSAppExtension)]
		[Export ("initWithAPIClient:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)fetchPreferredPaymentMethods:(void (^ _Nonnull)(BTPreferredPaymentMethodsResult * _Nonnull))completion;
		[Export ("fetchPreferredPaymentMethods:")]
		unsafe void FetchPreferredPaymentMethods (Action<BTPreferredPaymentMethodsResult> completion);
	}

	// @interface BTPreferredPaymentMethodsResult : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPreferredPaymentMethodsResult
	{
		// @property (readonly, assign, nonatomic) BOOL isPayPalPreferred;
		[Export ("isPayPalPreferred")]
		bool IsPayPalPreferred { get; }

		// @property (readonly, assign, nonatomic) BOOL isVenmoPreferred;
		[Export ("isVenmoPreferred")]
		bool IsVenmoPreferred { get; }
	}

	// @interface BTURLUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface BTURLUtils
	{
		// +(NSString * _Nonnull)queryStringWithDictionary:(NSDictionary * _Nonnull)dict;
		[Static]
		[Export ("queryStringWithDictionary:")]
		string QueryStringWithDictionary (NSDictionary dict);

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)queryParametersForURL:(NSUrl * _Nonnull)url;
		[Static]
		[Export ("queryParametersForURL:")]
		NSDictionary<NSString, NSString> QueryParametersForURL (NSUrl url);
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
