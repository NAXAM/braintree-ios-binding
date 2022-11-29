using System;
using BraintreePayPalNativeCheckout;
using Foundation;
using BraintreeCore;
using BraintreePayPal;

namespace BraintreePayPalNativeCheckout
{
	// @interface BTPayPalNativeCheckoutAccountNonce : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC29BraintreePayPalNativeCheckout34BTPayPalNativeCheckoutAccountNonce")]
	[DisableDefaultCtor]
	interface BTPayPalNativeCheckoutAccountNonce
	{
	}

	// @interface BTPayPalNativeCheckoutClient : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC29BraintreePayPalNativeCheckout28BTPayPalNativeCheckoutClient")]
	[DisableDefaultCtor]
	interface BTPayPalNativeCheckoutClient
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
		[Export ("initWithAPIClient:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)tokenizePayPalAccountWithPayPalRequest:(BTPayPalRequest * _Nonnull)nativeRequest completion:(void (^ _Nonnull)(BTPayPalNativeCheckoutAccountNonce * _Nullable, NSError * _Nullable))completion;
		[Export ("tokenizePayPalAccountWithPayPalRequest:completion:")]
		unsafe void TokenizePayPalAccountWithPayPalRequest (BTPayPalRequest nativeRequest, Action<BTPayPalNativeCheckoutAccountNonce, NSError> completion);
	}

	// @interface BTPayPalNativeCheckoutRequest
	[BaseType(typeof(BTPayPalCheckoutRequest))]
	interface BTPayPalNativeCheckoutRequest //: IBTPayPalNativeRequest
	{
		// -(instancetype _Nonnull)initWithAmount:(NSString * _Nonnull)amount __attribute__((objc_designated_initializer));
		[Export ("initWithAmount:")]
		[DesignatedInitializer]
		IntPtr Constructor (string amount);
	}

	// @interface BTPayPalNativeVaultRequest
	[BaseType(typeof(BTPayPalVaultRequest))]
	interface BTPayPalNativeVaultRequest //: IBTPayPalNativeRequest
	{
	}
}
