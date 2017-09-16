using Foundation;
using ObjCRuntime;
using PayPalOneTouch;

namespace PayPalOneTouch
{
    // [Static]
    // [Verify (ConstantsInterfaceAssociation)]
    // partial interface Constants
    // {
    // 	// extern double PayPalOneTouchVersionNumber;
    // 	[Field ("PayPalOneTouchVersionNumber", "__Internal")]
    // 	double PayPalOneTouchVersionNumber { get; }

    // 	// extern const unsigned char [] PayPalOneTouchVersionString;
    // 	[Field ("PayPalOneTouchVersionString", "__Internal")]
    // 	byte[] PayPalOneTouchVersionString { get; }
    // }

    // @interface PPOTResult : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTResult
    {
        // @property (readonly, assign, nonatomic) PPOTResultType type;
        [Export("type", ArgumentSemantic.Assign)]
        PPOTResultType Type { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable response;
        [NullAllowed, Export("response", ArgumentSemantic.Copy)]
        NSDictionary Response { get; }

        // @property (readonly, copy, nonatomic) NSError * _Nullable error;
        [NullAllowed, Export("error", ArgumentSemantic.Copy)]
        NSError Error { get; }

        // @property (readonly, assign, nonatomic) PPOTRequestTarget target;
        [Export("target", ArgumentSemantic.Assign)]
        PPOTRequestTarget Target { get; }
    }

    // typedef void (^PPOTCompletionBlock)(PPOTResult * _Nonnull);
    delegate void PPOTCompletionBlock(PPOTResult arg0);

    // @interface PPOTCore : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTCore
    {
        // +(BOOL)doesApplicationSupportOneTouchCallbackURLScheme:(NSString * _Nonnull)callbackURLScheme;
        [Static]
        [Export("doesApplicationSupportOneTouchCallbackURLScheme:")]
        bool DoesApplicationSupportOneTouchCallbackURLScheme(string callbackURLScheme);

        // +(BOOL)isWalletAppInstalled;
        [Static]
        [Export("isWalletAppInstalled")]
        bool IsWalletAppInstalled { get; }

        // +(BOOL)canParseURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication;
        [Static]
        [Export("canParseURL:sourceApplication:")]
        bool CanParseURL(NSUrl url, [NullAllowed] string sourceApplication);

        // +(void)parseResponseURL:(NSURL * _Nonnull)url completionBlock:(PPOTCompletionBlock _Nonnull)completionBlock;
        [Static]
        [Export("parseResponseURL:completionBlock:")]
        void ParseResponseURL(NSUrl url, PPOTCompletionBlock completionBlock);

        // +(void)redirectURLsForCallbackURLScheme:(NSString * _Nonnull)callbackURLScheme withReturnURL:(NSString * _Nonnull * _Nonnull)returnURL withCancelURL:(NSString * _Nonnull * _Nonnull)cancelURL;
        [Static]
        [Export("redirectURLsForCallbackURLScheme:withReturnURL:withCancelURL:")]
        void RedirectURLsForCallbackURLScheme(string callbackURLScheme, out string returnURL, out string cancelURL);

        // +(NSString * _Nonnull)libraryVersion;
        [Static]
        [Export("libraryVersion")]
        string LibraryVersion { get; }
    }

    // typedef void (^PPOTRequestPreflightCompletionBlock)(PPOTRequestTarget);
    delegate void PPOTRequestPreflightCompletionBlock(PPOTRequestTarget arg0);

    // typedef void (^PPOTRequestAdapterBlock)(BOOL, NSURL * _Nonnull, PPOTRequestTarget, NSString * _Nullable, NSError * _Nullable);
    delegate void PPOTRequestAdapterBlock(bool arg0, NSUrl arg1, PPOTRequestTarget arg2, [NullAllowed] string arg3, [NullAllowed] NSError arg4);

    [Static]
    partial interface PayPalEnvironmentConstants
    {
        // extern NSString *const _Nonnull PayPalEnvironmentProduction;
        [Field("PayPalEnvironmentProduction", "__Internal")]
        NSString Production { get; }

        // extern NSString *const _Nonnull PayPalEnvironmentSandbox;
        [Field("PayPalEnvironmentSandbox", "__Internal")]
        NSString Sandbox { get; }

        // extern NSString *const _Nonnull PayPalEnvironmentMock;
        [Field("PayPalEnvironmentMock", "__Internal")]
        NSString Mock { get; }
    }

    // @interface PPOTRequest : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTRequest
    {
        // -(void)getTargetApp:(PPOTRequestPreflightCompletionBlock _Nullable)completionBlock;
        [Export("getTargetApp:")]
        void GetTargetApp([NullAllowed] PPOTRequestPreflightCompletionBlock completionBlock);

        // -(void)performWithAdapterBlock:(PPOTRequestAdapterBlock _Nullable)adapterBlock;
        [Export("performWithAdapterBlock:")]
        void PerformWithAdapterBlock([NullAllowed] PPOTRequestAdapterBlock adapterBlock);

        // +(NSString * _Nullable)tokenFromApprovalURL:(NSURL * _Nonnull)approvalURL;
        [Static]
        [Export("tokenFromApprovalURL:")]
        [return: NullAllowed]
        string TokenFromApprovalURL(NSUrl approvalURL);

        // @property (readonly, nonatomic) NSString * _Nonnull clientID;
        [Export("clientID")]
        string ClientID { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull environment;
        [Export("environment")]
        string Environment { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull callbackURLScheme;
        [Export("callbackURLScheme")]
        string CallbackURLScheme { get; }

        // @property (nonatomic, strong) NSDictionary * _Nonnull additionalPayloadAttributes;
        [Export("additionalPayloadAttributes", ArgumentSemantic.Strong)]
        NSDictionary AdditionalPayloadAttributes { get; set; }
    }

    // @interface PPOTAuthorizationRequest : PPOTRequest
    [BaseType(typeof(PPOTRequest))]
    interface PPOTAuthorizationRequest
    {
        // @property (readonly, nonatomic) NSSet * _Nonnull scopeValues;
        [Export("scopeValues")]
        NSSet ScopeValues { get; }

        // @property (readonly, nonatomic) NSURL * _Nonnull privacyURL;
        [Export("privacyURL")]
        NSUrl PrivacyURL { get; }

        // @property (readonly, nonatomic) NSURL * _Nonnull agreementURL;
        [Export("agreementURL")]
        NSUrl AgreementURL { get; }
    }

    // @interface PPOTCheckoutRequest : PPOTRequest
    [BaseType(typeof(PPOTRequest))]
    interface PPOTCheckoutRequest
    {
        // @property (nonatomic, strong) NSString * _Nonnull pairingId;
        [Export("pairingId", ArgumentSemantic.Strong)]
        string PairingId { get; set; }

        // @property (readonly, nonatomic) NSURL * _Nonnull approvalURL;
        [Export("approvalURL")]
        NSUrl ApprovalURL { get; }
    }

    // @interface PPOTBillingAgreementRequest : PPOTCheckoutRequest
    [BaseType(typeof(PPOTCheckoutRequest))]
    interface PPOTBillingAgreementRequest
    {
    }

    // @interface PPOTRequestFactory : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTRequestFactory
    {
        // +(PPOTCheckoutRequest * _Nullable)checkoutRequestWithApprovalURL:(NSURL * _Nonnull)approvalURL clientID:(NSString * _Nonnull)clientID environment:(NSString * _Nonnull)environment callbackURLScheme:(NSString * _Nonnull)callbackURLScheme;
        [Static]
        [Export("checkoutRequestWithApprovalURL:clientID:environment:callbackURLScheme:")]
        [return: NullAllowed]
        PPOTCheckoutRequest CheckoutRequestWithApprovalURL(NSUrl approvalURL, string clientID, string environment, string callbackURLScheme);

        // +(PPOTCheckoutRequest * _Nullable)checkoutRequestWithApprovalURL:(NSURL * _Nonnull)approvalURL pairingId:(NSString * _Nullable)pairingId clientID:(NSString * _Nonnull)clientID environment:(NSString * _Nonnull)environment callbackURLScheme:(NSString * _Nonnull)callbackURLScheme;
        [Static]
        [Export("checkoutRequestWithApprovalURL:pairingId:clientID:environment:callbackURLScheme:")]
        [return: NullAllowed]
        PPOTCheckoutRequest CheckoutRequestWithApprovalURL(NSUrl approvalURL, [NullAllowed] string pairingId, string clientID, string environment, string callbackURLScheme);

        // +(PPOTAuthorizationRequest * _Nullable)authorizationRequestWithScopeValues:(NSSet * _Nonnull)scopeValues privacyURL:(NSURL * _Nonnull)privacyURL agreementURL:(NSURL * _Nonnull)agreementURL clientID:(NSString * _Nonnull)clientID environment:(NSString * _Nonnull)environment callbackURLScheme:(NSString * _Nonnull)callbackURLScheme;
        [Static]
        [Export("authorizationRequestWithScopeValues:privacyURL:agreementURL:clientID:environment:callbackURLScheme:")]
        [return: NullAllowed]
        PPOTAuthorizationRequest AuthorizationRequestWithScopeValues(NSSet scopeValues, NSUrl privacyURL, NSUrl agreementURL, string clientID, string environment, string callbackURLScheme);

        // +(PPOTBillingAgreementRequest * _Nullable)billingAgreementRequestWithApprovalURL:(NSURL * _Nonnull)approvalURL clientID:(NSString * _Nonnull)clientID environment:(NSString * _Nonnull)environment callbackURLScheme:(NSString * _Nonnull)callbackURLScheme;
        [Static]
        [Export("billingAgreementRequestWithApprovalURL:clientID:environment:callbackURLScheme:")]
        [return: NullAllowed]
        PPOTBillingAgreementRequest BillingAgreementRequestWithApprovalURL(NSUrl approvalURL, string clientID, string environment, string callbackURLScheme);

        // +(PPOTBillingAgreementRequest * _Nullable)billingAgreementRequestWithApprovalURL:(NSURL * _Nonnull)approvalURL pairingId:(NSString * _Nullable)pairingId clientID:(NSString * _Nonnull)clientID environment:(NSString * _Nonnull)environment callbackURLScheme:(NSString * _Nonnull)callbackURLScheme;
        [Static]
        [Export("billingAgreementRequestWithApprovalURL:pairingId:clientID:environment:callbackURLScheme:")]
        [return: NullAllowed]
        PPOTBillingAgreementRequest BillingAgreementRequestWithApprovalURL(NSUrl approvalURL, [NullAllowed] string pairingId, string clientID, string environment, string callbackURLScheme);
    }
}
