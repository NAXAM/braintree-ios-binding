using System;
using BraintreeCore;
using BraintreeVenmo;
using Foundation;
using ObjCRuntime;

namespace BraintreeVenmo
{
    // [Static]
    // [Verify (ConstantsInterfaceAssociation)]
    // partial interface Constants
    // {
    // 	// extern double BraintreeVenmoVersionNumber;
    // 	[Field ("BraintreeVenmoVersionNumber", "__Internal")]
    // 	double BraintreeVenmoVersionNumber { get; }

    // 	// extern const unsigned char [] BraintreeVenmoVersionString;
    // 	[Field ("BraintreeVenmoVersionString", "__Internal")]
    // 	byte[] BraintreeVenmoVersionString { get; }
    // }

    // @interface Venmo (BTConfiguration)
    [Category]
    [BaseType(typeof(BTConfiguration))]
    interface BTConfiguration_Venmo
    {
        // +(void)enableVenmo:(BOOL)isEnabled __attribute__((deprecated("Pay with Venmo no longer relies on a user whitelist, thus this method is not needed")));
        [Static]
        [Deprecated(PlatformName.iOS, PlatformArchitecture.All, "Pay with Venmo no longer relies on a user whitelist, thus this method is not needed")]
        [Export("enableVenmo:")]
        void EnableVenmo(bool isEnabled);

        // @property (readonly, assign, nonatomic) BOOL isVenmoEnabled;
        [Static, Export("isVenmoEnabled")]
        bool IsVenmoEnabled { get; }

        // @property (readonly, assign, nonatomic) NSString * venmoAccessToken;
        [Static, Export("venmoAccessToken")]
        string VenmoAccessToken { get; }
    }

    // @interface BTVenmoAccountNonce : BTPaymentMethodNonce
    [BaseType(typeof(BTPaymentMethodNonce))]
    interface BTVenmoAccountNonce
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable username;
        [NullAllowed, Export("username")]
        string Username { get; }
    }

    [Static]
    partial interface BTVenmoDriverConstants
    {
        // extern NSString *const _Nonnull BTVenmoDriverErrorDomain;
        [Field("BTVenmoDriverErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }
    }

    // @interface BTVenmoDriver : NSObject <BTAppSwitchHandler>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BTVenmoDriver : IBTAppSwitchHandler
    {
        // -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
        [Export("initWithAPIClient:")]
        [DesignatedInitializer]
        IntPtr Constructor(BTAPIClient apiClient);

        // -(void)authorizeAccountAndVault:(BOOL)vault completion:(void (^ _Nonnull)(BTVenmoAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
        [Export("authorizeAccountAndVault:completion:")]
        void AuthorizeAccountAndVault(bool vault, Action<BTVenmoAccountNonce, NSError> completionBlock);

        // -(void)authorizeAccountWithCompletion:(void (^ _Nonnull)(BTVenmoAccountNonce * _Nullable, NSError * _Nullable))completionBlock __attribute__((deprecated("Use [BTVenmoDriver authorizeAccountAndVault:completion instead")));
        [Export("authorizeAccountWithCompletion:")]
        void AuthorizeAccountWithCompletion(Action<BTVenmoAccountNonce, NSError> completionBlock);

        // -(BOOL)isiOSAppAvailableForAppSwitch;
        [Export("isiOSAppAvailableForAppSwitch")]
        bool IsiOSAppAvailableForAppSwitch { get; }

        [Wrap("WeakAppSwitchDelegate")]
        [NullAllowed]
        BTAppSwitchDelegate AppSwitchDelegate { get; set; }

        // @property (nonatomic, weak) id<BTAppSwitchDelegate> _Nullable appSwitchDelegate;
        [NullAllowed, Export("appSwitchDelegate", ArgumentSemantic.Weak)]
        NSObject WeakAppSwitchDelegate { get; set; }
    }
}
