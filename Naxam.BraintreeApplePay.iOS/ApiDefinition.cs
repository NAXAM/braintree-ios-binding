using System;
using BraintreeApplePay;
using BraintreeCore;
using Foundation;
using PassKit;

namespace BraintreeApplePay
{
    // [Static]
    // [Verify (ConstantsInterfaceAssociation)]
    // partial interface Constants
    // {
    // 	// extern double BraintreeApplePayVersionNumber;
    // 	[Field ("BraintreeApplePayVersionNumber", "__Internal")]
    // 	double BraintreeApplePayVersionNumber { get; }

    // 	// extern const unsigned char [] BraintreeApplePayVersionString;
    // 	[Field ("BraintreeApplePayVersionString", "__Internal")]
    // 	byte[] BraintreeApplePayVersionString { get; }
    // }

    // @interface BTApplePayCardNonce : BTPaymentMethodNonce
    [BaseType(typeof(BTPaymentMethodNonce))]
    interface BTApplePayCardNonce
    {
        ///<summary>
        ///  @brief The BIN data for the card number associated with this nonce.
        ///</summary>
        // @property (nonatomic, readonly, strong) BTBinData *binData;
        [Abstract, Export("binData")]
        BTBinData BinData { get; }

        // - (nullable instancetype)initWithNonce:(NSString *)nonce localizedDescription:(nullable NSString *)description type:(NSString *)type json:(BTJSON *)json;
        [Export("initWithNonce:localizedDescription:type:json:")]
        IntPtr Constructor(string nonce, string description, string type, BTJSON json);
    }

    [Static]
    partial interface BTApplePayConstants
    {
        // extern NSString *const _Nonnull BTApplePayErrorDomain;
        [Field("BTApplePayErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }
    }

    // @interface BTApplePayClient : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BTApplePayClient
    {
        // -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
        [Export("initWithAPIClient:")]
        [DesignatedInitializer]
        IntPtr Constructor(BTAPIClient apiClient);

        // -(void)paymentRequest:(void (^ _Nonnull)(PKPaymentRequest * _Nullable, NSError * _Nullable))completion;
        [Export("paymentRequest:")]
        void PaymentRequest(Action<PKPaymentRequest, NSError> completion);

        // -(void)tokenizeApplePayPayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(BTApplePayCardNonce * _Nullable, NSError * _Nullable))completionBlock;
        [Export("tokenizeApplePayPayment:completion:")]
        void TokenizeApplePayPayment(PKPayment payment, Action<BTApplePayCardNonce, NSError> completionBlock);
    }

    // @interface ApplePay (BTConfiguration)
    [Category]
    [BaseType(typeof(BTConfiguration))]
    interface BTConfiguration_ApplePay
    {
        // @property (readonly, assign, nonatomic) BOOL isApplePayEnabled;
        [Static, Export("isApplePayEnabled")]
        bool IsApplePayEnabled { get; }

        // @property (readonly, nonatomic) NSArray<PKPaymentNetwork> * _Nullable applePaySupportedNetworks;
        [Static, NullAllowed, Export("applePaySupportedNetworks")]
        string[] ApplePaySupportedNetworks { get; }

        // @property (readonly, assign, nonatomic) BOOL canMakeApplePayPayments;
        [Static, Export("canMakeApplePayPayments")]
        bool CanMakeApplePayPayments { get; }

        // @property (readonly, nonatomic) NSString * _Nullable applePayCountryCode;
        [Static, NullAllowed, Export("applePayCountryCode")]
        string ApplePayCountryCode { get; }

        // @property (readonly, nonatomic) NSString * _Nullable applePayCurrencyCode;
        [Static, NullAllowed, Export("applePayCurrencyCode")]
        string ApplePayCurrencyCode { get; }

        // @property (readonly, nonatomic) NSString * _Nullable applePayMerchantIdentifier;
        [Static, NullAllowed, Export("applePayMerchantIdentifier")]
        string ApplePayMerchantIdentifier { get; }
    }
}
