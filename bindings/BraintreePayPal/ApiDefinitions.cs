using System;
using BraintreeCore;
using BraintreePayPal;
using Foundation;
using ObjCRuntime;

namespace BraintreePayPal
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreeCoreVersionNumber;
		[Field ("BraintreeCoreVersionNumber", "__Internal")]
		double BraintreeCoreVersionNumber { get; }

		// extern const unsigned char [] BraintreeCoreVersionString;
		[Field ("BraintreeCoreVersionString", "__Internal")]
		byte[] BraintreeCoreVersionString { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTJSONErrorDomain;
		[Field ("BTJSONErrorDomain", "__Internal")]
		NSString BTJSONErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTAPIClientErrorDomain;
		[Field ("BTAPIClientErrorDomain", "__Internal")]
		NSString BTAPIClientErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTAppSwitchWillSwitchNotification;
		[Field ("BTAppSwitchWillSwitchNotification", "__Internal")]
		NSString BTAppSwitchWillSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchDidSwitchNotification;
		[Field ("BTAppSwitchDidSwitchNotification", "__Internal")]
		NSString BTAppSwitchDidSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchWillProcessPaymentInfoNotification;
		[Field ("BTAppSwitchWillProcessPaymentInfoNotification", "__Internal")]
		NSString BTAppSwitchWillProcessPaymentInfoNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchNotificationTargetKey;
		[Field ("BTAppSwitchNotificationTargetKey", "__Internal")]
		NSString BTAppSwitchNotificationTargetKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTClientTokenKeyVersion;
		[Field ("BTClientTokenKeyVersion", "__Internal")]
		NSString BTClientTokenKeyVersion { get; }

		// extern NSString *const _Nonnull BTClientTokenErrorDomain;
		[Field ("BTClientTokenErrorDomain", "__Internal")]
		NSString BTClientTokenErrorDomain { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyAuthorizationFingerprint;
		[Field ("BTClientTokenKeyAuthorizationFingerprint", "__Internal")]
		NSString BTClientTokenKeyAuthorizationFingerprint { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyConfigURL;
		[Field ("BTClientTokenKeyConfigURL", "__Internal")]
		NSString BTClientTokenKeyConfigURL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTCustomerInputBraintreeValidationErrorsKey;
		[Field ("BTCustomerInputBraintreeValidationErrorsKey", "__Internal")]
		NSString BTCustomerInputBraintreeValidationErrorsKey { get; }

		// extern NSString *const BTHTTPErrorDomain;
		[Field ("BTHTTPErrorDomain", "__Internal")]
		NSString BTHTTPErrorDomain { get; }

		// extern NSString *const BTHTTPURLResponseKey;
		[Field ("BTHTTPURLResponseKey", "__Internal")]
		NSString BTHTTPURLResponseKey { get; }

		// extern NSString *const BTHTTPJSONResponseBodyKey;
		[Field ("BTHTTPJSONResponseBodyKey", "__Internal")]
		NSString BTHTTPJSONResponseBodyKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTTokenizationServiceErrorDomain;
		[Field ("BTTokenizationServiceErrorDomain", "__Internal")]
		NSString BTTokenizationServiceErrorDomain { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceAppSwitchDelegateOption;
		[Field ("BTTokenizationServiceAppSwitchDelegateOption", "__Internal")]
		NSString BTTokenizationServiceAppSwitchDelegateOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceViewPresentingDelegateOption;
		[Field ("BTTokenizationServiceViewPresentingDelegateOption", "__Internal")]
		NSString BTTokenizationServiceViewPresentingDelegateOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServicePayPalScopesOption;
		[Field ("BTTokenizationServicePayPalScopesOption", "__Internal")]
		NSString BTTokenizationServicePayPalScopesOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceAmountOption;
		[Field ("BTTokenizationServiceAmountOption", "__Internal")]
		NSString BTTokenizationServiceAmountOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceNonceOption;
		[Field ("BTTokenizationServiceNonceOption", "__Internal")]
		NSString BTTokenizationServiceNonceOption { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreePayPalVersionNumber;
		[Field ("BraintreePayPalVersionNumber", "__Internal")]
		double BraintreePayPalVersionNumber { get; }

		// extern const unsigned char [] BraintreePayPalVersionString;
		[Field ("BraintreePayPalVersionString", "__Internal")]
		byte[] BraintreePayPalVersionString { get; }
	}

	// @interface PayPal (BTConfiguration)
	[Category]
	[BaseType (typeof(BTConfiguration))]
	interface BTConfiguration_PayPal
	{
		// @property (readonly, assign, nonatomic) BOOL isPayPalEnabled;
		[Export ("isPayPalEnabled")]
		bool IsPayPalEnabled { get; }

		// @property (readonly, assign, nonatomic) BOOL isBillingAgreementsEnabled;
		[Export ("isBillingAgreementsEnabled")]
		bool IsBillingAgreementsEnabled { get; }
	}

	// @interface BTPayPalRequest : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPayPalRequest
	{
		// -(instancetype _Nonnull)initWithAmount:(NSString * _Nonnull)amount;
		[Export ("initWithAmount:")]
		IntPtr Constructor (string amount);

		// @property (readonly, nonatomic, strong) NSString * _Nonnull amount;
		[Export ("amount", ArgumentSemantic.Strong)]
		string Amount { get; }

		// @property (getter = isShippingAddressRequired, nonatomic) BOOL shippingAddressRequired;
		[Export ("shippingAddressRequired")]
		bool ShippingAddressRequired { [Bind ("isShippingAddressRequired")] get; set; }

		// @property (copy, nonatomic) NSString * _Nullable currencyCode;
		[NullAllowed, Export ("currencyCode")]
		string CurrencyCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable localeCode;
		[NullAllowed, Export ("localeCode")]
		string LocaleCode { get; set; }

		// @property (nonatomic, strong) BTPostalAddress * _Nullable shippingAddressOverride;
		[NullAllowed, Export ("shippingAddressOverride", ArgumentSemantic.Strong)]
		BTPostalAddress ShippingAddressOverride { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable billingAgreementDescription;
		[NullAllowed, Export ("billingAgreementDescription")]
		string BillingAgreementDescription { get; set; }

		// @property (nonatomic) BTPayPalRequestIntent intent;
		[Export ("intent", ArgumentSemantic.Assign)]
		BTPayPalRequestIntent Intent { get; set; }

		// @property (nonatomic) BTPayPalRequestUserAction userAction;
		[Export ("userAction", ArgumentSemantic.Assign)]
		BTPayPalRequestUserAction UserAction { get; set; }

		// @property (nonatomic) BTPayPalRequestLandingPageType landingPageType;
		[Export ("landingPageType", ArgumentSemantic.Assign)]
		BTPayPalRequestLandingPageType LandingPageType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; set; }

		// @property (nonatomic) BOOL offerCredit;
		[Export ("offerCredit")]
		bool OfferCredit { get; set; }
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

	// @interface BTPayPalAccountNonce : BTPaymentMethodNonce
	[BaseType (typeof(BTPaymentMethodNonce))]
	interface BTPayPalAccountNonce
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName")]
		string FirstName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName")]
		string LastName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; }

		// @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable billingAddress;
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Strong)]
		BTPostalAddress BillingAddress { get; }

		// @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		BTPostalAddress ShippingAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable clientMetadataId;
		[NullAllowed, Export ("clientMetadataId")]
		string ClientMetadataId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable payerId;
		[NullAllowed, Export ("payerId")]
		string PayerId { get; }

		// @property (readonly, nonatomic, strong) BTPayPalCreditFinancing * _Nullable creditFinancing;
		[NullAllowed, Export ("creditFinancing", ArgumentSemantic.Strong)]
		BTPayPalCreditFinancing CreditFinancing { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTPayPalDriverErrorDomain;
		[Field ("BTPayPalDriverErrorDomain", "__Internal")]
		NSString BTPayPalDriverErrorDomain { get; }
	}

	// @protocol BTPayPalApprovalDelegate
	[Protocol, Model]
	interface BTPayPalApprovalDelegate
	{
		// @required -(void)onApprovalComplete:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("onApprovalComplete:")]
		void OnApprovalComplete (NSUrl url);

		// @required -(void)onApprovalCancel;
		[Abstract]
		[Export ("onApprovalCancel")]
		void OnApprovalCancel ();
	}

	// @protocol BTPayPalApprovalHandler
	[Protocol, Model]
	interface BTPayPalApprovalHandler
	{
		// @required -(void)handleApproval:(PPOTRequest * _Nonnull)request paypalApprovalDelegate:(id<BTPayPalApprovalDelegate> _Nonnull)delegate;
		[Abstract]
		[Export ("handleApproval:paypalApprovalDelegate:")]
		void PaypalApprovalDelegate (PPOTRequest request, BTPayPalApprovalDelegate @delegate);
	}

	// @interface BTPayPalDriver : NSObject <BTAppSwitchHandler, BTPayPalApprovalDelegate>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTPayPalDriver : IBTAppSwitchHandler, IBTPayPalApprovalDelegate
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient;
		[Export ("initWithAPIClient:")]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)authorizeAccountWithCompletion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("authorizeAccountWithCompletion:")]
		void AuthorizeAccountWithCompletion (Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)authorizeAccountWithAdditionalScopes:(NSSet<NSString *> * _Nonnull)additionalScopes completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("authorizeAccountWithAdditionalScopes:completion:")]
		void AuthorizeAccountWithAdditionalScopes (NSSet<NSString> additionalScopes, Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)requestOneTimePayment:(BTPayPalRequest * _Nonnull)request completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("requestOneTimePayment:completion:")]
		void RequestOneTimePayment (BTPayPalRequest request, Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)requestOneTimePayment:(BTPayPalRequest * _Nonnull)request handler:(id<BTPayPalApprovalHandler> _Nonnull)handler completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("requestOneTimePayment:handler:completion:")]
		void RequestOneTimePayment (BTPayPalRequest request, BTPayPalApprovalHandler handler, Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)requestBillingAgreement:(BTPayPalRequest * _Nonnull)request completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("requestBillingAgreement:completion:")]
		void RequestBillingAgreement (BTPayPalRequest request, Action<BTPayPalAccountNonce, NSError> completionBlock);

		// -(void)requestBillingAgreement:(BTPayPalRequest * _Nonnull)request handler:(id<BTPayPalApprovalHandler> _Nonnull)handler completion:(void (^ _Nonnull)(BTPayPalAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("requestBillingAgreement:handler:completion:")]
		void RequestBillingAgreement (BTPayPalRequest request, BTPayPalApprovalHandler handler, Action<BTPayPalAccountNonce, NSError> completionBlock);

		[Wrap ("WeakAppSwitchDelegate")]
		[NullAllowed]
		BTAppSwitchDelegate AppSwitchDelegate { get; set; }

		// @property (nonatomic, weak) id<BTAppSwitchDelegate> _Nullable appSwitchDelegate;
		[NullAllowed, Export ("appSwitchDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAppSwitchDelegate { get; set; }

		[Wrap ("WeakViewControllerPresentingDelegate")]
		[NullAllowed]
		BTViewControllerPresentingDelegate ViewControllerPresentingDelegate { get; set; }

		// @property (nonatomic, weak) id<BTViewControllerPresentingDelegate> _Nullable viewControllerPresentingDelegate;
		[NullAllowed, Export ("viewControllerPresentingDelegate", ArgumentSemantic.Weak)]
		NSObject WeakViewControllerPresentingDelegate { get; set; }
	}
}
