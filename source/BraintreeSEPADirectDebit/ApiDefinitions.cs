using System;
using BraintreeSEPADirectDebit;
using Foundation;
using ObjCRuntime;
using BraintreeCore;
using AuthenticationServices;

namespace BraintreeSEPADirectDebit
{
	// @interface BTSEPADirectDebitClient : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC24BraintreeSEPADirectDebit23BTSEPADirectDebitClient")]
	[DisableDefaultCtor]
	interface BTSEPADirectDebitClient
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
		[Export ("initWithAPIClient:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)tokenizeWithRequest:(BTSEPADirectDebitRequest * _Nonnull)request context:(id<ASWebAuthenticationPresentationContextProviding> _Nonnull)context completion:(void (^ _Nonnull)(BTSEPADirectDebitNonce * _Nullable, NSError * _Nullable))completion __attribute__((availability(ios, introduced=13.0)));
		//[iOS (13,0)]
		[Export ("tokenizeWithRequest:context:completion:")]
		unsafe void TokenizeWithRequest (BTSEPADirectDebitRequest request, IASWebAuthenticationPresentationContextProviding context, Action<BTSEPADirectDebitNonce, NSError> completion);

		// -(void)tokenizeWithRequest:(BTSEPADirectDebitRequest * _Nonnull)request completion:(void (^ _Nonnull)(BTSEPADirectDebitNonce * _Nullable, NSError * _Nullable))completion;
		[Export ("tokenizeWithRequest:completion:")]
		unsafe void TokenizeWithRequest (BTSEPADirectDebitRequest request, Action<BTSEPADirectDebitNonce, NSError> completion);
	}

	// @interface BTSEPADirectDebitNonce : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC24BraintreeSEPADirectDebit22BTSEPADirectDebitNonce")]
	[DisableDefaultCtor]
	interface BTSEPADirectDebitNonce
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull nonce;
		[Export ("nonce")]
		string Nonce { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable ibanLastFour;
		[NullAllowed, Export ("ibanLastFour")]
		string IbanLastFour { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerID;
		[NullAllowed, Export ("customerID")]
		string CustomerID { get; }
	}

	// @interface BTSEPADirectDebitRequest : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC24BraintreeSEPADirectDebit24BTSEPADirectDebitRequest")]
	[DisableDefaultCtor]
	interface BTSEPADirectDebitRequest
	{
		// @property (copy, nonatomic) NSString * _Nullable accountHolderName;
		[NullAllowed, Export ("accountHolderName")]
		string AccountHolderName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable iban;
		[NullAllowed, Export ("iban")]
		string Iban { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable customerID;
		[NullAllowed, Export ("customerID")]
		string CustomerID { get; set; }

		// @property (nonatomic, strong) BTPostalAddress * _Nullable billingAddress;
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Strong)]
		BTPostalAddress BillingAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable merchantAccountID;
		[NullAllowed, Export ("merchantAccountID")]
		string MerchantAccountID { get; set; }
	}
}
