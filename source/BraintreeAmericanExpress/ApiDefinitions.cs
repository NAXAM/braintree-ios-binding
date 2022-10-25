using System;
using BraintreeAmericanExpress;
using Foundation;
using BraintreeCore;

namespace BraintreeAmericanExpress
{
	[Static]
	partial interface BTAmericanExpressConstants
	{
		// extern NSString *const _Nonnull BTAmericanExpressErrorDomain;
		[Field ("BTAmericanExpressErrorDomain", "__Internal")]
		NSString ErrorDomain { get; }
	}

	// @interface BTAmericanExpressClient : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTAmericanExpressClient
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
		[Export ("initWithAPIClient:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)getRewardsBalanceForNonce:(NSString * _Nonnull)nonce currencyIsoCode:(NSString * _Nonnull)currencyIsoCode completion:(void (^ _Nonnull)(BTAmericanExpressRewardsBalance * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("getRewardsBalanceForNonce:currencyIsoCode:completion:")]
		void GetRewardsBalanceForNonce (string nonce, string currencyIsoCode, Action<BTAmericanExpressRewardsBalance, NSError> completionBlock);
	}

	// @interface BTAmericanExpressRewardsBalance : NSObject
	[BaseType (typeof(NSObject))]
	interface BTAmericanExpressRewardsBalance
	{
		// @property (copy, nonatomic) NSString * _Nullable errorCode;
		[NullAllowed, Export ("errorCode")]
		string ErrorCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable errorMessage;
		[NullAllowed, Export ("errorMessage")]
		string ErrorMessage { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable conversionRate;
		[NullAllowed, Export ("conversionRate")]
		string ConversionRate { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable currencyAmount;
		[NullAllowed, Export ("currencyAmount")]
		string CurrencyAmount { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable currencyIsoCode;
		[NullAllowed, Export ("currencyIsoCode")]
		string CurrencyIsoCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable requestID;
		[NullAllowed, Export ("requestID")]
		string RequestID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable rewardsAmount;
		[NullAllowed, Export ("rewardsAmount")]
		string RewardsAmount { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable rewardsUnit;
		[NullAllowed, Export ("rewardsUnit")]
		string RewardsUnit { get; set; }

		// -(instancetype _Nonnull)initWithJSON:(BTJSON * _Nonnull)json;
		[Export ("initWithJSON:")]
		IntPtr Constructor (BTJSON json);
	}
}
