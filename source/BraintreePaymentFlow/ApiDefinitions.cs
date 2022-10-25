using System;
using BraintreePaymentFlow;
using Foundation;
using ObjCRuntime;
using BraintreeCore;

namespace BraintreePaymentFlow
{
	// @interface LocalPayment
	[BaseType(typeof(NSObject))]
	interface LocalPayment
	{
		// @property (readonly, assign, nonatomic) int isLocalPaymentEnabled;
		[Export ("isLocalPaymentEnabled")]
		int IsLocalPaymentEnabled { get; }
	}

	// @interface BTLocalPaymentRequest
	[BaseType(typeof(NSObject))]
	interface BTLocalPaymentRequest
	{
		// @property (copy, nonatomic) int * _Nullable paymentType;
		[NullAllowed, Export ("paymentType", ArgumentSemantic.Copy)]
		unsafe string PaymentType { get; set; }

		// @property (copy, nonatomic) int * _Nullable paymentTypeCountryCode;
		[NullAllowed, Export ("paymentTypeCountryCode", ArgumentSemantic.Copy)]
		unsafe string PaymentTypeCountryCode { get; set; }

		// @property (copy, nonatomic) int * _Nullable merchantAccountID;
		[NullAllowed, Export ("merchantAccountID", ArgumentSemantic.Copy)]
		unsafe string MerchantAccountID { get; set; }

		// @property (copy, nonatomic) BTPostalAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Copy)]
		BTPostalAddress Address { get; set; }

		// @property (copy, nonatomic) int * _Nullable amount;
		[NullAllowed, Export ("amount", ArgumentSemantic.Copy)]
		unsafe string Amount { get; set; }

		// @property (copy, nonatomic) int * _Nullable currencyCode;
		[NullAllowed, Export ("currencyCode", ArgumentSemantic.Copy)]
		unsafe string CurrencyCode { get; set; }

		// @property (copy, nonatomic) int * _Nullable displayName;
		[NullAllowed, Export ("displayName", ArgumentSemantic.Copy)]
		unsafe string DisplayName { get; set; }

		// @property (copy, nonatomic) int * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Copy)]
		unsafe string Email { get; set; }

		// @property (copy, nonatomic) int * _Nullable givenName;
		[NullAllowed, Export ("givenName", ArgumentSemantic.Copy)]
		unsafe string GivenName { get; set; }

		// @property (copy, nonatomic) int * _Nullable surname;
		[NullAllowed, Export ("surname", ArgumentSemantic.Copy)]
		unsafe string Surname { get; set; }

		// @property (copy, nonatomic) int * _Nullable phone;
		[NullAllowed, Export ("phone", ArgumentSemantic.Copy)]
		unsafe string Phone { get; set; }

		// @property (getter = isShippingAddressRequired, nonatomic) int shippingAddressRequired;
		[Export ("shippingAddressRequired")]
		int ShippingAddressRequired { [Bind ("isShippingAddressRequired")] get; set; }

		// @property (copy, nonatomic) int * _Nullable bic;
		[NullAllowed, Export ("bic", ArgumentSemantic.Copy)]
		unsafe string Bic { get; set; }

		[Wrap ("WeakLocalPaymentFlowDelegate")]
		[NullAllowed]
		BTLocalPaymentRequestDelegate LocalPaymentFlowDelegate { get; set; }

		// @property (nonatomic, weak) id<BTLocalPaymentRequestDelegate> _Nullable localPaymentFlowDelegate;
		[NullAllowed, Export ("localPaymentFlowDelegate", ArgumentSemantic.Weak)]
		NSObject WeakLocalPaymentFlowDelegate { get; set; }
	}

	// @protocol BTLocalPaymentRequestDelegate
	[Protocol, Model ]
	[BaseType(typeof(NSObject))]
	interface BTLocalPaymentRequestDelegate
	{
		// @required -(void)localPaymentStarted:(BTLocalPaymentRequest *)request paymentID:(id)paymentID start:(void (^)(void))start;
		[Abstract]
		[Export ("localPaymentStarted:paymentID:start:")]
		void PaymentID (BTLocalPaymentRequest request, NSObject paymentID, Action start);
	}

	// @interface BTLocalPaymentResult
	[BaseType(typeof(NSObject))]
	interface BTLocalPaymentResult
	{
		// @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable billingAddress;
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Strong)]
		BTPostalAddress BillingAddress { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable clientMetadataID;
		[NullAllowed, Export ("clientMetadataID", ArgumentSemantic.Copy)]
		unsafe string ClientMetadataID { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Copy)]
		unsafe string Email { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable firstName;
		[NullAllowed, Export ("firstName", ArgumentSemantic.Copy)]
		unsafe string FirstName { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable lastName;
		[NullAllowed, Export ("lastName", ArgumentSemantic.Copy)]
		unsafe string LastName { get; }

		// @property (readonly, copy, nonatomic) int * nonce;
		[Export ("nonce", ArgumentSemantic.Copy)]
		unsafe string Nonce { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable payerID;
		[NullAllowed, Export ("payerID", ArgumentSemantic.Copy)]
		unsafe string PayerID { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable phone;
		[NullAllowed, Export ("phone", ArgumentSemantic.Copy)]
		unsafe string Phone { get; }

		// @property (readonly, nonatomic, strong) BTPostalAddress * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		BTPostalAddress ShippingAddress { get; }

		// @property (readonly, copy, nonatomic) int * type;
		[Export ("type", ArgumentSemantic.Copy)]
		unsafe string Type { get; }

		// -(instancetype)initWithNonce:(id)nonce type:(id)type email:(id)email firstName:(id)firstName lastName:(id)lastName phone:(id)phone billingAddress:(BTPostalAddress *)billingAddress shippingAddress:(BTPostalAddress *)shippingAddress clientMetadataID:(id)clientMetadataID payerID:(id)payerID;
		[Export ("initWithNonce:type:email:firstName:lastName:phone:billingAddress:shippingAddress:clientMetadataID:payerID:")]
		IntPtr Constructor (NSObject nonce, NSObject type, NSObject email, NSObject firstName, NSObject lastName, NSObject phone, BTPostalAddress billingAddress, BTPostalAddress shippingAddress, NSObject clientMetadataID, NSObject payerID);
	}

	// @protocol BTPaymentFlowDriverDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface BTPaymentFlowDriverDelegate
	{
		// @required -(void)onPaymentWithURL:(NSUrl * _Nullable)url error:(NSError * _Nullable)error;
		[Abstract]
		[Export ("onPaymentWithURL:error:")]
		void OnPaymentWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSError error);

		// @required -(void)onPaymentCancel;
		[Abstract]
		[Export ("onPaymentCancel")]
		void OnPaymentCancel ();

		// @required -(void)onPaymentComplete:(BTPaymentFlowResult * _Nullable)result error:(NSError * _Nullable)error;
		[Abstract]
		[Export ("onPaymentComplete:error:")]
		void OnPaymentComplete ([NullAllowed] BTPaymentFlowResult result, [NullAllowed] NSError error);

		// @required -(NSString * _Nonnull)returnURLScheme;
		[Abstract]
		[Export ("returnURLScheme")]
		string ReturnURLScheme { get; }

		// @required -(id)apiClient;
		[Abstract]
		[Export ("apiClient")]
		NSObject ApiClient { get; }
	}

	// @protocol BTPaymentFlowRequestDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface BTPaymentFlowRequestDelegate
	{
		// @required -(void)handleRequest:(BTPaymentFlowRequest * _Nonnull)request client:(id)apiClient paymentDriverDelegate:(id<BTPaymentFlowDriverDelegate> _Nonnull)delegate;
		[Abstract]
		[Export ("handleRequest:client:paymentDriverDelegate:")]
		void HandleRequest (BTPaymentFlowRequest request, NSObject apiClient, BTPaymentFlowDriverDelegate @delegate);

		// @required -(BOOL)canHandleAppSwitchReturnURL:(NSUrl * _Nonnull)url;
		[Abstract]
		[Export ("canHandleAppSwitchReturnURL:")]
		bool CanHandleAppSwitchReturnURL (NSUrl url);

		// @required -(void)handleOpenURL:(NSUrl * _Nonnull)url;
		[Abstract]
		[Export ("handleOpenURL:")]
		void HandleOpenURL (NSUrl url);

		// @required -(NSString * _Nonnull)paymentFlowName;
		[Abstract]
		[Export ("paymentFlowName")]
		string PaymentFlowName { get; }
	}

	// @interface BTPaymentFlowDriver : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTPaymentFlowDriver
	{
		// -(instancetype _Nonnull)initWithAPIClient:(id)apiClient __attribute__((objc_designated_initializer));
		[Export ("initWithAPIClient:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject apiClient);

		// -(void)startPaymentFlow:(BTPaymentFlowRequest<BTPaymentFlowRequestDelegate> * _Nonnull)request completion:(void (^ _Nonnull)(BTPaymentFlowResult * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("startPaymentFlow:completion:")]
		void StartPaymentFlow (BTPaymentFlowRequestDelegate request, Action<BTPaymentFlowResult, NSError> completionBlock);

		[Wrap ("WeakViewControllerPresentingDelegate")]
		[NullAllowed]
		NSObject ViewControllerPresentingDelegate { get; set; }

		// @property (nonatomic, weak) id _Nullable viewControllerPresentingDelegate;
		[NullAllowed, Export ("viewControllerPresentingDelegate", ArgumentSemantic.Weak)]
		NSObject WeakViewControllerPresentingDelegate { get; set; }
	}

	// @interface BTPaymentFlowRequest : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPaymentFlowRequest
	{
	}

	// @interface BTPaymentFlowResult : NSObject
	[BaseType (typeof(NSObject))]
	interface BTPaymentFlowResult
	{
	}
}