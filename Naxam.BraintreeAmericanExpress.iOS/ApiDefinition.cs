using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using BraintreeCore;

namespace BraintreeAmericanExpress
{
    //    @interface BTAmericanExpressRewardsBalance : NSObject
    [BaseType(typeof(NSObject))]
    interface BTAmericanExpressRewardsBalance
    {

        ///**
        // @brief Optional. An error code when there was an issue fetching the rewards balance
        // */
        //@property(nonatomic, nullable, copy) NSString* errorCode;
        [NullAllowed, Export("errorCode")]
        string ErrorCode { get; set; }

        ///**
        // @brief Optional. An error message when there was an issue fetching the rewards balance
        // */
        //@property(nonatomic, nullable, copy) NSString* errorMessage;
        [NullAllowed, Export("errorMessage")]
        string ErrorMessage { get; set; }

        ///**
        // @brief Optional. The conversion rate associated with the rewards balance
        // */
        //@property(nonatomic, nullable, copy) NSString* conversionRate;
        [NullAllowed, Export("conversionRate")]
        string ConversionRate { get; set; }

        ///**
        // @brief Optional. The currency amount associated with the rewards balance
        // */
        //@property(nonatomic, nullable, copy) NSString* currencyAmount;
        [NullAllowed, Export("currencyAmount")]
        string CurrencyAmount { get; set; }

        ///**
        // @brief Optional. The currency ISO code associated with the rewards balance
        // */
        //@property(nonatomic, nullable, copy) NSString* currencyIsoCode;
        [NullAllowed, Export("currencyIsoCode")]
        string CurrencyIsoCode { get; set; }

        ///**
        // @brief Optional. The request ID used when fetching the rewards balance
        // */
        //@property(nonatomic, nullable, copy) NSString* requestId;
        [NullAllowed, Export("requestId")]
        string RequestId { get; set; }

        ///**
        // @brief Optional. The rewards amount associated with the rewards balance
        // */
        //@property(nonatomic, nullable, copy) NSString* rewardsAmount;
        [NullAllowed, Export("rewardsAmount")]
        string RewardsAmount { get; set; }

        ///**
        // @brief Optional. The rewards unit associated with the rewards balance
        // */
        //@property(nonatomic, nullable, copy) NSString* rewardsUnit;
        [NullAllowed, Export("rewardsUnit")]
        string RewardsUnit { get; set; }

        ///**
        // @brief Initialize with JSON from Braintree
        // */
        //- (instancetype) initWithJSON:(BTJSON*) json;
        [Export("initWithJSON:")]
        IntPtr Constructor(BTJSON json);
    }

    //    @interface BTAmericanExpressClient : NSObject
    [BaseType(typeof(NSObject)), DisableDefaultCtor]
    interface BTAmericanExpressClient
    {

        ///**
        // @brief Creates an American Express client.

        // @param apiClient An API client
        //*/
        //- (instancetype) initWithAPIClient:(BTAPIClient*) apiClient NS_DESIGNATED_INITIALIZER;
        [Export("initWithAPIClient:"), DesignatedInitializer]
        IntPtr Constructor(BTAPIClient apiClient);


        //- (instancetype) init __attribute__((unavailable("Please use initWithAPIClient:")));

        ///**
        // @brief Gets the rewards balance associated with a Braintree nonce. Only for American Express cards.

        // @param nonce A nonce representing a card that will be used to look up the rewards balance
        // @param currencyIsoCode The currencyIsoCode to use. Example: 'USD'
        // @param completionBlock A completion block that is invoked when the request has completed. If the request succeeds,
        // `rewardsBalance` will contain information about the rewards balance and `error` will be `nil` (see exceptions in note);
        // if it fails, `rewardsBalance` will be `nil` and `error` will describe the failure.
        // @note If the nonce is associated with an ineligible card or a card with insufficient points, the rewardsBalance will contain this information as `errorMessage` and `errorCode`.
        // */
        //- (void) getRewardsBalanceForNonce:(NSString*) nonce currencyIsoCode:(NSString*) currencyIsoCode completion:(void (^)(BTAmericanExpressRewardsBalance* _Nullable rewardsBalance, NSError * _Nullable error))completionBlock NS_AVAILABLE_IOS(8_0);
        [Export("getRewardsBalanceForNonce:currencyIsoCode:completion:")]
        void GetRewardsBalanceForNonce(string nonce, string currencyIsoCode, Action<BTAmericanExpressRewardsBalance, NSError> completion);
    }
}
