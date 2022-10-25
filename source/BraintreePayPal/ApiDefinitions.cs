using System;
using BraintreePayPal;
using Foundation;
using ObjCRuntime;
using UIKit;
using BraintreeCore;

namespace BraintreePayPal
{
	// @interface BTConfiguration (PayPal)
	[Category]
	[BaseType(typeof(BTConfiguration))]
	interface BTConfiguration_PayPal
	{
		// @property (readonly, assign, nonatomic) int isPayPalEnabled;
		[Export("isPayPalEnabled")]
		int IsPayPalEnabled();

		// @property (readonly, assign, nonatomic) int isBillingAgreementsEnabled;
		[Export ("isBillingAgreementsEnabled")]
		int IsBillingAgreementsEnabled();
	}

	// @interface BTPayPalAccountNonce : BTPaymentMethodNonce
	[BaseType(typeof(BTPaymentMethodNonce))]
	interface BTPayPalAccountNonce 
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Copy)]
		unsafe string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName", ArgumentSemantic.Copy)]
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		unsafe string FirstName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName", ArgumentSemantic.Copy)]
		unsafe string LastName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone", ArgumentSemantic.Copy)]
		unsafe string Phone { get; }

		// @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable billingAddress;
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Strong)]
		unsafe BTPostalAddress BillingAddress { get; }

		// @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		unsafe BTPostalAddress ShippingAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable clientMetadataID;
		[NullAllowed, Export ("clientMetadataID", ArgumentSemantic.Copy)]
		unsafe string ClientMetadataID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable payerID;
		[NullAllowed, Export ("payerID", ArgumentSemantic.Copy)]
		unsafe string PayerID { get; }

		// @property (readonly, nonatomic, strong) BTPayPalCreditFinancing * _Nullable creditFinancing;
		[NullAllowed, Export ("creditFinancing", ArgumentSemantic.Strong)]
		BTPayPalCreditFinancing CreditFinancing { get; }
	}

	// @interface BTPayPalCheckoutRequest
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface BTPayPalCheckoutRequest
	{
		// -(instancetype)initWithAmount:(id)amount;
		[Export ("initWithAmount:")]
		IntPtr Constructor (NSObject amount);

		// @property (readonly, nonatomic, strong) NSString * amount;
		[Export ("amount", ArgumentSemantic.Strong)]
		unsafe string Amount { get; }

		// @property (copy, nonatomic) NSString * _Nullable currencyCode;
		[NullAllowed, Export ("currencyCode", ArgumentSemantic.Copy)]
		unsafe string CurrencyCode { get; set; }

		// @property (nonatomic) int intent;
		[Export ("intent")]
		int Intent { get; set; }

		// @property (nonatomic) int userAction;
		[Export ("userAction")]
		int UserAction { get; set; }

		// @property (nonatomic) int offerPayLater;
		[Export ("offerPayLater")]
		int OfferPayLater { get; set; }

		// @property (nonatomic) int requestBillingAgreement;
		[Export ("requestBillingAgreement")]
		int RequestBillingAgreement { get; set; }
	}

	// @interface BTPayPalCreditFinancing : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPayPalCreditFinancing
	{
		// @property (readonly, nonatomic) BOOL cardAmountImmutable;
		[Export ("cardAmountImmutable")]
		bool CardAmountImmutable { get; }

		// @property (readonly, nonatomic, strong) BTPayPalCreditFinancingAmount * _Nullable monthlyPayment;
		[NullAllowed, Export ("monthlyPayment", ArgumentSemantic.Strong)]
		BTPayPalCreditFinancingAmount MonthlyPayment { get; }

		// @property (readonly, nonatomic) BOOL payerAcceptance;
		[Export ("payerAcceptance")]
		bool PayerAcceptance { get; }

		// @property (readonly, nonatomic) NSInteger term;
		[Export ("term")]
		nint Term { get; }

		// @property (readonly, nonatomic, strong) BTPayPalCreditFinancingAmount * _Nullable totalCost;
		[NullAllowed, Export ("totalCost", ArgumentSemantic.Strong)]
		BTPayPalCreditFinancingAmount TotalCost { get; }

		// @property (readonly, nonatomic, strong) BTPayPalCreditFinancingAmount * _Nullable totalInterest;
		[NullAllowed, Export ("totalInterest", ArgumentSemantic.Strong)]
		BTPayPalCreditFinancingAmount TotalInterest { get; }
	}

	// @interface BTPayPalCreditFinancingAmount : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPayPalCreditFinancingAmount
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable currency;
		[NullAllowed, Export ("currency")]
		string Currency { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable value;
		[NullAllowed, Export ("value")]
		string Value { get; }
	}

	[Static]
	partial interface BTPayPalDriverConstants
	{
		// extern NSString *const _Nonnull BTPayPalDriverErrorDomain;
		[Field ("BTPayPalDriverErrorDomain", "__Internal")]
		NSString ErrorDomain { get; }
	}

	// @interface BTPayPalDriver : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTPayPalDriver
	{
		// -(instancetype _Nonnull)initWithAPIClient:(id)apiClient;
		[Export ("initWithAPIClient:")]
		IntPtr Constructor (NSObject apiClient);

		// -(void)requestOneTimePayment:(BTPayPalCheckoutRequest * _Nonnull)request completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock __attribute__((deprecated("Use tokenizePayPalAccount instead.")));
		[Export ("requestOneTimePayment:completion:")]
		void RequestOneTimePayment (BTPayPalCheckoutRequest request, Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)requestBillingAgreement:(id)request completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock __attribute__((deprecated("Use tokenizePayPalAccount instead.")));
		[Export ("requestBillingAgreement:completion:")]
		void RequestBillingAgreement (NSObject request, Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)tokenizePayPalAccountWithPayPalRequest:(BTPayPalRequest * _Nonnull)request completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("tokenizePayPalAccountWithPayPalRequest:completion:")]
		void TokenizePayPalAccountWithPayPalRequest (BTPayPalRequest request, Action<BTPayPalAccountNonce, NSError> completionBlock);
	}

	// @interface BTPayPalLineItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTPayPalLineItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull quantity;
		[Export ("quantity")]
		string Quantity { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull unitAmount;
		[Export ("unitAmount")]
		string UnitAmount { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, assign, nonatomic) BTPayPalLineItemKind kind;
		[Export ("kind", ArgumentSemantic.Assign)]
		BTPayPalLineItemKind Kind { get; }

		// @property (copy, nonatomic) NSString * _Nullable unitTaxAmount;
		[NullAllowed, Export ("unitTaxAmount")]
		string UnitTaxAmount { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable itemDescription;
		[NullAllowed, Export ("itemDescription")]
		string ItemDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable productCode;
		[NullAllowed, Export ("productCode")]
		string ProductCode { get; set; }

		// @property (nonatomic, strong) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; set; }

		// -(instancetype _Nonnull)initWithQuantity:(NSString * _Nonnull)quantity unitAmount:(NSString * _Nonnull)unitAmount name:(NSString * _Nonnull)name kind:(BTPayPalLineItemKind)kind;
		[Export ("initWithQuantity:unitAmount:name:kind:")]
		IntPtr Constructor (string quantity, string unitAmount, string name, BTPayPalLineItemKind kind);

		// -(NSDictionary * _Nonnull)requestParameters;
		[Export ("requestParameters")]
		NSDictionary RequestParameters { get; }
	}

	// @interface BTPayPalRequest : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPayPalRequest
	{
		// @property (getter = isShippingAddressRequired, nonatomic) BOOL shippingAddressRequired;
		[Export ("shippingAddressRequired")]
		bool ShippingAddressRequired { [Bind ("isShippingAddressRequired")] get; set; }

		// @property (getter = isShippingAddressEditable, nonatomic) BOOL shippingAddressEditable;
		[Export ("shippingAddressEditable")]
		bool ShippingAddressEditable { [Bind ("isShippingAddressEditable")] get; set; }

		// @property (copy, nonatomic) NSString * _Nullable localeCode;
		[NullAllowed, Export ("localeCode")]
		string LocaleCode { get; set; }

		// @property (nonatomic, strong) BTPostalAddress * _Nullable shippingAddressOverride;
		[NullAllowed, Export ("shippingAddressOverride", ArgumentSemantic.Strong)]
		BTPostalAddress ShippingAddressOverride { get; set; }

		// @property (nonatomic) BTPayPalRequestLandingPageType landingPageType;
		[Export ("landingPageType", ArgumentSemantic.Assign)]
		BTPayPalRequestLandingPageType LandingPageType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable merchantAccountID;
		[NullAllowed, Export ("merchantAccountID")]
		string MerchantAccountID { get; set; }

		// @property (copy, nonatomic) NSArray<BTPayPalLineItem *> * _Nullable lineItems;
		[NullAllowed, Export ("lineItems", ArgumentSemantic.Copy)]
		BTPayPalLineItem[] LineItems { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable billingAgreementDescription;
		[NullAllowed, Export ("billingAgreementDescription")]
		string BillingAgreementDescription { get; set; }

		// @property (nonatomic, strong) UIWindow * _Nullable activeWindow;
		[NullAllowed, Export ("activeWindow", ArgumentSemantic.Strong)]
		UIWindow ActiveWindow { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable riskCorrelationId;
		[NullAllowed, Export ("riskCorrelationId")]
		string RiskCorrelationId { get; set; }
	}

	// @interface BTPayPalVaultRequest : BTPayPalRequest
	[BaseType (typeof(BTPayPalRequest))]
	interface BTPayPalVaultRequest
	{
		// @property (nonatomic) BOOL offerCredit;
		[Export ("offerCredit")]
		bool OfferCredit { get; set; }
	}
}
