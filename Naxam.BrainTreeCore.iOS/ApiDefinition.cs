using System;
using BraintreeCore;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace BraintreeCore
{
    // interface BTAnalyticsService : NSObject
    [BaseType(typeof(NSObject))]
    interface BTAnalyticsService {
        // - (instancetype)initWithAPIClient:(BTAPIClient *)apiClient;
        [Export("initWithAPIClient:")]
        IntPtr Constructor(BTAPIClient client);

        // @property (nonatomic, assign) NSUInteger flushThreshold;
        [Export("flustThreshold", ArgumentSemantic.Assign)]
        uint FlushThreshold { get; set; }

        // @property (nonatomic, strong) BTAPIClient *apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        BTAPIClient ApiClient { get; set; }

        // - (void)sendAnalyticsEvent:(NSString *)eventKind;
        [Export("sendAnalyticsEvent:")]
        string SendAnalyticsEvent (string eventKind);

        // - (void)flush:(nullable void (^)(NSError * _Nullable error))completionBlock;
        [Export("flush:")]
        void Flush (Action<NSError> completionBlock);

        // @property (nonatomic, strong) BTHTTP *http;
        [Export("http", ArgumentSemantic.Strong)]
        BTHTTP Http { get; set; }
    }

    // interface BTAnalyticsMetadata : NSObject
    [BaseType(typeof(NSObject))]
    interface BTAnalyticsMetadata {
        // + (NSDictionary *)metadata;
        [Static, Export("metadata")]
        NSDictionary Metadata();
    }

    // interface BTGraphQLHTTP : BTHTTP
    [BaseType(typeof(BTHTTP))]
    interface BTGraphQLHTTP {
    }

    // interface BTAPIHTTP : BTHTTP <NSURLSessionDelegate>
    [BaseType(typeof(BTHTTP))]
    interface BTAPIHTTP : INSUrlSessionDelegate {
        // - (instancetype)initWithBaseURL:(NSURL *)URL accessToken:(NSString *)accessToken;
        [Export("initWithBaseURL:accessToken")]
        IntPtr Constructor(NSUrl url, string accessToken);
    }

    // interface BTHTTP : NSObject<NSCopying>
    [BaseType(typeof(NSObject))]
    interface BTHTTP : INSCopying {
        // @property (nonatomic, nullable, strong) NSArray<NSData *> *pinnedCertificates;
        [Export("pinnedCertificates", ArgumentSemantic.Strong), NullAllowed]
        [return: NullAllowed]
        NSData[] PinnedCertificates { get; set; }

        // - (instancetype)initWithBaseURL:(NSURL *)URL NS_DESIGNATED_INITIALIZER;
        [DesignatedInitializer]
        [Export("initWithBaseURL:")]
        IntPtr Constructor(NSUrl url);

        // - (instancetype)initWithBaseURL:(NSURL *)URL
        //        authorizationFingerprint:(NSString *)authorizationFingerprint;
        [Export("initWithBaseURL:authorizationFingerprint:")]
        IntPtr Constructor(NSUrl url, string authorizationFingerprint);

        // - (instancetype)initWithBaseURL:(NSURL *)URL tokenizationKey:(NSString *)tokenizationKey;
        [Static, Export("initWithBaseURL:tokenizationKey:")]
        BTHTTP InitWithBaseURL(NSUrl url, string tokenizationKey);

        // - (instancetype)initWithClientToken:(BTClientToken *)clientToken;
        [Export("initWithClientToken:")]
        IntPtr Constructor(BTClientToken clientToken);

        // - (instancetype)initWithPayPalUAT:(BTPayPalUAT *)payPalUAT;
        [Export("initWithPayPalUAT:")]
        IntPtr Constructor(BTPayPalUAT payPalUAT);

        // - (NSString *)userAgentString;
        [Export("userAgentString")]
        string UserAgentString();

        // - (NSString *)acceptString;
        [Export("acceptString")]
        string AcceptString();

        // - (NSString *)acceptLanguageString;
        [Export("acceptLanguageString")]
        string AcceptLanguageString();

        // @property (nonatomic, strong) NSURLSession *session;
        [Export("session", ArgumentSemantic.Strong), NullAllowed]
        NSUrlSession Session { get; set; }

        // @property (nonatomic, readonly, strong) NSURL *baseURL;
        [Export("baseURL", ArgumentSemantic.Strong), NullAllowed]
        NSUrl baseURL { get; set; }

        // @property (nonatomic, strong) dispatch_queue_t dispatchQueue;
        [Export("dispatchQueue", ArgumentSemantic.Strong)]
        DispatchQueue DispatchQueue { get; set; }

        // - (void)GET:(NSString *)endpoint
        //  completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("GET:completion:")]
        void Get(string endpoint, Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

        // - (void)GET:(NSString *)endpoint
        //  parameters:(nullable NSDictionary <NSString *, NSString *> *)parameters
        //  completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("GET:parameters:completion:")]
        void Get(string endpoint, NSDictionary paramters, Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

        // - (void)POST:(NSString *)endpoint
        //   completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("POST:completion:")]
        void Post(string endpoint, Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

        // - (void)POST:(NSString *)endpoint
        //   parameters:(nullable NSDictionary *)parameters
        //   completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("POST:parameters:completion:")]
        void Post(string endpoint, NSDictionary paramters, Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

        // - (void)PUT:(NSString *)endpoint
        //  completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("PUT:completion:")]
        void Put(string endpoint, Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

        // - (void)PUT:(NSString *)endpoint
        //  parameters:(nullable NSDictionary *)parameters
        //  completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("PUT:parameters:completion:")]
        void Put(string endpoint, NSDictionary paramters, Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

        // - (void)DELETE:(NSString *)endpoint
        //     completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("DELETE:completion:")]
        void Delete(string endpoint, Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

        // - (void)DELETE:(NSString *)endpoint
        //     parameters:(nullable NSDictionary *)parameters
        //     completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("DELETE:parameters:completion:")]
        void Delete(string endpoint, NSDictionary paramters, Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

        // - (void)handleRequestCompletion:(nullable NSData *)data
        //                        response:(nullable NSURLResponse *)response
        //                           error:(nullable NSError *)error
        //                 completionBlock:(void(^)(BTJSON *body, NSHTTPURLResponse *response, NSError *error))completionBlock;
        [Export("handleRequestCompletion:response:error:completionBlock:")]
        void HandleRequestCompletion(NSData data, NSUrlResponse response, Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock);

        // - (void)callCompletionBlock:(void(^)(BTJSON *body, NSHTTPURLResponse *response, NSError *error))completionBlock
        //                        body:(nullable BTJSON *)jsonBody
        //                    response:(nullable NSHTTPURLResponse *)response
        //                       error:(nullable NSError *)error;
        [Export("callCompletionBlock:body:response:error:")]
        void CallCompletionBlock(Action<BTJSON, NSHttpUrlResponse, NSError> completionBlock, BTJSON jsonBody, NSHttpUrlResponse response, NSError error);
    }

    [BaseType(typeof(NSObject))]
    partial interface BTURLUtils {
        // + (NSString *)queryStringWithDictionary:(NSDictionary *)dict;
        [Static, Export("queryStringWithDictionary:")]
        string QueryStringWithDictionary(NSDictionary dict);
        // + (NSDictionary<NSString *, NSString *> *)queryParametersForURL:(NSURL *)url;
        [Static, Export("queryParametersForURL:")]
        NSDictionary QueryParametersForURL(NSUrl url);
    }


    [BaseType(typeof(NSObject))]
    partial interface BTPreferredPaymentMethodsResult {
        // @property (nonatomic, readonly, assign) BOOL isPayPalPreferred;
        [Export("isPayPalPreferred", ArgumentSemantic.Assign)]
        bool IsPayPalPreferred { get; }
        // @property (nonatomic, readonly, assign) BOOL isVenmoPreferred;
        [Export("isVenmoPreferred", ArgumentSemantic.Assign)]
        bool IsVenmoPreferred { get; }
    }

    [BaseType(typeof(NSObject))]
    partial interface BTPreferredPaymentMethods {
        // - (instancetype)initWithAPIClient:(BTAPIClient *)apiClient NS_DESIGNATED_INITIALIZER;
        [Export("initWithAPIClient:"), DesignatedInitializer]
        IntPtr Constructor(BTAPIClient apiClient);
        // - (instancetype)init __attribute__((unavailable("Please use initWithAPIClient:")));

        // - (void)fetchPreferredPaymentMethods:(void (^)(BTPreferredPaymentMethodsResult *))completion;
        [Export("fetchPreferredPaymentMethods:")]
        void FetchPreferredPaymentMethods(Action<BTPreferredPaymentMethodsResult> completion);
}

    [BaseType(typeof(NSObject))]
    partial interface BTPayPalUAT {
        // - (nullable instancetype)initWithUATString:(NSString *)payPalUAT error:(NSError **)error NS_DESIGNATED_INITIALIZER;
        [Export("initWithUATString:error:"), DesignatedInitializer]
        IntPtr Constructor(string payPalUAT, NSError error);

        // - (instancetype)init __attribute__((unavailable("Please use initWithPayPalUAT:error: instead.")));

        // @property (nonatomic, readonly, copy) NSString *token;
        [Export("token", ArgumentSemantic.Copy)]
        string Token { get; }

        // @property (nonatomic, readonly, strong) NSURL *configURL;
        [Export("configURL", ArgumentSemantic.Strong)]
        NSUrl ConfigURL { get; }

        // @property (nonatomic, readonly, strong) NSURL *baseBraintreeURL;
        [Export("baseBraintreeURL", ArgumentSemantic.Strong)]
        NSUrl BaseBraintreeURL { get; }

        // @property (nonatomic, readonly, strong) NSURL *basePayPalURL;
        [Export("basePayPalURL", ArgumentSemantic.Strong)]
        NSUrl BasePayPalURL { get; }

        // @property (nonatomic, readonly, assign) BTPayPalUATEnvironment environment;
        [Export("environment", ArgumentSemantic.Assign)]
        BTPayPalUATEnvironment Environment { get; }
    }

    partial interface IBTAppSwitchHandler { };
    partial interface IBTAppSwitchDelegate { };
    partial interface IBTViewControllerPresentingDelegate { };

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //	// extern double BraintreeCoreVersionNumber;
    //	[Field("BraintreeCoreVersionNumber", "__Internal")]
    //	double BraintreeCoreVersionNumber { get; }

    //	// extern const unsigned char [] BraintreeCoreVersionString;
    //	[Field("BraintreeCoreVersionString", "__Internal")]
    //	byte[] BraintreeCoreVersionString { get; }
    //}

    // @interface BTClientMetadata : NSObject <NSCopying, NSMutableCopying>
    [BaseType(typeof(NSObject))]
    interface BTClientMetadata : INSCopying, INSMutableCopying
    {
        // @property (readonly, assign, nonatomic) BTClientMetadataIntegrationType integration;
        [Export("integration", ArgumentSemantic.Assign)]
        BTClientMetadataIntegrationType Integration { get; }

        // @property (readonly, assign, nonatomic) BTClientMetadataSourceType source;
        [Export("source", ArgumentSemantic.Assign)]
        BTClientMetadataSourceType Source { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull sessionId;
        [Export("sessionId")]
        string SessionId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull integrationString;
        [Export("integrationString")]
        string IntegrationString { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull sourceString;
        [Export("sourceString")]
        string SourceString { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * _Nonnull parameters;
        [Export("parameters", ArgumentSemantic.Strong)]
        NSDictionary Parameters { get; }
    }

    // @interface BTMutableClientMetadata : BTClientMetadata
    [BaseType(typeof(BTClientMetadata))]
    interface BTMutableClientMetadata
    {
        // -(void)setIntegration:(BTClientMetadataIntegrationType)integration;
        [Export("setIntegration:")]
        void SetIntegration(BTClientMetadataIntegrationType integration);

        // -(void)setSource:(BTClientMetadataSourceType)source;
        [Export("setSource:")]
        void SetSource(BTClientMetadataSourceType source);

        // -(void)setSessionId:(NSString * _Nonnull)sessionId;
        [Export("setSessionId:")]
        void SetSessionId(string sessionId);
    }

    [Static]
    partial interface BTJSONConstants
    {
        // extern NSString *const _Nonnull BTJSONErrorDomain;
        [Field("BTJSONErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }
    }

    // @interface BTJSON : NSObject
    [BaseType(typeof(NSObject))]
    interface BTJSON
    {
        // -(instancetype _Nonnull)initWithValue:(id _Nonnull)value;
        [Export("initWithValue:")]
        IntPtr Constructor(NSObject value);

        // -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data;
        [Export("initWithData:")]
        IntPtr Constructor(NSData data);

        // -(id _Nonnull)objectForKeyedSubscript:(NSString * _Nonnull)key;
        [Export("objectForKeyedSubscript:")]
        NSObject ObjectForKeyedSubscript(string key);

        // -(BTJSON * _Nonnull)objectAtIndexedSubscript:(NSUInteger)idx;
        [Export("objectAtIndexedSubscript:")]
        BTJSON ObjectAtIndexedSubscript(nuint idx);

        // @property (readonly, assign, nonatomic) BOOL isError;
        [Export("isError")]
        bool IsError { get; }

        // -(NSError * _Nullable)asError;
        [NullAllowed, Export("asError")]
        NSError AsError();

        // -(NSData * _Nullable)asJSONAndReturnError:(NSError * _Nullable * _Nullable)error;
        [Export("asJSONAndReturnError:")]
        [return: NullAllowed]
        NSData AsJSONAndReturnError([NullAllowed] out NSError error);

        // -(NSString * _Nullable)asPrettyJSONAndReturnError:(NSError * _Nullable * _Nullable)error;
        [Export("asPrettyJSONAndReturnError:")]
        [return: NullAllowed]
        string AsPrettyJSONAndReturnError([NullAllowed] out NSError error);

        // -(NSString * _Nullable)asString;
        [NullAllowed, Export("asString")]
        string AsString();

        // -(NSArray<BTJSON *> * _Nullable)asArray;
        [NullAllowed, Export("asArray")]
        BTJSON[] AsArray();

        // -(NSDecimalNumber * _Nullable)asNumber;
        [NullAllowed, Export("asNumber")]
        NSDecimalNumber AsNumber();

        // -(NSURL * _Nullable)asURL;
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
        [Export("asEnum:orDefault:")]
        nint AsEnum(NSDictionary mapping, nint defaultValue);

        // @property (readonly, assign, nonatomic) BOOL isString;
        [Export("isString")]
        bool IsString { get; }

        // @property (readonly, assign, nonatomic) BOOL isNumber;
        [Export("isNumber")]
        bool IsNumber { get; }

        // @property (readonly, assign, nonatomic) BOOL isArray;
        [Export("isArray")]
        bool IsArray { get; }

        // @property (readonly, assign, nonatomic) BOOL isObject;
        [Export("isObject")]
        bool IsObject { get; }

        // @property (nonatomic, assign, readonly) BOOL isBool;
        [Export("isBool")]
        bool IsBool { get; }

        // @property (readonly, assign, nonatomic) BOOL isTrue;
        [Export("isTrue")]
        bool IsTrue { get; }

        // @property (readonly, assign, nonatomic) BOOL isFalse;
        [Export("isFalse")]
        bool IsFalse { get; }

        // @property (readonly, assign, nonatomic) BOOL isNull;
        [Export("isNull")]
        bool IsNull { get; }
    }

    // @interface BTConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BTConfiguration
    {
        // -(instancetype _Nonnull)initWithJSON:(BTJSON * _Nonnull)json __attribute__((objc_designated_initializer));
        [Export("initWithJSON:")]
        [DesignatedInitializer]
        IntPtr Constructor(BTJSON json);

        // @property (readonly, nonatomic, strong) BTJSON * _Nonnull json;
        [Export("json", ArgumentSemantic.Strong)]
        BTJSON Json { get; }

        // +(BOOL)isBetaEnabledPaymentOption:(NSString * _Nonnull)paymentOption __attribute__((deprecated("Pay with Venmo is no longer in beta")));
        [Static]
        [Export("isBetaEnabledPaymentOption:")]
        bool IsBetaEnabledPaymentOption(string paymentOption);

        // +(void)setBetaPaymentOption:(NSString * _Nonnull)paymentOption isEnabled:(BOOL)isEnabled __attribute__((deprecated("Pay with Venmo is no longer in beta")));
        [Static]
        [Export("setBetaPaymentOption:isEnabled:")]
        void SetBetaPaymentOption(string paymentOption, bool isEnabled);

        // @property (nonatomic, readonly, assign) BOOL collectFraudData;
        [Export("collectFraudData", ArgumentSemantic.Assign)]
        bool CollectFraudData { get; }

        // @property (nonatomic, readonly, assign) BOOL isGraphQLEnabled;
        [Export("isGraphQLEnabled", ArgumentSemantic.Assign)]
        bool IsGraphQLEnabled { get; }
    }

    [Static]
    partial interface BTAPIClientConstants
    {
        // extern NSString *const _Nonnull BTAPIClientErrorDomain;
        [Field("BTAPIClientErrorDomain", "__Internal")]
        NSString BTAPIClientErrorDomain { get; }
    }

    delegate void GetTokenizationCompletionblock(BTPaymentMethodNonce nonce, NSError error);
    delegate void RegisterTokenizationCompleteBlock(BTAPIClient client, NSDictionary data, [BlockCallback]GetTokenizationCompletionblock subblock);
    delegate void FetchOrReturnRemoteConfigurationCompletionBlock(BTConfiguration configuration, NSError error);
    delegate void FetchPaymentMethodNoncesCompletionBlock(NSArray<BTPaymentMethodNonce> items, NSError error);
    delegate void BTJsonCompletionBlock(BTJSON json, NSHttpUrlResponse response, NSError error);

    // @interface BTAPIClient : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BTAPIClient
    {
        // -(instancetype _Nullable)initWithAuthorization:(NSString * _Nonnull)authorization;
        [Export("initWithAuthorization:")]
        IntPtr Constructor(string authorization);

        // -(instancetype _Nonnull)copyWithSource:(BTClientMetadataSourceType)source integration:(BTClientMetadataIntegrationType)integration;
        [Export("copyWithSource:integration:")]
        BTAPIClient CopyWithSource(BTClientMetadataSourceType source, BTClientMetadataIntegrationType integration);

        // -(void)fetchOrReturnRemoteConfiguration:(void (^ _Nonnull)(BTConfiguration * _Nullable, NSError * _Nullable))completionBlock;
        [Export("fetchOrReturnRemoteConfiguration:")]
        void FetchOrReturnRemoteConfiguration([BlockCallback]FetchOrReturnRemoteConfigurationCompletionBlock completionBlock);

        // -(void)fetchPaymentMethodNonces:(void (^ _Nonnull)(NSArray<BTPaymentMethodNonce *> * _Nullable, NSError * _Nullable))completion;
        [Export("fetchPaymentMethodNonces:")]
        void FetchPaymentMethodNonces([BlockCallback]FetchPaymentMethodNoncesCompletionBlock completion);

        // -(void)fetchPaymentMethodNonces:(BOOL)defaultFirst completion:(void (^ _Nonnull)(NSArray<BTPaymentMethodNonce *> * _Nullable, NSError * _Nullable))completion;
        [Export("fetchPaymentMethodNonces:completion:")]
        void FetchPaymentMethodNonces(bool defaultFirst, [BlockCallback]FetchPaymentMethodNoncesCompletionBlock completion);

        // -(void)GET:(NSString * _Nonnull)path parameters:(NSDictionary<NSString *,NSString *> * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
        [Export("GET:parameters:completion:")]
        void GET(string path, [NullAllowed] NSDictionary<NSString, NSString> parameters, [NullAllowed] [BlockCallback]BTJsonCompletionBlock completionBlock);

        // -(void)POST:(NSString * _Nonnull)path parameters:(NSDictionary * _Nullable)parameters completion:(void (^ _Nullable)(BTJSON * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable))completionBlock;
        [Export("POST:parameters:completion:")]
        void POST(string path, [NullAllowed] NSDictionary parameters, [NullAllowed] [BlockCallback]BTJsonCompletionBlock completionBlock);

        // @property (nonatomic, copy, nullable) NSString *tokenizationKey;
        [Export("tokenizationKey", ArgumentSemantic.Copy), NullAllowed]
        [return: NullAllowed]
        string TokenizationKey {get;set;}

        // @property (nonatomic, strong, nullable) BTClientToken *clientToken;
        [Export("clientToken", ArgumentSemantic.Strong), NullAllowed]
        [return: NullAllowed]
        BTClientToken ClientToken {get;set;}

        // @property (nonatomic, strong, nullable) BTPayPalUAT *payPalUAT;
        [Export("payPalUAT", ArgumentSemantic.Strong), NullAllowed]
        [return: NullAllowed]
        BTPayPalUAT PayPalUAT {get;set;}

        // @property (nonatomic, strong) BTHTTP *http;
        [Export("http", ArgumentSemantic.Strong)]
        BTHTTP Http {get;set;}

        // @property (nonatomic, strong) BTHTTP *configurationHTTP;
        [Export("configurationHTTP", ArgumentSemantic.Strong)]
        BTHTTP ConfigurationHTTP {get;set;}

        // @property (nonatomic, strong) BTAPIHTTP *braintreeAPI;
        [Export("braintreeAPI", ArgumentSemantic.Strong)]
        BTAPIHTTP BraintreeAPI {get;set;}

        // @property (nonatomic, strong) BTGraphQLHTTP *graphQL;
        [Export("graphQL", ArgumentSemantic.Strong), NullAllowed]
        [return: NullAllowed]
        BTGraphQLHTTP GraphQL {get;set;}
        
        // @property (nonatomic, readonly, strong) BTClientMetadata *metadata;
        [Export("metadata", ArgumentSemantic.Strong)]
        BTClientMetadata Metadata {get;}

        // @property (nonatomic, strong) BTAnalyticsService *analyticsService;
        [Export("analyticsService", ArgumentSemantic.Strong)]
        BTAnalyticsService AnalyticsService {get;set;}

        // - (void)sendAnalyticsEvent:(NSString *)eventName;
        [Export("sendAnalyticsEvent:")]
        void SendAnalyticsEvent(string eventName);


        // - (void)queueAnalyticsEvent:(NSString *)eventName;
        [Export("queueAnalyticsEvent:")]
        void QueueAnalyticsEvent(string eventName);


        // - (nullable instancetype)initWithAuthorization:(NSString *)authorization sendAnalyticsEvent:(BOOL)sendAnalyticsEvent;
        [Export("initWithAuthorization:sendAnalyticsEvent:")]
        IntPtr Constructor(string authorization, BTTokenizationService sendAnalyticsEvent);

        // - (void)GET:(NSString *)path
        // parameters:(nullable NSDictionary <NSString *, NSString *> *)parameters
        // httpType:(BTAPIClientHTTPType)httpType
        // completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("GET:parameters:httpType:completion:")]
        void Get(string path, [NullAllowed] NSDictionary parameters, BTAPIClientHTTPType httpType, [NullAllowed] [BlockCallback]BTJsonCompletionBlock completionBlock);

        // - (void)POST:(NSString *)path
        // parameters:(nullable NSDictionary *)parameters
        // httpType:(BTAPIClientHTTPType)httpType
        // completion:(nullable void(^)(BTJSON * _Nullable body, NSHTTPURLResponse * _Nullable response, NSError * _Nullable error))completionBlock;
        [Export("POST:parameters:httpType:completion:")]
        void POST(string path, [NullAllowed] NSDictionary parameters, BTAPIClientHTTPType httpType, [NullAllowed] [BlockCallback]BTJsonCompletionBlock completionBlock);


        // + (nullable NSURL *)graphQLURLForEnvironment:(NSString *)environment;
        [Export("graphQLURLForEnvironment:")]
        [return: NullAllowed]
        NSUrl GraphQLURLForEnvironment(string environment);

        // + (BTAPIClientAuthorizationType)authorizationTypeForAuthorization:(NSString *)authorization;
        [Export("authorizationTypeForAuthorization:")]
        BTAPIClientAuthorizationType AuthorizationTypeForAuthorization(string authorization);
    }

    // @interface BTAppSwitch : NSObject
    [BaseType(typeof(NSObject))]
    interface BTAppSwitch
    {
        // @property (copy, nonatomic) NSString * _Nonnull returnURLScheme;
        [Export("returnURLScheme")]
        string ReturnURLScheme { get; set; }

        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        BTAppSwitch SharedInstance();

        // +(void)setReturnURLScheme:(NSString * _Nonnull)returnURLScheme;
        [Static]
        [Export("setReturnURLScheme:")]
        void SetReturnURLScheme(string returnURLScheme);

        // +(BOOL)handleOpenURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication;
        [Static]
        [Export("handleOpenURL:sourceApplication:")]
        bool HandleOpenURL2(NSUrl url, [NullAllowed] string sourceApplication);

        // +(BOOL)handleOpenURL:(NSURL * _Nonnull)url options:(NSDictionary * _Nonnull)options;
        [Static]
        [Export("handleOpenURL:options:")]
        bool HandleOpenURL(NSUrl url, NSDictionary options);

        // + (BOOL)API_AVAILABLE(ios(13.0))handleOpenURLContext:(UIOpenURLContext *)URLContext NS_SWIFT_NAME(handleOpenURLContext(_:));
        [Static]
        [Introduced(PlatformName.iOS, 13, 0)]
        [Export("handleOpenURLContext:")]
        bool HandleOpenURLContext(UIOpenUrlContext context);


        // -(void)registerAppSwitchHandler:(Class<BTAppSwitchHandler> _Nonnull)handler;
        [Export("registerAppSwitchHandler:")]
        void RegisterAppSwitchHandler(IBTAppSwitchHandler handler);

        // -(void)unregisterAppSwitchHandler:(Class<BTAppSwitchHandler> _Nonnull)handler;
        [Export("unregisterAppSwitchHandler:")]
        void UnregisterAppSwitchHandler(IBTAppSwitchHandler handler);

        // - (BOOL)handleOpenURL:(NSURL *)url sourceApplication:(NSString *)sourceApplication DEPRECATED_MSG_ATTRIBUTE("Use handleOpenURL:options: or handleOpenURLContext: instead.");
        [Export("handleOpenURL:sourceApplication:")]
		[Deprecated(PlatformName.iOS, PlatformArchitecture.All, "Use handleOpenURL:options: or handleOpenURLContext: instead.")]
        bool HandleOpenURL(NSUrl url, string sourceApplication);
    }

    [Static]
    partial interface BTAppSwitchConstants
    {
        // extern NSString *const _Nonnull BTAppSwitchWillSwitchNotification;
        [Field("BTAppSwitchWillSwitchNotification", "__Internal")]
        NSString WillSwitchNotification { get; }

        // extern NSString *const _Nonnull BTAppSwitchDidSwitchNotification;
        [Field("BTAppSwitchDidSwitchNotification", "__Internal")]
        NSString DidSwitchNotification { get; }

        // extern NSString *const _Nonnull BTAppSwitchWillProcessPaymentInfoNotification;
        [Field("BTAppSwitchWillProcessPaymentInfoNotification", "__Internal")]
        NSString WillProcessPaymentInfoNotification { get; }

        // extern NSString *const _Nonnull BTAppSwitchNotificationTargetKey;
        [Field("BTAppSwitchNotificationTargetKey", "__Internal")]
        NSString NotificationTargetKey { get; }
    }

    [Static]
    partial interface BTAppContextConstants
    {
        // extern NSString * const BTAppContextWillSwitchNotification;
        [Field("BTAppContextWillSwitchNotification", "__Internal")]
        NSString WillSwitchNotification { get; }

        // extern NSString * const BTAppContextDidReturnNotification;
        [Field("BTAppContextDidReturnNotification", "__Internal")]
        NSString DidReturnNotification { get; }
    }

    // @protocol BTAppSwitchDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTAppSwitchDelegate
    {
        // @required -(void)appSwitcherWillPerformAppSwitch:(id _Nonnull)appSwitcher;
        [Abstract]
        [Export("appSwitcherWillPerformAppSwitch:")]
        void AppSwitcherWillPerformAppSwitch(NSObject appSwitcher);

        // @required -(void)appSwitcher:(id _Nonnull)appSwitcher didPerformSwitchToTarget:(BTAppSwitchTarget)target;
        [Abstract]
        [Export("appSwitcher:didPerformSwitchToTarget:")]
        void AppSwitcher(NSObject appSwitcher, BTAppSwitchTarget target);

        // @required -(void)appSwitcherWillProcessPaymentInfo:(id _Nonnull)appSwitcher;
        [Abstract]
        [Export("appSwitcherWillProcessPaymentInfo:")]
        void AppSwitcherWillProcessPaymentInfo(NSObject appSwitcher);

        // - (void)appContextWillSwitch:(id)appSwitcher;
        [Export("appContextWillSwitch:")]
        void AppContextWillSwitch(NSObject appSwitcher);

        // - (void)appContextDidReturn:(id)appSwitcher;
        [Export("appContextDidReturn:")]
        void AppContextDidReturn(NSObject appSwitcher);
    }

    // @protocol BTAppSwitchHandler
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTAppSwitchHandler
    {
        // @required +(BOOL)canHandleAppSwitchReturnURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nonnull)sourceApplication;
        //TODO Static method inside Protocol
        [Abstract]
        [Export("canHandleAppSwitchReturnURL:sourceApplication:")]
        bool CanHandleAppSwitchReturnURL(NSUrl url, string sourceApplication);

        // @required +(void)handleAppSwitchReturnURL:(NSURL * _Nonnull)url;
        //TODO Static method inside Protocol
        [Abstract]
        [Export("handleAppSwitchReturnURL:")]
        void HandleAppSwitchReturnURL(NSUrl url);

        // @optional -(BOOL)isiOSAppAvailableForAppSwitch;
        [Export("isiOSAppAvailableForAppSwitch")]
        bool IsiOSAppAvailableForAppSwitch { get; }
    }

    [Static]
    partial interface BTClientTokenConstants
    {
        // extern NSString *const _Nonnull BTClientTokenKeyVersion;
        [Field("BTClientTokenKeyVersion", "__Internal")]
        NSString KeyVersion { get; }

        // extern NSString *const _Nonnull BTClientTokenErrorDomain;
        [Field("BTClientTokenErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }

        // extern NSString *const _Nonnull BTClientTokenKeyAuthorizationFingerprint;
        [Field("BTClientTokenKeyAuthorizationFingerprint", "__Internal")]
        NSString KeyAuthorizationFingerprint { get; }

        // extern NSString *const _Nonnull BTClientTokenKeyConfigURL;
        [Field("BTClientTokenKeyConfigURL", "__Internal")]
        NSString KeyConfigURL { get; }
    }

    // @interface BTClientToken : NSObject <NSCoding, NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BTClientToken : INSCoding, INSCopying
    {
        // @property (readonly, nonatomic, strong) BTJSON * _Nonnull json;
        [Export("json", ArgumentSemantic.Strong)]
        BTJSON Json { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull authorizationFingerprint;
        [Export("authorizationFingerprint")]
        string AuthorizationFingerprint { get; }

        // @property (readonly, nonatomic, strong) NSURL * _Nonnull configURL;
        [Export("configURL", ArgumentSemantic.Strong)]
        NSUrl ConfigURL { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull originalValue;
        [Export("originalValue")]
        string OriginalValue { get; }

        // -(instancetype _Nullable)initWithClientToken:(NSString * _Nonnull)clientToken error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
        [Export("initWithClientToken:error:")]
        [DesignatedInitializer]
        IntPtr Constructor(string clientToken, [NullAllowed] out NSError error);
    }

    [Static]
    partial interface BTErrorConstants
    {
        // extern NSString *const _Nonnull BTCustomerInputBraintreeValidationErrorsKey;
        [Field("BTCustomerInputBraintreeValidationErrorsKey", "__Internal")]
        NSString BTCustomerInputBraintreeValidationErrorsKey { get; }

        // extern NSString *const BTHTTPErrorDomain;
        [Field("BTHTTPErrorDomain", "__Internal")]
        NSString BTHTTPErrorDomain { get; }

        // extern NSString *const BTHTTPURLResponseKey;
        [Field("BTHTTPURLResponseKey", "__Internal")]
        NSString BTHTTPURLResponseKey { get; }

        // extern NSString *const BTHTTPJSONResponseBodyKey;
        [Field("BTHTTPJSONResponseBodyKey", "__Internal")]
        NSString BTHTTPJSONResponseBodyKey { get; }
    }

    // @interface BTLogger : NSObject
    [BaseType(typeof(NSObject))]
    interface BTLogger
    {
        // +(instancetype)sharedLogger;
        [Static]
        [Export("sharedLogger")]
        BTLogger SharedLogger();

        // @property (assign, nonatomic) BTLogLevel level;
        [Export("level", ArgumentSemantic.Assign)]
        BTLogLevel Level { get; set; }
    }

    // @interface BTPostalAddress : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface BTPostalAddress : INSCopying
    {
        // @property (copy, nonatomic) NSString * _Nullable recipientName;
        [NullAllowed, Export("recipientName")]
        string RecipientName { get; set; }

        // @property (nonatomic, nullable, copy) NSString *streetAddress;
        [Export("streetAddress", ArgumentSemantic.Copy), NullAllowed]
        [return: NullAllowed]
        string StreetAddress { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable extendedAddress;
        [NullAllowed, Export("extendedAddress")]
        string ExtendedAddress { get; set; }

        // @property (nonatomic, nullable, copy) NSString *locality;
        [Export("locality", ArgumentSemantic.Copy), NullAllowed]
        [return: NullAllowed]
        string Locality { get; set; }

        // @property (nonatomic, nullable, copy) NSString *countryCodeAlpha2;
        [Export("countryCodeAlpha2", ArgumentSemantic.Copy), NullAllowed]
        [return: NullAllowed]
        string CountryCodeAlpha2 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable region;
        [NullAllowed, Export("region")]
        string Region { get; set; }
    }

    // @interface BTPaymentMethodNonce : NSObject
    [BaseType(typeof(NSObject))]
    interface BTPaymentMethodNonce : INativeObject
    {
        // -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce localizedDescription:(NSString * _Nullable)description type:(NSString * _Nonnull)type;
        [Export("initWithNonce:localizedDescription:type:")]
        IntPtr Constructor(string nonce, [NullAllowed] string description, string type);

        // -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce localizedDescription:(NSString * _Nullable)description;
        [Export("initWithNonce:localizedDescription:")]
        IntPtr Constructor(string nonce, [NullAllowed] string description);

        // -(instancetype _Nullable)initWithNonce:(NSString * _Nonnull)nonce localizedDescription:(NSString * _Nonnull)description type:(NSString * _Nonnull)type isDefault:(BOOL)isDefault;
        [Export("initWithNonce:localizedDescription:type:isDefault:")]
        IntPtr Constructor(string nonce, string description, string type, bool isDefault);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull nonce;
        [Export("nonce")]
        string Nonce { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull localizedDescription;
        [Export("localizedDescription")]
        string LocalizedDescription { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; }

        // @property (readonly, assign, nonatomic) BOOL isDefault;
        [Export("isDefault")]
        bool IsDefault { get; }
    }

    // @interface BTPaymentMethodNonceParser : NSObject
    [BaseType(typeof(NSObject))]
    interface BTPaymentMethodNonceParser
    {
        // +(instancetype _Nonnull)sharedParser;
        [Static]
        [Export("sharedParser")]
        BTPaymentMethodNonceParser SharedParser();

        // @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nonnull allTypes;
        [Export("allTypes", ArgumentSemantic.Strong)]
        string[] AllTypes { get; }

        // -(BOOL)isTypeAvailable:(NSString * _Nonnull)type;
        [Export("isTypeAvailable:")]
        bool IsTypeAvailable(string type);

        // -(void)registerType:(NSString * _Nonnull)type withParsingBlock:(BTPaymentMethodNonce * _Nullable (^ _Nonnull)(BTJSON * _Nonnull))jsonParsingBlock;
        [Export("registerType:withParsingBlock:")]
        void RegisterType(string type, Func<BTJSON, BTPaymentMethodNonce> jsonParsingBlock);

        // -(BTPaymentMethodNonce * _Nullable)parseJSON:(BTJSON * _Nonnull)json withParsingBlockForType:(NSString * _Nonnull)type;
        [Export("parseJSON:withParsingBlockForType:")]
        [return: NullAllowed]
        BTPaymentMethodNonce ParseJSON(BTJSON json, string type);
    }

    [Static]
    partial interface BTTokenizationServiceConstants
    {
        // extern NSString *const _Nonnull BTTokenizationServiceErrorDomain;
        [Field("BTTokenizationServiceErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }

        // extern NSString *const _Nonnull BTTokenizationServiceAppSwitchDelegateOption;
        [Field("BTTokenizationServiceAppSwitchDelegateOption", "__Internal")]
        NSString AppSwitchDelegateOption { get; }

        // extern NSString *const _Nonnull BTTokenizationServiceViewPresentingDelegateOption;
        [Field("BTTokenizationServiceViewPresentingDelegateOption", "__Internal")]
        NSString ViewPresentingDelegateOption { get; }

        // extern NSString *const _Nonnull BTTokenizationServicePayPalScopesOption;
        [Field("BTTokenizationServicePayPalScopesOption", "__Internal")]
        NSString PayPalScopesOption { get; }

        // extern NSString *const _Nonnull BTTokenizationServiceAmountOption;
        [Field("BTTokenizationServiceAmountOption", "__Internal")]
        NSString AmountOption { get; }

        // extern NSString *const _Nonnull BTTokenizationServiceNonceOption;
        [Field("BTTokenizationServiceNonceOption", "__Internal")]
        NSString NonceOption { get; }
    }

    // @interface BTTokenizationService : NSObject
    [BaseType(typeof(NSObject))]
    interface BTTokenizationService
    {
        // +(instancetype _Nonnull)sharedService;
        [Static]
        [Export("sharedService")]
        BTTokenizationService SharedService();

        // -(void)registerType:(NSString * _Nonnull)type withTokenizationBlock:(void (^ _Nonnull)(BTAPIClient * _Nonnull, NSDictionary * _Nullable, void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable)))tokenizationBlock;
        [Export("registerType:withTokenizationBlock:")]
        void RegisterType(string type, [BlockCallback]RegisterTokenizationCompleteBlock tokenizationBlock);

        // -(BOOL)isTypeAvailable:(NSString * _Nonnull)type;
        [Export("isTypeAvailable:")]
        bool IsTypeAvailable(string type);

        // -(void)tokenizeType:(NSString * _Nonnull)type withAPIClient:(BTAPIClient * _Nonnull)apiClient completion:(void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable))completion;
        [Export("tokenizeType:withAPIClient:completion:")]
        void TokenizeType(string type, BTAPIClient apiClient, [BlockCallback]GetTokenizationCompletionblock completion);

        // -(void)tokenizeType:(NSString * _Nonnull)type options:(NSDictionary<NSString *,id> * _Nullable)options withAPIClient:(BTAPIClient * _Nonnull)apiClient completion:(void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable))completion;
        [Export("tokenizeType:options:withAPIClient:completion:")]
        void TokenizeType(string type, [NullAllowed] NSDictionary<NSString, NSObject> options, BTAPIClient apiClient, [BlockCallback]GetTokenizationCompletionblock completion);

        // @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nonnull allTypes;
        [Export("allTypes", ArgumentSemantic.Strong)]
        string[] AllTypes { get; }
    }

    // @protocol BTViewControllerPresentingDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTViewControllerPresentingDelegate
    {
        // @required -(void)paymentDriver:(id _Nonnull)driver requestsPresentationOfViewController:(UIViewController * _Nonnull)viewController;
        [Abstract]
        [Export("paymentDriver:requestsPresentationOfViewController:")]
        void RequestsPresentationOfViewController(NSObject driver, UIViewController viewController);

        // @required -(void)paymentDriver:(id _Nonnull)driver requestsDismissalOfViewController:(UIViewController * _Nonnull)viewController;
        [Abstract]
        [Export("paymentDriver:requestsDismissalOfViewController:")]
        void RequestsDismissalOfViewController(NSObject driver, UIViewController viewController);
    }


    // @interface BTBinData : NSObject
    [BaseType(typeof(NSObject))]
    interface BTBinData
    {
        /*!
         @brief Create a `BTBinData` object from JSON.
         */
        // - (instancetype)initWithJSON:(BTJSON *)json;
        [Export("initWithJSON:")]
        IntPtr Constructor(BTJSON json);

        /*!
         @brief Whether the card is a prepaid card. Possible values: Yes/No/Unknown
         */
        // @property (nonatomic, nullable, readonly, copy) NSString *prepaid;
        [NullAllowed, Export("prepaid", ArgumentSemantic.Copy)]
        string Prepaid { get; }

        /*!
         @brief Whether the card is a healthcare card. Possible values: Yes/No/Unknown
         */
        // @property (nonatomic, nullable, readonly, copy) NSString *healthcare;
        [NullAllowed, Export("healthcare", ArgumentSemantic.Copy)]
        string Healthcare { get; }

        /*!
         @brief Whether the card is a debit card. Possible values: Yes/No/Unknown
         */
        // @property (nonatomic, nullable, readonly, copy) NSString *debit;
        [NullAllowed, Export("debit", ArgumentSemantic.Copy)]
        string debit { get; }

        /*!
         @brief A value indicating whether the issuing bank's card range is regulated by the Durbin Amendment due to the bank's assets. Possible values: Yes/No/Unknown
         */
        // @property (nonatomic, nullable, readonly, copy) NSString *durbinRegulated;
        [NullAllowed, Export("durbinRegulated", ArgumentSemantic.Copy)]
        string DurbinRegulated { get; }

        /*!
         @brief Whether the card type is a commercial card and is capable of processing Level 2 transactions. Possible values: Yes/No/Unknown
         */
        // @property (nonatomic, nullable, readonly, copy) NSString *commercial;
        [NullAllowed, Export("commercial", ArgumentSemantic.Copy)]
        string Commercial { get; }

        /*!
         @brief Whether the card is a payroll card. Possible values: Yes/No/Unknown
         */
        // @property (nonatomic, nullable, readonly, copy) NSString *payroll;
        [NullAllowed, Export("payroll", ArgumentSemantic.Copy)]
        string Payroll { get; }

        /*!
         @brief The bank that issued the credit card, if available.
         */
        // @property (nonatomic, nullable, readonly, copy) NSString *issuingBank;
        [NullAllowed, Export("issuingBank", ArgumentSemantic.Copy)]
        string IssuingBank { get; }

        /*!
         @brief The country that issued the credit card, if available.
         */
        //@property(nonatomic, nullable, readonly, copy) NSString* countryOfIssuance;
        [NullAllowed, Export("countryOfIssuance", ArgumentSemantic.Copy)]
        string CountryOfIssuance { get; }

        /*!
         @brief The code for the product type of the card (e.g. `D` (Visa Signature Preferred), `G` (Visa Business)), if available.
         */
        //@property (nonatomic, nullable, readonly, copy) NSString *productId;
        [NullAllowed, Export("productId", ArgumentSemantic.Copy)]
        string productId { get; }
    }
}
