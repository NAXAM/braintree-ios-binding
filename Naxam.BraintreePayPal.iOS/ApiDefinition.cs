using System;
using BraintreeCore;
using Foundation;
using ObjCRuntime;
using PayPalOneTouch;
using SafariServices;

namespace BraintreePayPal
{
    // interface BTPayPalRequestFactory : NSObject
    [BaseType(typeof(NSObject))]
    interface BTPayPalRequestFactory {
        // - (PPOTCheckoutRequest *)checkoutRequestWithApprovalURL:(NSURL *)approvalURL
        //                                                clientID:(NSString *)clientID
        //                                             environment:(NSString *)environment
        //                                       callbackURLScheme:(NSString *)callbackURLScheme;
        [Export("checkoutRequestWithApprovalURL:clientID:environment:callbackURLScheme:")]
        PPOTCheckoutRequest CheckoutRequestWithApprovalURL(NSUrl approvalURL, string clientId, string environment, string callbackURLScheme);

        // - (PPOTBillingAgreementRequest *)billingAgreementRequestWithApprovalURL:(NSURL *)approvalURL
        //                                                                clientID:(NSString *)clientID
        //                                                             environment:(NSString *)environment
        //                                                       callbackURLScheme:(NSString *)callbackURLScheme;
        [Export("billingAgreementRequestWithApprovalURL:clientID:environment:callbackURLScheme:")]
        PPOTBillingAgreementRequest BillingAgreementRequestWithApprovalURL(NSUrl approvalURL, string clientId, string environment, string callbackURLScheme);

        // - (PPOTAuthorizationRequest *)requestWithScopeValues:(NSSet *)scopeValues
        //                                           privacyURL:(NSURL *)privacyURL
        //                                         agreementURL:(NSURL *)agreementURL
        //                                             clientID:(NSString *)clientID
        //                                          environment:(NSString *)environment
        //                                    callbackURLScheme:(NSString *)callbackURLScheme;
        [Export("requestWithScopeValues:privacyURL:agreementURL:clientID:environment:callbackURLScheme:")]
        PPOTAuthorizationRequest RequestWithScopeValues(NSUrl approvalURL, string privacyURL, string agreementURL, string clientId, string environment, string callbackURLScheme);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BTPayPalLineItem {
        // @property (nonatomic, readonly, copy) NSString *quantity;
        [Export("quantity", ArgumentSemantic.Copy)]
        string Quantity { get; }

        // @property (nonatomic, readonly, copy) NSString *unitAmount;
        [Export("unitAmount", ArgumentSemantic.Copy)]
        string UnitAmount { get; }

        // @property (nonatomic, readonly, copy) NSString *name;
        [Export("name", ArgumentSemantic.Copy)]
        string Name { get; }

        // @property (nonatomic, readonly, assign) BTPayPalLineItemKind kind;
        [Export("kind", ArgumentSemantic.Assign)]
        BTPayPalLineItemKind Kind { get; }

        // @property (nonatomic, nullable, copy) NSString *unitTaxAmount;
        [Export("unitTaxAmount", ArgumentSemantic.Copy), NullAllowed]
        [return: NullAllowed]
        string UnitTaxAmount { get; }

        // @property (nonatomic, nullable, copy) NSString *itemDescription;
        [Export("itemDescription", ArgumentSemantic.Copy), NullAllowed]
        [return: NullAllowed]
        string ItemDescription { get; }

        // @property (nonatomic, nullable, copy) NSString *productCode;
        [Export("productCode", ArgumentSemantic.Copy), NullAllowed]
        [return: NullAllowed]
        string ProductCode { get; }

        // @property (nonatomic, nullable, strong) NSURL *url;
        [Export("url", ArgumentSemantic.Strong), NullAllowed]
        [return: NullAllowed]
        NSUrl Url { get; set; }

        // - (instancetype)initWithQuantity:(NSString *)quantity
        //                     unitAmount:(NSString *)unitAmount
        //                             name:(NSString *)name
        //                             kind:(BTPayPalLineItemKind)kind;
        [Export("initWithQuantity:unitAmount:name:kind:", ArgumentSemantic.Copy)]
        IntPtr Constructor (string quantity, string unitAmount, string name, BTPayPalLineItemKind kind);

        // - (instancetype)init __attribute__((unavailable("Please use initWithQuantity:unitAmount:name:kind:")));

        // - (NSDictionary *)requestParameters;
        [Export("requestParameters", ArgumentSemantic.Copy)]
        NSDictionary RequestParameters();
    }

    // [Static]
    // [Verify (ConstantsInterfaceAssociation)]
    // partial interface Constants
    // {
    // 	// extern double BraintreePayPalVersionNumber;
    // 	[Field ("BraintreePayPalVersionNumber", "__Internal")]
    // 	double BraintreePayPalVersionNumber { get; }

    // 	// extern const unsigned char [] BraintreePayPalVersionString;
    // 	[Field ("BraintreePayPalVersionString", "__Internal")]
    // 	byte[] BraintreePayPalVersionString { get; }
    // }

    // @interface PayPal (BTConfiguration)
    [Category]
    [BaseType(typeof(BTConfiguration))]
    interface BTConfiguration_PayPal
    {
        // @property (readonly, assign, nonatomic) BOOL isPayPalEnabled;
        [Static, Export("isPayPalEnabled")]
        bool IsPayPalEnabled { get; }

        // @property (readonly, assign, nonatomic) BOOL isBillingAgreementsEnabled;
        [Static, Export("isBillingAgreementsEnabled")]
        bool IsBillingAgreementsEnabled { get; }
    }

    // @interface BTPayPalRequest : NSObject
    [BaseType(typeof(NSObject))]
    interface BTPayPalRequest
    {
        // -(instancetype _Nonnull)initWithAmount:(NSString * _Nonnull)amount;
        [Export("initWithAmount:")]
        IntPtr Constructor(string amount);

        // @property (readonly, nonatomic, strong) NSString * _Nonnull amount;
        [Export("amount", ArgumentSemantic.Strong)]
        string Amount { get; }

        // @property (getter = isShippingAddressRequired, nonatomic) BOOL shippingAddressRequired;
        [Export("shippingAddressRequired")]
        bool ShippingAddressRequired { [Bind("isShippingAddressRequired")] get; set; }

        // @property (nonatomic, getter=isShippingAddressEditable) BOOL shippingAddressEditable;
        [Export("shippingAddressEditable")]
        bool ShippingAddressEditable { [Bind("isShippingAddressEditable")] get; set; }

        // @property (copy, nonatomic) NSString * _Nullable currencyCode;
        [NullAllowed, Export("currencyCode")]
        string CurrencyCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable localeCode;
        [NullAllowed, Export("localeCode")]
        string LocaleCode { get; set; }

        // @property (nonatomic, strong) BTPostalAddress * _Nullable shippingAddressOverride;
        [NullAllowed, Export("shippingAddressOverride", ArgumentSemantic.Strong)]
        BTPostalAddress ShippingAddressOverride { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable billingAgreementDescription;
        [NullAllowed, Export("billingAgreementDescription")]
        string BillingAgreementDescription { get; set; }

        // @property (nonatomic) BTPayPalRequestIntent intent;
        [Export("intent", ArgumentSemantic.Assign)]
        BTPayPalRequestIntent Intent { get; set; }

        // @property (nonatomic) BTPayPalRequestUserAction userAction;
        [Export("userAction", ArgumentSemantic.Assign)]
        BTPayPalRequestUserAction UserAction { get; set; }

        // @property (nonatomic) BTPayPalRequestLandingPageType landingPageType;
        [Export("landingPageType", ArgumentSemantic.Assign)]
        BTPayPalRequestLandingPageType LandingPageType { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable displayName;
        [NullAllowed, Export("displayName")]
        string DisplayName { get; set; }

        // @property (nonatomic) BOOL offerCredit;
        [Export("offerCredit")]
        bool OfferCredit { get; set; }

        // @property (nonatomic, nullable, copy) NSString *merchantAccountId;
        [Export("merchantAccountId", ArgumentSemantic.Copy), NullAllowed]
        string MerchantAccountId { get; set; }

        // @property (nonatomic, nullable, copy) NSArray<BTPayPalLineItem *> *lineItems;
        [Export("lineItems", ArgumentSemantic.Copy), NullAllowed]
        BTPayPalLineItem[] LineItems { get; set; }
    }

    // @interface BTPayPalCreditFinancingAmount : NSObject
    [BaseType(typeof(NSObject))]
    interface BTPayPalCreditFinancingAmount
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable value;
        [NullAllowed, Export("value")]
        string Value { get; }
    }

    // @interface BTPayPalCreditFinancing : NSObject
    [BaseType(typeof(NSObject))]
    interface BTPayPalCreditFinancing
    {
        // @property (readonly, nonatomic) BOOL cardAmountImmutable;
        [Export("cardAmountImmutable")]
        bool CardAmountImmutable { get; }

        // @property (readonly, nonatomic, strong) BTPayPalCreditFinancingAmount * _Nullable monthlyPayment;
        [NullAllowed, Export("monthlyPayment", ArgumentSemantic.Strong)]
        BTPayPalCreditFinancingAmount MonthlyPayment { get; }

        // @property (readonly, nonatomic) BOOL payerAcceptance;
        [Export("payerAcceptance")]
        bool PayerAcceptance { get; }

        // @property (readonly, nonatomic) NSInteger term;
        [Export("term")]
        nint Term { get; }

        // @property (readonly, nonatomic, strong) BTPayPalCreditFinancingAmount * _Nullable totalCost;
        [NullAllowed, Export("totalCost", ArgumentSemantic.Strong)]
        BTPayPalCreditFinancingAmount TotalCost { get; }

        // @property (readonly, nonatomic, strong) BTPayPalCreditFinancingAmount * _Nullable totalInterest;
        [NullAllowed, Export("totalInterest", ArgumentSemantic.Strong)]
        BTPayPalCreditFinancingAmount TotalInterest { get; }
    }

    // @interface BTPayPalAccountNonce : BTPaymentMethodNonce
    [BaseType(typeof(BTPaymentMethodNonce))]
    interface BTPayPalAccountNonce
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable firstName;
        [NullAllowed, Export("firstName")]
        string FirstName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable lastName;
        [NullAllowed, Export("lastName")]
        string LastName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; }

        // @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable billingAddress;
        [NullAllowed, Export("billingAddress", ArgumentSemantic.Strong)]
        BTPostalAddress BillingAddress { get; }

        // @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable shippingAddress;
        [NullAllowed, Export("shippingAddress", ArgumentSemantic.Strong)]
        BTPostalAddress ShippingAddress { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable clientMetadataId;
        [NullAllowed, Export("clientMetadataId")]
        string ClientMetadataId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable payerId;
        [NullAllowed, Export("payerId")]
        string PayerId { get; }

        // @property (readonly, nonatomic, strong) BTPayPalCreditFinancing * _Nullable creditFinancing;
        [NullAllowed, Export("creditFinancing", ArgumentSemantic.Strong)]
        BTPayPalCreditFinancing CreditFinancing { get; }
    }

    [Static]
    partial interface BTPayPalDriverConstants
    {
        // extern NSString *const _Nonnull BTPayPalDriverErrorDomain;
        [Field("BTPayPalDriverErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }
    }

    partial interface IBTPayPalApprovalDelegate { }
    // @protocol BTPayPalApprovalDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTPayPalApprovalDelegate
    {
        // @required -(void)onApprovalComplete:(NSURL * _Nonnull)url;
        [Abstract]
        [Export("onApprovalComplete:")]
        void OnApprovalComplete(NSUrl url);

        // @required -(void)onApprovalCancel;
        [Abstract]
        [Export("onApprovalCancel")]
        void OnApprovalCancel();
    }

    partial interface IBTPayPalApprovalHandler { }
    // @protocol BTPayPalApprovalHandler
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTPayPalApprovalHandler
    {
        // @required -(void)handleApproval:(PPOTRequest * _Nonnull)request paypalApprovalDelegate:(id<BTPayPalApprovalDelegate> _Nonnull)delegate;
        [Abstract]
        [Export("handleApproval:paypalApprovalDelegate:")]
        void PaypalApprovalDelegate(PPOTRequest request, IBTPayPalApprovalDelegate @delegate);
    }

    // @interface BTPayPalDriver : NSObject <BTAppSwitchHandler, BTPayPalApprovalDelegate>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BTPayPalDriver : IBTAppSwitchHandler, BTPayPalApprovalDelegate
    {
        // -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient;
        [Export("initWithAPIClient:")]
        IntPtr Constructor(BTAPIClient apiClient);

        // -(void)authorizeAccountWithCompletion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
        [Export("authorizeAccountWithCompletion:")]
        void AuthorizeAccountWithCompletion(Action<BTPayPalAccountNonce, NSError> completionBlock);

        // -(void)authorizeAccountWithAdditionalScopes:(NSSet<NSString *> * _Nonnull)additionalScopes completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
        [Export("authorizeAccountWithAdditionalScopes:completion:")]
        void AuthorizeAccountWithAdditionalScopes(NSSet<NSString> additionalScopes, Action<BTPayPalAccountNonce, NSError> completionBlock);

        // -(void)requestOneTimePayment:(BTPayPalRequest * _Nonnull)request completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
        [Export("requestOneTimePayment:completion:")]
        void RequestOneTimePayment(BTPayPalRequest request, Action<BTPayPalAccountNonce, NSError> completionBlock);

        // -(void)requestOneTimePayment:(BTPayPalRequest * _Nonnull)request handler:(id<BTPayPalApprovalHandler> _Nonnull)handler completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
        [Export("requestOneTimePayment:handler:completion:")]
        void RequestOneTimePayment(BTPayPalRequest request, IBTPayPalApprovalHandler handler, Action<BTPayPalAccountNonce, NSError> completionBlock);

        // -(void)requestBillingAgreement:(BTPayPalRequest * _Nonnull)request completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
        [Export("requestBillingAgreement:completion:")]
        void RequestBillingAgreement(BTPayPalRequest request, Action<BTPayPalAccountNonce, NSError> completionBlock);

        // -(void)requestBillingAgreement:(BTPayPalRequest * _Nonnull)request handler:(id<BTPayPalApprovalHandler> _Nonnull)handler completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
        [Export("requestBillingAgreement:handler:completion:")]
        void RequestBillingAgreement(BTPayPalRequest request, IBTPayPalApprovalHandler handler, Action<BTPayPalAccountNonce, NSError> completionBlock);

        [Wrap("WeakAppSwitchDelegate")]
        [NullAllowed]
        BTAppSwitchDelegate AppSwitchDelegate { get; set; }

        // @property (nonatomic, weak) id<BTAppSwitchDelegate> _Nullable appSwitchDelegate;
        [NullAllowed, Export("appSwitchDelegate", ArgumentSemantic.Weak)]
        NSObject WeakAppSwitchDelegate { get; set; }

        [Wrap("WeakViewControllerPresentingDelegate")]
        [NullAllowed]
        BTViewControllerPresentingDelegate ViewControllerPresentingDelegate { get; set; }

        // @property (nonatomic, weak) id<BTViewControllerPresentingDelegate> _Nullable viewControllerPresentingDelegate;
        [NullAllowed, Export("viewControllerPresentingDelegate", ArgumentSemantic.Weak)]
        NSObject WeakViewControllerPresentingDelegate { get; set; }

        // - (void)setOneTimePaymentAppSwitchReturnBlock:(void (^)(BTPayPalAccountNonce * _Nullable tokenizedCheckout, NSError * _Nullable error))completionBlock;
        [Export("setOneTimePaymentAppSwitchReturnBlock:")]
        void SetOneTimePaymentAppSwitchReturnBlock(Action<BTPayPalAccountNonce, NSError> completionBlock);

        // - (void)setBillingAgreementAppSwitchReturnBlock:(void (^)(BTPayPalAccountNonce * _Nullable tokenizedAccount, NSError * _Nullable error))completionBlock;
        [Export("setBillingAgreementAppSwitchReturnBlock:")]
        void SetBillingAgreementAppSwitchReturnBlock(Action<BTPayPalAccountNonce, NSError> completionBlock);

        // - (void)setAuthorizationAppSwitchReturnBlock:(void (^)(BTPayPalAccountNonce * _Nullable tokenizedAccount, NSError * _Nullable error))completionBlock;
        [Export("setAuthorizationAppSwitchReturnBlock:")]
        void SetAuthorizationAppSwitchReturnBlock(Action<BTPayPalAccountNonce, NSError> completionBlock);

        // - (void)informDelegatePresentingViewControllerRequestPresent:(NSURL*) appSwitchURL;
        [Export("informDelegatePresentingViewControllerRequestPresent:")]
        void InformDelegatePresentingViewControllerRequestPresent(NSUrl appSwitchURL);

        // - (void)informDelegatePresentingViewControllerNeedsDismissal;
        [Export("informDelegatePresentingViewControllerNeedsDismissal")]
        void InformDelegatePresentingViewControllerNeedsDismissal();

        // @property (nonatomic, strong) BTPayPalRequestFactory *requestFactory;
        [Export("requestFactory", ArgumentSemantic.Strong)]
        BTPayPalRequestFactory RequestFactory { get; set; }

        // + (void)setPayPalClass:(Class)payPalClass;
        [Export("setPayPalClass:")]
        void setPayPalClass(Class paypalClass);

        // @property (nonatomic, copy) NSString *returnURLScheme;
        [Export("returnURLScheme", ArgumentSemantic.Copy)]
        string ReturnURLScheme { get; set; }

        // @property (nonatomic, strong, nullable) BTAPIClient *apiClient;
        [NullAllowed, Export("apiClient", ArgumentSemantic.Strong)]
        BTAPIClient ApiClient { get; set; }

        // @property (nonatomic, strong) NSString *clientMetadataId;
        [NullAllowed, Export("clientMetadataId", ArgumentSemantic.Strong)]
        string ClientMetadataId { get; set; }

        // @property (nonatomic, strong) BTPayPalRequest *payPalRequest;
        [Export("payPalRequest", ArgumentSemantic.Strong)]
        BTPayPalRequest payPalRequest { get; set; }

        // @property (nonatomic, strong, nullable) SFSafariViewController *safariViewController API_AVAILABLE(ios(9.0));
        [iOS(9, 0)]
        [NullAllowed, Export("safariViewController", ArgumentSemantic.Strong)]
        SFSafariViewController SafariViewController { get; set; }

        // @property (nonatomic, strong, nullable) SFAuthenticationSession *safariAuthenticationSession API_AVAILABLE(ios(11.0));
        [iOS(11, 0)]
        [NullAllowed, Export("safariAuthenticationSession", ArgumentSemantic.Strong)]
        SFAuthenticationSession SafariAuthenticationSession { get; set; }

        // @property (nonatomic, assign) BOOL isSFAuthenticationSessionStarted;
        [Export("isSFAuthenticationSessionStarted", ArgumentSemantic.Assign)]
        bool IsSFAuthenticationSessionStarted { get; set; }

        // @property (nonatomic, assign) BOOL disableSFAuthenticationSession;
        [Export("disableSFAuthenticationSession", ArgumentSemantic.Assign)]
        bool DisableSFAuthenticationSession { get; set; }

        // - (void)authorizeAccountWithAdditionalScopes:(NSSet<NSString *> *)additionalScopes forceFuturePaymentFlow:(BOOL)forceFuturePaymentFlow completion:(void (^)(BTPayPalAccountNonce *, NSError *))completionBlock;
        [Export("authorizeAccountWithAdditionalScopes:forceFuturePaymentFlow:completion:")]
        void authorizeAccountWithAdditionalScopes(NSSet additionalScopes, bool forceFuturePaymentFlow, Action<BTPaymentMethodNonce, NSError> completionBlock);

        // + (nullable BTPayPalCreditFinancingAmount *)creditFinancingAmountFromJSON:(BTJSON *)amountJSON;
        [Export("creditFinancingAmountFromJSON:")]
        BTPayPalCreditFinancingAmount creditFinancingAmountFromJSON(BTJSON json);

        // + (nullable BTPayPalCreditFinancing *)creditFinancingFromJSON:(BTJSON *)creditFinancingOfferedJSON;
        [Export("creditFinancingFromJSON:")]
        BTPayPalCreditFinancing creditFinancingFromJSON(BTJSON json);
    }
}
