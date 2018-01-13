using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using BraintreeCore;
using BraintreeCard;
using CoreImage;
using System.Security.Cryptography.X509Certificates;

namespace BraintreePaymentFlow
{
    //    /**
    // @brief Category on BTConfiguration for iDEAL
    // */
    //    @interface BTConfiguration(Ideal)
    [Category, BaseType(typeof(BTConfiguration))]
    interface BTConfiguration_Ideal
    {

        ///**
        // @brief Indicates whether iDEAL is enabled for the merchant account.
        // */
        //@property(nonatomic, readonly, assign) BOOL isIdealEnabled;
        [Export("isIdealEnabled")]
        bool IsIdealEnabled();

        ///**
        // @brief Returns the RouteId used by the iDEAL.
        // */
        //@property(nonatomic, readonly, copy) NSString* routeId;
        [Export("routeId")]
        string RouteId();

        ///**
        // @brief The base iDEAL assets URL
        // */
        //@property(nonatomic, readonly, copy) NSString* idealAssetsUrl;
        [Export("idealAssetsUrl")]
        string IdealAssetsUrl();
    }

    //    /**
    // @brief iDEAL issuing bank.
    //  */
    //    @interface BTIdealBank : NSObject
    [BaseType(typeof(NSObject))]
    interface BTIdealBank
    {

        ///**
        // @brief Initialize a BTIdealBank.

        // @return A BTIdealBank.
        // */
        //- (instancetype) initWithCountryCode:(NSString*) countryCode issuerId:(NSString*) issuerId name:(NSString*) name imageUrl:(NSString*) imageUrl;
        [Export("initWithCountryCode:issuerId:name:imageUrl:")]
        IntPtr Constructor(string countryCode, string issuerId, string name, string imageUrl);

        ///**
        // @brief The country code of the bank.
        // */
        //@property(nonatomic, readonly, copy) NSString* countryCode;
        [Export("countryCode")]
        string CountryCode { get; }

        ///**
        // @brief The ID of the issuing bank.

        // @discussion See `BTPaymentFlowDriver+Ideal` and `BTIdealBank`.
        // */
        //@property(nonatomic, readonly, copy) NSString* issuerId;
        [Export("issuerId")]
        string IssuerId { get; }

        ///**
        // @brief The bank name, appropriate to display in UI.
        // */
        //@property(nonatomic, readonly, copy) NSString* name;
        [Export("name")]
        string Name { get; }

        ///**
        // @brief The URL of an image associated with the bank, appropriate to display in UI.
        // */
        //@property(nonatomic, readonly, copy) NSString* imageUrl;
        [Export("imageUrl")]
        string ImageUrl { get; }
    }

    partial interface IBTIdealRequestDelegate
    {

    }

    //    /**
    // @brief Used to initialize an iDEAL payment flow
    // */
    //    @interface BTIdealRequest : BTPaymentFlowRequest<BTPaymentFlowRequestDelegate>
    [BaseType(typeof(BTPaymentFlowRequest))]
    interface BTIdealRequest : BTPaymentFlowRequestDelegate
    {
        //    /**
        //     @brief A unique ID provided by you to associate with this transaction.
        //     */
        //    @property(nonatomic, copy) NSString* orderId;
        [Export("orderId")]
        string OrderId { get; set; }

        ///**
        // @brief The issuing bank for the iDEAL transaction.

        // @discussion See `BTPaymentFlowDriver+Ideal` and `BTIdealBank`.
        // */
        //@property(nonatomic, copy) NSString* issuer;
        [Export("issuer")]
        string Issuer { get; set; }

        ///**
        // @brief The currency of the transaction.
        // */
        //@property(nonatomic, copy) NSString* currency;
        [Export("currency")]
        string Currency { get; set; }

        ///**
        // @brief The amount for the transaction.
        // */
        //@property(nonatomic, copy) NSString* amount;
        [Export("amount")]
        string Amount { get; set; }

        ///**
        // @brief A delegate for receiving information about the iDEAL payment.
        // */
        //@property(nonatomic, weak) id<BTIdealRequestDelegate> idealPaymentFlowDelegate;
        [Export("idealPaymentFlowDelegate", ArgumentSemantic.Weak)]
        IBTIdealRequestDelegate IdealPaymentFlowDelegate { get; set; }
    }

    //    @protocol BTIdealRequestDelegate
    [Protocol, BaseType(typeof(NSObject))]
    interface BTIdealRequestDelegate
    {

        //@required

        ///**
        // @brief Returns the BTIdealResult with the iDEAL ID and status of `PENDING` before the flow starts. The ID should be used in conjunction with webhooks to detect the change in status.
        // */
        //- (void) idealPaymentStarted:(BTIdealResult*) result;
        [Abstract, Export("idealPaymentStarted:")]
        void IdealPaymentStarted(BTIdealResult result);
    }

    //    /**
    // @brief The result of an iDEAL payment flow
    // */
    //    @interface BTIdealResult : BTPaymentFlowResult
    [BaseType(typeof(BTPaymentFlowResult))]
    interface BTIdealResult
    {

        //    /**
        //     @brief The status of the iDEAL payment. Possible values are [PENDING, COMPLETE, FAILED].
        //     */
        //    @property(nonatomic, copy) NSString* status;
        [Export("status")]
        string Status { get; set; }

        ///**
        // @brief The identifier for the iDEAL payment.
        // */
        //@property(nonatomic, copy) NSString* idealId;
        [Export("idealId")]
        string IdealId { get; set; }

        ///**
        // @brief A shortened form of the identifier for the iDEAL payment.
        // */
        //@property(nonatomic, copy) NSString* shortIdealId;
        [Export("shortIdealId")]
        string ShortIdealId { get; set; }
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

    //        /**
    // @brief Category on BTPaymentFlowDriver for iDEAL
    // */
    //        @interface BTPaymentFlowDriver(Ideal)
    [Category, BaseType(typeof(BTPaymentFlowDriver))]
    interface BTPaymentFlowDriver_Ideal
    {

        ///**
        // @brief Fetch an array of issuing banks supported by your iDEAL integration.

        // @param completionBlock This completion will be invoked when the request is complete or an error occurs.
        // On success, returns an array of `BTIdealBank` instances; on failure, an error.
        // */
        //- (void) fetchIssuingBanks:(void (^)(NSArray<BTIdealBank*>* _Nullable banks, NSError * _Nullable error))completionBlock;
        [Export("fetchIssuingBanks:error:")]
        void FetchIssuingBanks(BTIdealBank[] banks, NSError error);

        ///**
        // @brief Poll until the `status` of the iDEAL payment is no longer `PENDING` or we exceed the maximum number of retries.

        // @param idealId The id of the ideal payment for which you'd like to check the status.
        // @param retries The number of retries to attempt. Valid values 0 - 10.
        // @param delay The number of milliseconds to wait between retries. Valid values 1000 - 10000.
        // @param completionBlock This completion block will be invoked when the status of the payment has changed from `PENDING` or we exceed the maximum number of retries.
        // */
        //- (void) pollForCompletionWithId:(NSString*) idealId retries:(int) retries delay:(int) delay completion:(void (^)(BTPaymentFlowResult* _Nullable result, NSError * _Nullable error))completionBlock;
        [Export("pollForCompletionWithId:retries::delay:completion:")]
        void PollForCompletionWithId(string idealId, int retries, int delay, Action<BTPaymentFlowRequest, NSError> completion);
    }

    //    @interface BTPaymentFlowDriver (ThreeDSecure)
    [Category, BaseType(typeof(BTPaymentFlowDriver))]
    interface BTPaymentFlowDriver_ThreeDSecure { }


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

        //    /**
        //     @brief A nonce to be verified by ThreeDSecure
        //     */
        //    @property(nonatomic, copy) NSString* nonce;
        [Export("nonce")]
        string Nonce { get; set; }

        ///**
        // @brief The amount for the transaction.
        // */
        //@property(nonatomic, copy) NSDecimalNumber* amount;
        [Export("amount")]
        decimal Amount { get; set; }
    }
    //@interface BTThreeDSecureResult : BTPaymentFlowResult
    [BaseType(typeof(BTPaymentFlowResult))]
    interface BTThreeDSecureResult
    {
        ///**
        // @brief True if the 3D Secure flow was successful
        // */
        //@property(nonatomic, assign) BOOL success;
        [Export("success")]
        bool Success { get; set; }

        ///**
        // @brief Indicates whether the liability for fraud has been shifted away from the merchant
        // */
        //@property(nonatomic, assign) BOOL liabilityShifted;
        [Export("liabilityShifted")]
        bool LiabilityShifted { get; set; }

        ///**
        // @brief Indicates whether the card was eligible for 3D Secure
        // */
        //@property(nonatomic, assign) BOOL liabilityShiftPossible;
        [Export("liabilityShiftPossible")]
        bool LiabilityShiftPossible { get; set; }

        ///**
        // @brief The `BTCardNonce` resulting from the 3D Secure flow
        // */
        //@property(nonatomic, strong) BTCardNonce* tokenizedCard;
        [Export("tokenizedCard")]
        BTCardNonce TokenizedCard { get; set; }

        ///**
        // @brief The error message when the 3D Secure flow is unsuccessful
        // */
        //@property(nonatomic, copy) NSString* errorMessage;
        [Export("errorMessage")]
        string ErrorMessage { get; set; }

        ///**
        // @brief Initialize a BTThreeDSecureResult

        // @param JSON BTJSON used to initialize the BTThreeDSecureResult
        // */
        //- (instancetype) initWithJSON:(BTJSON*) JSON;
        [Export("initWithJSON:")]
        BTThreeDSecureResult Constructor(BTJSON json);
    }
}
