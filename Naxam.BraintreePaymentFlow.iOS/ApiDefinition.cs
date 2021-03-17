using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using BraintreeCore;
using BraintreeCard;
using CoreImage;
using System.Security.Cryptography.X509Certificates;
using CardinalMobile;

namespace BraintreePaymentFlow
{
    [BaseType(typeof(NSObject))]
    interface BTThreeDSecurePostalAddress : INSCopying {
        // @property (nonatomic, nullable, copy) NSString *givenName;
        [Export("givenName", ArgumentSemantic.Copy), NullAllowed]
        string GivenName { get; set; }

        // @property (nonatomic, nullable, copy) NSString *surname;
        [Export("surname", ArgumentSemantic.Copy), NullAllowed]
        string Surname { get; set; }

        // @property (nonatomic, nullable, copy) NSString *streetAddress;
        [Export("streetAddress", ArgumentSemantic.Copy), NullAllowed]
        string StreetAddress { get; set; }

        // @property (nonatomic, nullable, copy) NSString *extendedAddress;
        [Export("extendedAddress", ArgumentSemantic.Copy), NullAllowed]
        string ExtendedAddress { get; set; }

        // @property (nonatomic, nullable, copy) NSString *line3;
        [Export("line3", ArgumentSemantic.Copy), NullAllowed]
        string Line3 { get; set; }

        // @property (nonatomic, nullable, copy) NSString *locality;
        [Export("locality", ArgumentSemantic.Copy), NullAllowed]
        string Locality { get; set; }

        // @property (nonatomic, nullable, copy) NSString *region;
        [Export("region", ArgumentSemantic.Copy), NullAllowed]
        string Region { get; set; }

        // @property (nonatomic, nullable, copy) NSString *postalCode;
        [Export("postalCode", ArgumentSemantic.Copy), NullAllowed]
        string PostalCode { get; set; }

        // @property (nonatomic, nullable, copy) NSString *countryCodeAlpha2;
        [Export("countryCodeAlpha2", ArgumentSemantic.Copy), NullAllowed]
        string CountryCodeAlpha2 { get; set; }

        // @property (nonatomic, nullable, copy) NSString *phoneNumber;
        [Export("phoneNumber", ArgumentSemantic.Copy), NullAllowed]
        string PhoneNumber { get; set; }

        // @property (nonatomic, nullable, copy) NSString *firstName DEPRECATED_MSG_ATTRIBUTE("Use givenName instead.");

        // @property (nonatomic, nullable, copy) NSString *lastName DEPRECATED_MSG_ATTRIBUTE("Use surname instead.");
    }

    [BaseType(typeof(BTPaymentFlowResult))]
    interface BTThreeDSecureLookup {
        // @property (nonatomic, copy) NSString *PAReq;
        [Export("PAReq", ArgumentSemantic.Copy)]
        string PAReq { get; set; }

        // @property (nonatomic, copy) NSString *MD;
        [Export("MD", ArgumentSemantic.Copy)]
        string MD { get; set; }

        // @property (nonatomic, copy) NSURL *acsURL;
        [Export("acsURL", ArgumentSemantic.Copy)]
        NSUrl AcsURL { get; set; }

        // @property (nonatomic, copy) NSURL *termURL;
        [Export("termURL", ArgumentSemantic.Copy)]
        NSUrl termURL { get; set; }

        // @property (nonatomic, copy) NSString *threeDSecureVersion;
        [Export("threeDSecureVersion", ArgumentSemantic.Copy)]
        string ThreeDSecureVersion { get; set; }

        // @property (readonly, nonatomic) BOOL isThreeDSecureVersion2;
        [Export("isThreeDSecureVersion2", ArgumentSemantic.Copy)]
        bool IsThreeDSecureVersion2 { get; set; }

        // @property (nonatomic, copy) NSString *transactionId;
        [Export("transactionId", ArgumentSemantic.Copy)]
        string TransactionId { get; set; }

        // @property (nonatomic, strong) BTThreeDSecureResult *threeDSecureResult;
        [Export("threeDSecureResult", ArgumentSemantic.Copy)]
        BTThreeDSecureResult ThreeDSecureResult { get; set; }

        // - (instancetype)initWithJSON:(BTJSON *)JSON;
        [Export("initWithJSON:", ArgumentSemantic.Copy)]
        IntPtr Constructor(BTJSON json);

        // - (BOOL)requiresUserAuthentication;
        [Export("requiresUserAuthentication")]
        bool RequiresUserAuthentication();
    }

    [BaseType(typeof(NSObject))]
    interface BTThreeDSecureAdditionalInformation {
        // @property (nonatomic, nullable, copy) BTThreeDSecurePostalAddress *shippingAddress;
        [Export("shippingAddress", ArgumentSemantic.Copy), NullAllowed]
        BTThreeDSecurePostalAddress ShippingAddress { get; set;}

        // @property (nonatomic, nullable, copy) NSString *shippingMethodIndicator;
        [Export("shippingMethodIndicator", ArgumentSemantic.Copy), NullAllowed]
        string ShippingMethodIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *productCode;
        [Export("productCode", ArgumentSemantic.Copy), NullAllowed]
        string ProductCode { get; set; }

        // @property (nonatomic, nullable, copy) NSString *deliveryTimeframe;
        [Export("deliveryTimeframe", ArgumentSemantic.Copy), NullAllowed]
        string DeliveryTimeframe { get; set; }

        // @property (nonatomic, nullable, copy) NSString *deliveryEmail;
        [Export("deliveryEmail", ArgumentSemantic.Copy), NullAllowed]
        string DeliveryEmail { get; set; }

        // @property (nonatomic, nullable, copy) NSString *reorderIndicator;
        [Export("reorderIndicator", ArgumentSemantic.Copy), NullAllowed]
        string ReorderIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *preorderIndicator;
        [Export("preorderIndicator", ArgumentSemantic.Copy), NullAllowed]
        string PreorderIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *preorderDate;
        [Export("preorderDate", ArgumentSemantic.Copy), NullAllowed]
        string PreorderDate { get; set; }

        // @property (nonatomic, nullable, copy) NSString *giftCardAmount;
        [Export("giftCardAmount", ArgumentSemantic.Copy), NullAllowed]
        string GiftCardAmount { get; set; }

        // @property (nonatomic, nullable, copy) NSString *giftCardCurrencyCode;
        [Export("giftCardCurrencyCode", ArgumentSemantic.Copy), NullAllowed]
        string GiftCardCurrencyCode { get; set; }

        // @property (nonatomic, nullable, copy) NSString *giftCardCount;
        [Export("giftCardCount", ArgumentSemantic.Copy), NullAllowed]
        string GiftCardCount { get; set; }

        // @property (nonatomic, nullable, copy) NSString *accountAgeIndicator;
        [Export("accountAgeIndicator", ArgumentSemantic.Copy), NullAllowed]
        string AccountAgeIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *accountCreateDate;
        [Export("accountCreateDate", ArgumentSemantic.Copy), NullAllowed]
        string AccountCreateDate { get; set; }

        // @property (nonatomic, nullable, copy) NSString *accountChangeIndicator;
        [Export("accountChangeIndicator", ArgumentSemantic.Copy), NullAllowed]
        string AccountChangeIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *accountChangeDate;
        [Export("accountChangeDate", ArgumentSemantic.Copy), NullAllowed]
        string AccountChangeDate { get; set; }

        // @property (nonatomic, nullable, copy) NSString *accountPwdChangeIndicator;
        [Export("accountPwdChangeIndicator", ArgumentSemantic.Copy), NullAllowed]
        string AccountPwdChangeIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *accountPwdChangeDate;
        [Export("accountPwdChangeDate", ArgumentSemantic.Copy), NullAllowed]
        string AccountPwdChangeDate { get; set; }

        // @property (nonatomic, nullable, copy) NSString *shippingAddressUsageIndicator;
        [Export("shippingAddressUsageIndicator", ArgumentSemantic.Copy), NullAllowed]
        string ShippingAddressUsageIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *shippingAddressUsageDate;
        [Export("shippingAddressUsageDate", ArgumentSemantic.Copy), NullAllowed]
        string ShippingAddressUsageDate { get; set; }

        // @property (nonatomic, nullable, copy) NSString *transactionCountDay;
        [Export("transactionCountDay", ArgumentSemantic.Copy), NullAllowed]
        string TransactionCountDay { get; set; }

        // @property (nonatomic, nullable, copy) NSString *transactionCountYear;
        [Export("transactionCountYear", ArgumentSemantic.Copy), NullAllowed]
        string TransactionCountYear { get; set; }

        // @property (nonatomic, nullable, copy) NSString *addCardAttempts;
        [Export("addCardAttempts", ArgumentSemantic.Copy), NullAllowed]
        string AddCardAttempts { get; set; }

        // @property (nonatomic, nullable, copy) NSString *accountPurchases;
        [Export("accountPurchases", ArgumentSemantic.Copy), NullAllowed]
        string AccountPurchases { get; set; }

        // @property (nonatomic, nullable, copy) NSString *fraudActivity;
        [Export("fraudActivity", ArgumentSemantic.Copy), NullAllowed]
        string FraudActivity { get; set; }

        // @property (nonatomic, nullable, copy) NSString *shippingNameIndicator;
        [Export("shippingNameIndicator", ArgumentSemantic.Copy), NullAllowed]
        string ShippingNameIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *paymentAccountIndicator;
        [Export("paymentAccountIndicator", ArgumentSemantic.Copy), NullAllowed]
        string PaymentAccountIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *paymentAccountAge;
        [Export("paymentAccountAge", ArgumentSemantic.Copy), NullAllowed]
        string PaymentAccountAge { get; set; }

        // @property (nonatomic, nullable, copy) NSString *addressMatch;
        [Export("addressMatch", ArgumentSemantic.Copy), NullAllowed]
        string AddressMatch { get; set; }

        // @property (nonatomic, nullable, copy) NSString *accountId;
        [Export("accountId", ArgumentSemantic.Copy), NullAllowed]
        string AccountId { get; set; }

        // @property (nonatomic, nullable, copy) NSString *ipAddress;
        [Export("ipAddress", ArgumentSemantic.Copy), NullAllowed]
        string IPAddress { get; set; }

        // @property (nonatomic, nullable, copy) NSString *orderDescription;
        [Export("orderDescription", ArgumentSemantic.Copy), NullAllowed]
        string OrderDescription { get; set; }

        // @property (nonatomic, nullable, copy) NSString *taxAmount;
        [Export("taxAmount", ArgumentSemantic.Copy), NullAllowed]
        string TaxAmount { get; set; }

        // @property (nonatomic, nullable, copy) NSString *userAgent;
        [Export("userAgent", ArgumentSemantic.Copy), NullAllowed]
        string UserAgent { get; set; }

        // @property (nonatomic, nullable, copy) NSString *authenticationIndicator;
        [Export("authenticationIndicator", ArgumentSemantic.Copy), NullAllowed]
        string AuthenticationIndicator { get; set; }

        // @property (nonatomic, nullable, copy) NSString *installment;
        [Export("installment", ArgumentSemantic.Copy), NullAllowed]
        string Installment { get; set; }

        // @property (nonatomic, nullable, copy) NSString *purchaseDate;
        [Export("purchaseDate", ArgumentSemantic.Copy), NullAllowed]
        string PurchaseDate { get; set; }

        // @property (nonatomic, nullable, copy) NSString *recurringEnd;
        [Export("recurringEnd", ArgumentSemantic.Copy), NullAllowed]
        string RecurringEnd { get; set; }

        // @property (nonatomic, nullable, copy) NSString *recurringFrequency;
        [Export("recurringFrequency", ArgumentSemantic.Copy), NullAllowed]
        string RecurringFrequency { get; set; }

        // @property (nonatomic, nullable, copy) NSString *sdkMaxTimeout;
        [Export("sdkMaxTimeout", ArgumentSemantic.Copy), NullAllowed]
        string SdkMaxTimeout { get; set; }

        // @property (nonatomic, nullable, copy) NSString *workPhoneNumber;
        [Export("workPhoneNumber", ArgumentSemantic.Copy), NullAllowed]
        string WorkPhoneNumber { get; set; }
    }

    [BaseType(typeof(BTPaymentFlowResult))]
    interface BTLocalPaymentResult {
        // @property (nonatomic, nullable, readonly, strong) BTPostalAddress *billingAddress;
        [Export("billingAddress", ArgumentSemantic.Strong)]
        BTPostalAddress BillingAddress {get;}

        // @property (nonatomic, nullable, readonly, copy) NSString *clientMetadataId;
        [Export("clientMetadataId", ArgumentSemantic.Copy)]
        string ClientMetadataId {get;}

        // @property (nonatomic, nullable, readonly, copy) NSString *email;
        [Export("email", ArgumentSemantic.Copy)]
        string Email {get;}

        // @property (nonatomic, nullable, readonly, copy) NSString *firstName;
        [Export("firstName", ArgumentSemantic.Copy)]
        string FirstName {get;}

        // @property (nonatomic, nullable, readonly, copy) NSString *lastName;
        [Export("lastName", ArgumentSemantic.Copy)]
        string LastName {get;}

        // @property (nonatomic, readonly, copy) NSString *localizedDescription;
        [Export("localizedDescription", ArgumentSemantic.Copy)]
        string LocalizedDescription {get;}

        // @property (nonatomic, readonly, copy) NSString *nonce;
        [Export("nonce", ArgumentSemantic.Copy)]
        string Nonce {get;}

        // @property (nonatomic, nullable, readonly, copy) NSString *payerId;
        [Export("payerId", ArgumentSemantic.Copy)]
        string PayerId {get;}

        // @property (nonatomic, nullable, readonly, copy) NSString *phone;
        [Export("phone", ArgumentSemantic.Copy)]
        string Phone {get;}

        // @property (nonatomic, nullable, readonly, strong) BTPostalAddress *shippingAddress;
        [Export("shippingAddress", ArgumentSemantic.Copy)]
        string ShippingAddress {get;}

        // @property (nonatomic, readonly, copy) NSString *type;
        [Export("type", ArgumentSemantic.Copy)]
        string Type {get;}

        // - (instancetype)initWithNonce:(NSString *)nonce
        //                 description:(NSString *)description
        //                         type:(NSString *)type
        //                         email:(NSString *)email
        //                     firstName:(NSString *)firstName
        //                     lastName:(NSString *)lastName
        //                         phone:(NSString *)phone
        //             billingAddress:(BTPostalAddress *)billingAddress
        //             shippingAddress:(BTPostalAddress *)shippingAddress
        //             clientMetadataId:(NSString *)clientMetadataId
        //                     payerId:(NSString *)payerId;
        [Export("initWithNonce:description:type:email:firstName:lastName:phone:billingAddress:shippingAddress:clientMetadataId:payerId:")]
        IntPtr Constructor(
            string nonce, string description, string type, 
            string email, string firstName, string lastName, string phone, 
            BTPostalAddress billingAddress,
            BTPostalAddress shippingAddress,
            string clientMetadataId,
            string payerId
        );
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTLocalPaymentRequestDelegate {
        // - (void)localPaymentStarted:(BTLocalPaymentRequest *)request paymentId:(NSString *)paymentId start:(void(^)(void))start;;
        [Abstract, Export("localPaymentStarted:paymentId:start:")]
        void LocalPaymentStarted(BTLocalPaymentRequest request, string paymentId, Action start);
    }

    partial interface IBTPaymentFlowRequestDelegate {}

    [BaseType(typeof(BTPaymentFlowRequest))]
    partial interface BTLocalPaymentRequest : BTPaymentFlowRequestDelegate {
        // @property (nonatomic, nullable, copy) NSString *paymentType;
        [Export("paymentType", ArgumentSemantic.Copy), NullAllowed]
        string PaymentType {get;set;}

        // @property (nonatomic, nullable, copy) NSString *paymentTypeCountryCode;
        [Export("paymentTypeCountryCode", ArgumentSemantic.Copy), NullAllowed]
        string PaymentTypeCountryCode {get;set;}
        
        // @property (nonatomic, nullable, copy) NSString *merchantAccountId;
        [Export("merchantAccountId", ArgumentSemantic.Copy), NullAllowed]
        string MerchantAccountId {get;set;}
        
        // @property (nonatomic, nullable, copy) BTPostalAddress *address;
        [Export("address", ArgumentSemantic.Copy), NullAllowed]
        BTPostalAddress Address {get;set;}
        
        // @property (nonatomic, nullable, copy) NSString *amount;
        [Export("amount", ArgumentSemantic.Copy), NullAllowed]
        string Amount {get;set;}
        
        // @property (nonatomic, nullable, copy) NSString *currencyCode;
        [Export("currencyCode", ArgumentSemantic.Copy), NullAllowed]
        string CurrencyCode {get;set;}
        
        // @property (nonatomic, nullable, copy) NSString *email;
        [Export("email", ArgumentSemantic.Copy), NullAllowed]
        string Email {get;set;}
        
        // @property (nonatomic, nullable, copy) NSString *givenName;
        [Export("givenName", ArgumentSemantic.Copy), NullAllowed]
        string GivenName {get;set;}
        
        // @property (nonatomic, nullable, copy) NSString *surname;
        [Export("surname", ArgumentSemantic.Copy), NullAllowed]
        string Surname {get;set;}
        
        // @property (nonatomic, nullable, copy) NSString *phone;
        [Export("phone", ArgumentSemantic.Copy), NullAllowed]
        string Phone {get;set;}
        
        // @property (nonatomic, getter=isShippingAddressRequired) BOOL shippingAddressRequired;
        [Export("shippingAddressRequired", ArgumentSemantic.Copy), NullAllowed]
        string ShippingAddressRequired { [Export("isShippingAddressRequired")]get; set; }
        
        // @property (nonatomic, nullable, weak) id<BTLocalPaymentRequestDelegate> localPaymentFlowDelegate;
        [Wrap("WeakLocalPaymentFlowDelegate"), NullAllowed]
        BTLocalPaymentRequestDelegate LocalPaymentFlowDelegate {get;set;}

        [Export("localPaymentFlowDelegate", ArgumentSemantic.Weak), NullAllowed]
        NSObject WeakLocalPaymentFlowDelegate { get; set; }
    }

    [Category, BaseType(typeof(BTConfiguration))]
    interface BTConfiguration_ThreeDSecure
    {
        // @property (nonatomic, readonly, assign) BOOL cardinalAuthenticationJWT;
        [Static, Export("cardinalAuthenticationJWT")]
        bool CardinalAuthenticationJWT();
    }

    [Category, BaseType(typeof(BTConfiguration))]
    interface BTConfiguration_LocalPayment
    {
        // @property (nonatomic, readonly, assign) BOOL isLocalPaymentEnabled;
        [Static, Export("isLocalPaymentEnabled")]
        bool IsLocalPaymentEnabled();
    }
    
    
    partial interface IBTPaymentFlowDriverDelegate { }

    //    /**
    // @brief Protocol for payment flow processing via BTPaymentFlowRequestDelegate.
    // */
    //    @protocol BTPaymentFlowDriverDelegate
    [Protocol, BaseType(typeof(NSObject))]
    interface BTPaymentFlowDriverDelegate
    {
        ///**
        // @brief Use when payment URL is ready for processing.
        // */
        //- (void) onPaymentWithURL:(NSURL* _Nullable) url error:(NSError* _Nullable) error;
        [Export("onPaymentWithURL:error:")]
        void OnPaymentWithURL(NSUrl url, NSError error);

        ///**
        // @brief Use when the payment flow was cancelled.
        // */
        //- (void) onPaymentCancel;
        [Export("onPaymentCancel")]
        void OnPaymentCancel();

        ///**
        // @brief Use when the payment flow has completed or encountered an error.
        // @param result The BTPaymentFlowResult of the payment flow.
        // @param error NSError containing details of the error.
        // */
        //- (void) onPaymentComplete:(BTPaymentFlowResult* _Nullable) result error:(NSError* _Nullable) error;
        [Export("onPaymentComplete:error:")]
        void OnPaymentComplete(BTPaymentFlowResult result, NSError error);

        ///**
        // @brief Returns the base return URL scheme used by the driver.
        // @return A NSString representing the base return URL scheme used by the driver.
        // */
        //- (NSString*) returnURLScheme;
        [Export("returnURLScheme")]
        string returnURLScheme();

        ///**
        // @brief Returns the BTAPIClient used by the BTPaymentFlowDriverDelegate.
        // @return The BTAPIClient used by the driver.
        // */
        //- (BTAPIClient*) apiClient;
        [Export("apiClient")]
        BTAPIClient ApiClient();

        // @property (nonatomic, weak, nullable) id<BTAppSwitchDelegate> appSwitchDelegate;
        [Wrap("WeakAppSwitchDelegate"), NullAllowed]
        BTAppSwitchDelegate AppSwitchDelegate { get; set; }

        [Export("appSwitchDelegate", ArgumentSemantic.Weak), NullAllowed]
        [return: NullAllowed]
        NSObject WeakAppSwitchDelegate { get; set;}
    }

    //    /**
    //     @brief Protocol for payment flow processing.
    //     */
    //    @protocol BTPaymentFlowRequestDelegate
    [Protocol, BaseType(typeof(NSObject))]
    interface BTPaymentFlowRequestDelegate
    {

        ///**
        // @brief Handle payment request for a variety of web/app switch flows.

        // @discussion Use the delegate to handle success/error/cancel flows.

        // @param request A BTPaymentFlowRequest request.
        // @param delegate The BTPaymentFlowDriverDelegate to handle response.
        // */
        //- (void) handleRequest:(BTPaymentFlowRequest*) request client:(BTAPIClient*) apiClient paymentDriverDelegate:(id<BTPaymentFlowDriverDelegate>) delegate;
        [Export("handleRequest:client:paymentDriverDelegate:")]
        void HandleRequest(BTPaymentFlowRequest request, BTAPIClient client, IBTPaymentFlowDriverDelegate @delegate);

        ///**
        // @brief Check if this BTPaymentFlowRequestDelegate can handle the URL from the source application.

        // @param url The URL to check.
        // @param sourceApplication The source application to sent the URL.
        // @return True if the BTPaymentFlowRequestDelegate can handle the URL. Otherwise return false.
        // */
        //- (BOOL) canHandleAppSwitchReturnURL:(NSURL*) url sourceApplication:(NSString*) sourceApplication;
        [Export("canHandleAppSwitchReturnURL:sourceApplication:")]
        bool CanHandleAppSwitchReturnURL(NSUrl url, string sourceApplication);

        ///**
        // @brief Handles the return URL and completes and post processing.

        // @param url The URL to check.
        // */
        //- (void) handleOpenURL:(NSURL*) url;
        [Export("handleOpenURL:")]
        void HandleOpenURL(NSUrl url);

        ///**
        // @brief A short and unique alphanumeric name for the payment flow.

        // @discussion Used for analytics/events. No spaces and all lowercase.
        // */
        //- (NSString*) paymentFlowName;
        [Export("paymentFlowName")]
        string PaymentFlowName();
    }

    //    /**
    //     @brief BTPaymentFlowDriver handles the shared aspects of web/app payment flows.

    //     @discussion Handles the app switching and shared logic for payment flows that use web or app switching.
    //     */
    //    @interface BTPaymentFlowDriver : NSObject<BTAppSwitchHandler, BTPaymentFlowDriverDelegate>
    [BaseType(typeof(NSObject)), DisableDefaultCtor]
    interface BTPaymentFlowDriver : IBTAppSwitchHandler, BTPaymentFlowDriverDelegate
    {

        ///**
        // @brief Initialize a new BTPaymentFlowDriver instance.

        // @param apiClient The API client.
        // */
        //- (instancetype) initWithAPIClient:(BTAPIClient*) apiClient NS_DESIGNATED_INITIALIZER;
        [Export("initWithAPIClient:"), DesignatedInitializer]
        BTPaymentFlowDriver Constructor(BTAPIClient client);

        //- (instancetype) init __attribute__((unavailable("Please use initWithAPIClient:")));

        ///**
        // @brief Starts a payment flow using a BTPaymentFlowRequest (usually subclassed for specific payment methods).

        // @param request A BTPaymentFlowRequest request.
        // @param completionBlock This completion will be invoked exactly once when the payment flow is complete or an error occurs.
        // */
        //- (void) startPaymentFlow:(BTPaymentFlowRequest<BTPaymentFlowRequestDelegate>*) request completion:(void (^)(BTPaymentFlowResult* _Nullable result, NSError * _Nullable error))completionBlock;
        [Export("startPaymentFlow:completion:")]
        void StartPaymentFlow(BTPaymentFlowRequest request, Action<BTPaymentFlowResult, NSError> completion);

        ///**
        // @brief A required delegate to control the presentation and dismissal of view controllers.
        // */
        //@property(nonatomic, weak, nullable) id<BTViewControllerPresentingDelegate> viewControllerPresentingDelegate;
        [Export("viewControllerPresentingDelegate", ArgumentSemantic.Weak), NullAllowed]
        IBTViewControllerPresentingDelegate ViewControllerPresentingDelegate { get; set; }
    }

    //    @interface BTPaymentFlowDriver (ThreeDSecure)
    [Category, BaseType(typeof(BTPaymentFlowDriver))]
    interface BTPaymentFlowDriver_ThreeDSecure {
        // - (void)prepareLookup:(BTPaymentFlowRequest<BTPaymentFlowRequestDelegate> *)request completion:(void (^)(NSString * _Nullable lookupPayload, NSError * _Nullable error))completionBlock;
        [Export("prepareLookup:completion:")]
        void PrepareLookup(BTPaymentFlowRequest request, Action<string, NSError> completionBlock);

        // - (void)initializeChallengeWithLookupResponse:(NSString *)lookupResponse request:(BTPaymentFlowRequest<BTPaymentFlowRequestDelegate> *)request completion:(void (^)(BTPaymentFlowResult * _Nullable result, NSError * _Nullable error))completionBlock;
        [Export("initializeChallengeWithLookupResponse:request:completion:")]
        void InitializeChallengeWithLookupResponse(string lookupResponse, BTPaymentFlowRequest request, Action<BTPaymentFlowResult, NSError> completionBlock);
    }

    //    @interface BTPaymentFlowRequest : NSObject
    [BaseType(typeof(NSObject))]
    interface BTPaymentFlowRequest { }

    //@interface BTPaymentFlowResult : NSObject
    [BaseType(typeof(NSObject))]
    interface BTPaymentFlowResult { }

    //    /**
    // @brief Used to initialize a 3D Secure payment flow
    // */
    //    @interface BTThreeDSecureRequest : BTPaymentFlowRequest<BTPaymentFlowRequestDelegate>
    [BaseType(typeof(BTPaymentFlowRequest))]
    interface BTThreeDSecureRequest : BTPaymentFlowRequestDelegate
    {
        //    @property(nonatomic, copy) NSString* nonce;
        [Export("nonce", ArgumentSemantic.Copy)]
        string Nonce { get; set; }

        //@property(nonatomic, copy) NSDecimalNumber* amount;
        [Export("amount", ArgumentSemantic.Copy)]
        NSDecimalNumber Amount { get; set; }
        
        // @property (nonatomic, nullable, copy) BTThreeDSecurePostalAddress *billingAddress;
        [Export("billingAddress", ArgumentSemantic.Copy), NullAllowed]
        BTThreeDSecurePostalAddress BillingAddress { get; set; }

        // @property (nonatomic, nullable, copy) NSString *mobilePhoneNumber;
        [Export("mobilePhoneNumber", ArgumentSemantic.Copy), NullAllowed]
        string MobilePhoneNumber { get; set; }

        // @property (nonatomic, nullable, copy) NSString *email;
        [Export("email", ArgumentSemantic.Copy), NullAllowed]
        string Email { get; set; }

        // @property (nonatomic, nullable, copy) NSString *shippingMethod;
        [Export("shippingMethod", ArgumentSemantic.Copy), NullAllowed]
        string ShippingMethod { get; set; }

        // @property (nonatomic, nullable, strong) BTThreeDSecureAdditionalInformation *additionalInformation;
        [Export("additionalInformation", ArgumentSemantic.Strong), NullAllowed]
        BTThreeDSecureAdditionalInformation AdditionalInformation { get; set; }

        // @property (nonatomic, assign) BTThreeDSecureVersion versionRequested;
        [Export("versionRequested", ArgumentSemantic.Assign)]
        BTThreeDSecureVersion VersionRequested { get; set; }

        // @property (nonatomic) BOOL challengeRequested;
        [Export("challengeRequested")]
        bool ChallengeRequested { get; set; }

        // @property (nonatomic) BOOL exemptionRequested;
        [Export("exemptionRequested")]
        bool ExemptionRequested { get; set; }

        // @property (nonatomic, nullable, strong) UiCustomization *uiCustomization;
        [Export("uiCustomization", ArgumentSemantic.Strong), NullAllowed]
        UiCustomization UICustomization { get; set; }

        // @property (nonatomic, nullable, strong) BTThreeDSecureV1UICustomization *v1UICustomization;
        [Export("v1UICustomization", ArgumentSemantic.Strong), NullAllowed]
        BTThreeDSecureV1UICustomization V1UICustomization { get; set; }

        // @property (nonatomic, nullable, weak) id<BTThreeDSecureRequestDelegate> threeDSecureRequestDelegate;
        [Export("threeDSecureRequestDelegate", ArgumentSemantic.Weak), NullAllowed]
        NSObject WeakThreeDSecureRequestDelegate { get; set; }

        [Wrap("WeakThreeDSecureRequestDelegate")]
        [NullAllowed]
        BTThreeDSecureRequestDelegate BTThreeDSecureRequestDelegate { get; set; }
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTThreeDSecureRequestDelegate {
        // - (void)onLookupComplete:(BTThreeDSecureRequest *)request result:(BTThreeDSecureLookup *)result next:(void(^)(void))next;
        [Abstract, Export("onLookupComplete:result:next:")]
        void onLookupComplete(BTThreeDSecureRequest request, BTThreeDSecureLookup result, Action next);
    }


    //@interface BTThreeDSecureResult : BTPaymentFlowResult
    [BaseType(typeof(BTPaymentFlowResult))]
    interface BTThreeDSecureResult
    {
        // @property (nonatomic, assign) BOOL success DEPRECATED_MSG_ATTRIBUTE("Use `tokenizedCard.threeDSecureInfo.liabilityShiftPossible` and `tokenizedCard.threeDSecureInfo.liabilityShifted` instead.");
        [Export("success", ArgumentSemantic.Assign)]
        [Deprecated(PlatformName.iOS, PlatformArchitecture.All, "Use `tokenizedCard.threeDSecureInfo.liabilityShiftPossible` and `tokenizedCard.threeDSecureInfo.liabilityShifted` instead.")]
        bool Success { get; set; }

        // @property (nonatomic, assign) BOOL liabilityShifted DEPRECATED_MSG_ATTRIBUTE("Use `tokenizedCard.threeDSecureInfo.liabilityShifted` instead.");
        [Export("liabilityShifted", ArgumentSemantic.Assign)]
        [Deprecated(PlatformName.iOS, PlatformArchitecture.All, "Use `tokenizedCard.threeDSecureInfo.liabilityShifted` instead.")]
        bool LiabilityShifted { get; set; }

        // @property (nonatomic, assign) BOOL liabilityShiftPossible DEPRECATED_MSG_ATTRIBUTE("Use `tokenizedCard.threeDSecureInfo.liabilityShiftPossible` instead.");
        [Export("liabilityShiftPossible", ArgumentSemantic.Assign)]
        [Deprecated(PlatformName.iOS, PlatformArchitecture.All, "Use `tokenizedCard.threeDSecureInfo.liabilityShiftPossible` instead.")]
        bool LiabilityShiftPossible { get; set; }

        //@property(nonatomic, strong) BTCardNonce* tokenizedCard;
        [Export("tokenizedCard", ArgumentSemantic.Strong)]
        BTCardNonce TokenizedCard { get; set; }

        // @property (nonatomic, copy) NSString *errorMessage DEPRECATED_MSG_ATTRIBUTE("Use `tokenizedCard.threeDSecureInfo.errorMessage` instead.");
        [Export("errorMessage", ArgumentSemantic.Copy)]
        [Deprecated(PlatformName.iOS, PlatformArchitecture.All, "Use `tokenizedCard.threeDSecureInfo.errorMessage` instead.")]
        string ErrorMessage { get; set; }

        //- (instancetype) initWithJSON:(BTJSON*) JSON;
        [Export("initWithJSON:")]
        IntPtr Constructor(BTJSON json);
    }

    [BaseType(typeof(NSObject))]
    interface BTThreeDSecureV1UICustomization {
        // @property (nonatomic, nullable, copy) NSString *redirectButtonText;
        [Export("redirectButtonText", ArgumentSemantic.Copy), NullAllowed]
        string RedirectButtonText { get; set; }

        // @property (nonatomic, nullable, copy) NSString *redirectDescription;
        [Export("redirectDescription", ArgumentSemantic.Copy), NullAllowed]
        string RedirectDescription { get; set; }
    }
}
