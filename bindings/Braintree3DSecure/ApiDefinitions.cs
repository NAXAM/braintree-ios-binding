using System;
using Braintree3DSecure;
using BraintreeCore;
using Foundation;
using ObjCRuntime;

namespace Braintree3DSecure
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
		// extern double BraintreeCardVersionNumber;
		[Field ("BraintreeCardVersionNumber", "__Internal")]
		double BraintreeCardVersionNumber { get; }

		// extern const unsigned char [] BraintreeCardVersionString;
		[Field ("BraintreeCardVersionString", "__Internal")]
		byte[] BraintreeCardVersionString { get; }

		// extern NSString *const _Nonnull BTCardClientErrorDomain;
		[Field ("BTCardClientErrorDomain", "__Internal")]
		NSString BTCardClientErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double Braintree3DSecureVersionNumber;
		[Field ("Braintree3DSecureVersionNumber", "__Internal")]
		double Braintree3DSecureVersionNumber { get; }

		// extern const unsigned char [] Braintree3DSecureVersionString;
		[Field ("Braintree3DSecureVersionString", "__Internal")]
		byte[] Braintree3DSecureVersionString { get; }
	}

	// @interface BTThreeDSecureCardNonce : BTCardNonce
	[BaseType (typeof(BTCardNonce))]
	interface BTThreeDSecureCardNonce
	{
		// @property (readonly, assign, nonatomic) BOOL liabilityShifted;
		[Export ("liabilityShifted")]
		bool LiabilityShifted { get; }

		// @property (readonly, assign, nonatomic) BOOL liabilityShiftPossible;
		[Export ("liabilityShiftPossible")]
		bool LiabilityShiftPossible { get; }

		// -(instancetype _Nonnull)initWithNonce:(NSString * _Nonnull)nonce description:(NSString * _Nullable)description cardNetwork:(BTCardNetwork)cardNetwork lastTwo:(NSString * _Nullable)lastTwo threeDSecureJSON:(BTJSON * _Nonnull)threeDSecureJSON isDefault:(BOOL)isDefault;
		[Export ("initWithNonce:description:cardNetwork:lastTwo:threeDSecureJSON:isDefault:")]
		IntPtr Constructor (string nonce, [NullAllowed] string description, BTCardNetwork cardNetwork, [NullAllowed] string lastTwo, BTJSON threeDSecureJSON, bool isDefault);
	}

	// @interface BTThreeDSecureDriver : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTThreeDSecureDriver
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient delegate:(id<BTViewControllerPresentingDelegate> _Nonnull)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithAPIClient:delegate:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTAPIClient apiClient, BTViewControllerPresentingDelegate @delegate);

		// -(void)verifyCardWithNonce:(NSString * _Nonnull)nonce amount:(NSDecimalNumber * _Nonnull)amount completion:(void (^ _Nonnull)(BTThreeDSecureCardNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("verifyCardWithNonce:amount:completion:")]
		void VerifyCardWithNonce (string nonce, NSDecimalNumber amount, Action<BTThreeDSecureCardNonce, NSError> completionBlock);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		BTViewControllerPresentingDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BTViewControllerPresentingDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const BTThreeDSecureErrorDomain;
		[Field ("BTThreeDSecureErrorDomain", "__Internal")]
		NSString BTThreeDSecureErrorDomain { get; }

		// extern NSString *const BTThreeDSecureInfoKey;
		[Field ("BTThreeDSecureInfoKey", "__Internal")]
		NSString BTThreeDSecureInfoKey { get; }

		// extern NSString *const BTThreeDSecureValidationErrorsKey;
		[Field ("BTThreeDSecureValidationErrorsKey", "__Internal")]
		NSString BTThreeDSecureValidationErrorsKey { get; }
	}
}
