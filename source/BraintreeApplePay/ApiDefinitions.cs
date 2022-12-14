using System;
using BraintreeApplePay;
using Foundation;
using ObjCRuntime;
using PassKit;
using BraintreeCore;

namespace BraintreeApplePay
{
	// @interface BTApplePayCardNonce : BTPaymentMethodNonce
	[BaseType(typeof(BTPaymentMethodNonce))]	
	interface BTApplePayCardNonce
	{
		// @property (readonly, nonatomic, strong) BTBinData * binData;
		[Export ("binData", ArgumentSemantic.Strong)]
		unsafe BTBinData BinData { get; }

		// -(instancetype _Nullable)initWithJSON:(BTJSON *)json;
		[Export ("initWithJSON:")]
		IntPtr Constructor (BTJSON json);
	}

	[Static]
	partial interface BTApplePayConstants
	{
		// extern NSString *const _Nonnull BTApplePayErrorDomain;
		[Field ("BTApplePayErrorDomain", "__Internal")]
		NSString ErrorDomain { get; }
	}

	// @interface BTApplePayClient : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTApplePayClient
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
		[Export ("initWithAPIClient:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)paymentRequest:(void (^ _Nonnull)(PKPaymentRequest * _Nullable, NSError * _Nullable))completion;
		[Export ("paymentRequest:")]
		void PaymentRequest (Action<PKPaymentRequest, NSError> completion);

		// -(void)tokenizeApplePayPayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(BTApplePayCardNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("tokenizeApplePayPayment:completion:")]
		void TokenizeApplePayPayment (PKPayment payment, Action<BTApplePayCardNonce, NSError> completionBlock);
	}

	// @interface BTConfiguration (ApplePay)
	[Category, BaseType(typeof(BTConfiguration))]
	interface BTConfiguration_ApplePay
	{
		// @property (readonly, assign, nonatomic) BOOL isApplePayEnabled;
		[Export ("isApplePayEnabled")]
		bool IsApplePayEnabled ();

		// @property (readonly, nonatomic) NSArray<PKPaymentNetwork> * _Nullable applePaySupportedNetworks;
		[NullAllowed, Export ("applePaySupportedNetworks")]
		string[] ApplePaySupportedNetworks ();

		// @property (readonly, assign, nonatomic) BOOL canMakeApplePayPayments;
		[Export ("canMakeApplePayPayments")]
		bool CanMakeApplePayPayments ();

		// @property (readonly, nonatomic) NSString * _Nullable applePayCountryCode;
		[NullAllowed, Export ("applePayCountryCode")]
		string ApplePayCountryCode ();

		// @property (readonly, nonatomic) NSString * _Nullable applePayCurrencyCode;
		[NullAllowed, Export ("applePayCurrencyCode")]
		string ApplePayCurrencyCode ();

		// @property (readonly, nonatomic) NSString * _Nullable applePayMerchantIdentifier;
		[NullAllowed, Export ("applePayMerchantIdentifier")]
		string ApplePayMerchantIdentifier ();
	}
}
