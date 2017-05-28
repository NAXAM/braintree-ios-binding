using System;
using BraintreeCore;
using BraintreeVenmo;
using Foundation;
using ObjCRuntime;

namespace BraintreeVenmo
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
		// extern double BraintreeVenmoVersionNumber;
		[Field ("BraintreeVenmoVersionNumber", "__Internal")]
		double BraintreeVenmoVersionNumber { get; }

		// extern const unsigned char [] BraintreeVenmoVersionString;
		[Field ("BraintreeVenmoVersionString", "__Internal")]
		byte[] BraintreeVenmoVersionString { get; }
	}

	// @interface Venmo (BTConfiguration)
	[Category]
	[BaseType (typeof(BTConfiguration))]
	interface BTConfiguration_Venmo
	{
		// +(void)enableVenmo:(BOOL)isEnabled __attribute__((deprecated("Pay with Venmo no longer relies on a user whitelist, thus this method is not needed")));
		[Static]
		[Export ("enableVenmo:")]
		void EnableVenmo (bool isEnabled);

		// @property (readonly, assign, nonatomic) BOOL isVenmoEnabled;
		[Export ("isVenmoEnabled")]
		bool IsVenmoEnabled { get; }

		// @property (readonly, assign, nonatomic) NSString * venmoAccessToken;
		[Export ("venmoAccessToken")]
		string VenmoAccessToken { get; }
	}

	// @interface BTVenmoAccountNonce : BTPaymentMethodNonce
	[BaseType (typeof(BTPaymentMethodNonce))]
	interface BTVenmoAccountNonce
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable username;
		[NullAllowed, Export ("username")]
		string Username { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTVenmoDriverErrorDomain;
		[Field ("BTVenmoDriverErrorDomain", "__Internal")]
		NSString BTVenmoDriverErrorDomain { get; }
	}

	// @interface BTVenmoDriver : NSObject <BTAppSwitchHandler>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTVenmoDriver : IBTAppSwitchHandler
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
		[Export ("initWithAPIClient:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)authorizeAccountAndVault:(BOOL)vault completion:(void (^ _Nonnull)(BTVenmoAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("authorizeAccountAndVault:completion:")]
		void AuthorizeAccountAndVault (bool vault, Action<BTVenmoAccountNonce, NSError> completionBlock);

		// -(void)authorizeAccountWithCompletion:(void (^ _Nonnull)(BTVenmoAccountNonce * _Nullable, NSError * _Nullable))completionBlock __attribute__((deprecated("Use [BTVenmoDriver authorizeAccountAndVault:completion instead")));
		[Export ("authorizeAccountWithCompletion:")]
		void AuthorizeAccountWithCompletion (Action<BTVenmoAccountNonce, NSError> completionBlock);

		// -(BOOL)isiOSAppAvailableForAppSwitch;
		[Export ("isiOSAppAvailableForAppSwitch")]
		[Verify (MethodToProperty)]
		bool IsiOSAppAvailableForAppSwitch { get; }

		[Wrap ("WeakAppSwitchDelegate")]
		[NullAllowed]
		BTAppSwitchDelegate AppSwitchDelegate { get; set; }

		// @property (nonatomic, weak) id<BTAppSwitchDelegate> _Nullable appSwitchDelegate;
		[NullAllowed, Export ("appSwitchDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAppSwitchDelegate { get; set; }
	}
}
