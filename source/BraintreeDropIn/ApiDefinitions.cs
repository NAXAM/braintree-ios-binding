using System;
using Foundation;
using ObjCRuntime;
using UIKit;
using BraintreeCore;
using BraintreePayPal;
using BraintreeThreeDSecure;
using BraintreeVenmo;

namespace BraintreeDropIn
{
	// @interface BTDropInController : UIViewController <UIToolbarDelegate, UIViewControllerTransitioningDelegate>
	[BaseType (typeof(UIViewController))]
	interface BTDropInController : IUIToolbarDelegate, IUIViewControllerTransitioningDelegate
	{
		// -(instancetype _Nullable)initWithAuthorization:(NSString * _Nonnull)authorization request:(BTDropInRequest *)request handler:(BTDropInControllerHandler _Nullable)handler;
		[Export ("initWithAuthorization:request:handler:")]
		IntPtr Constructor (string authorization, BTDropInRequest request, [NullAllowed] BTDropInControllerHandler handler);

		// @property (readonly, nonatomic, strong) BTAPIClient * _Nonnull apiClient;
		[Export ("apiClient", ArgumentSemantic.Strong)]
		unsafe BTAPIClient ApiClient { get; }

		// @property (readonly, nonatomic, strong) BTDropInRequest * _Nonnull dropInRequest;
		[Export ("dropInRequest", ArgumentSemantic.Strong)]
		unsafe BTDropInRequest DropInRequest { get; }

		// -(void)showCardForm:(id _Nonnull)sender;
		[Export ("showCardForm:")]
		void ShowCardForm (NSObject sender);
	}

	// typedef void (^BTDropInControllerHandler)(BTDropInController * _Nonnull, BTDropInResult * _Nullable, NSError * _Nullable);
	unsafe delegate void BTDropInControllerHandler (BTDropInController arg0, [NullAllowed] BTDropInResult arg1, [NullAllowed] NSError arg2);

	// @protocol BTDropInControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTDropInControllerDelegate
	{
		// @required -(void)reloadDropInData;
		[Abstract]
		[Export ("reloadDropInData")]
		void ReloadDropInData ();

		// @required -(void)editPaymentMethods:(id _Nonnull)sender;
		[Abstract]
		[Export ("editPaymentMethods:")]
		void EditPaymentMethods (NSObject sender);
	}

	// @interface BTDropInLocalization : NSObject
	[BaseType (typeof(NSObject))]
	interface BTDropInLocalization
	{
		// +(void)setCustomTranslations:(NSArray<NSString *> *)locales;
		[Static]
		[Export ("setCustomTranslations:")]
		void SetCustomTranslations (string[] locales);
	}

	// @interface BTDropInRequest : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface BTDropInRequest : INSCopying
	{
		// @property (nonatomic, strong) BTPayPalRequest * _Nullable payPalRequest;
		[NullAllowed, Export ("payPalRequest", ArgumentSemantic.Strong)]
		unsafe BTPayPalRequest PayPalRequest { get; set; }

		// @property (nonatomic, strong) BTVenmoRequest * _Nullable venmoRequest;
		[NullAllowed, Export ("venmoRequest", ArgumentSemantic.Strong)]
		unsafe BTVenmoRequest VenmoRequest { get; set; }

		// @property (assign, nonatomic) BOOL applePayDisabled;
		[Export ("applePayDisabled")]
		bool ApplePayDisabled { get; set; }

		// @property (assign, nonatomic) BOOL paypalDisabled;
		[Export ("paypalDisabled")]
		bool PaypalDisabled { get; set; }

		// @property (assign, nonatomic) BOOL venmoDisabled;
		[Export ("venmoDisabled")]
		bool VenmoDisabled { get; set; }

		// @property (assign, nonatomic) BOOL cardDisabled;
		[Export ("cardDisabled")]
		bool CardDisabled { get; set; }

		// @property (nonatomic, strong) BTThreeDSecureRequest * _Nullable threeDSecureRequest;
		[NullAllowed, Export ("threeDSecureRequest", ArgumentSemantic.Strong)]
		unsafe BTThreeDSecureRequest ThreeDSecureRequest { get; set; }

		// @property (assign, nonatomic) BTFormFieldSetting cardholderNameSetting;
		[Export ("cardholderNameSetting", ArgumentSemantic.Assign)]
		BTFormFieldSetting CardholderNameSetting { get; set; }

		// @property (assign, nonatomic) BOOL shouldMaskSecurityCode;
		[Export ("shouldMaskSecurityCode")]
		bool ShouldMaskSecurityCode { get; set; }

		// @property (assign, nonatomic) BOOL vaultManager;
		[Export ("vaultManager")]
		bool VaultManager { get; set; }

		// @property (assign, nonatomic) BOOL vaultCard;
		[Export ("vaultCard")]
		bool VaultCard { get; set; }

		// @property (assign, nonatomic) BOOL allowVaultCardOverride;
		[Export ("allowVaultCardOverride")]
		bool AllowVaultCardOverride { get; set; }

		// @property (nonatomic, strong) BTDropInUICustomization * _Nullable uiCustomization;
		[NullAllowed, Export ("uiCustomization", ArgumentSemantic.Strong)]
		unsafe BTDropInUICustomization UiCustomization { get; set; }
	}

	// @interface BTDropInResult : NSObject
	[BaseType (typeof(NSObject))]
	interface BTDropInResult
	{
		// @property (getter = isCanceled, assign, nonatomic) BOOL canceled;
		[Export ("canceled")]
		bool Canceled { [Bind ("isCanceled")] get; set; }

		// @property (assign, nonatomic) BTDropInPaymentMethodType paymentMethodType;
		[Export ("paymentMethodType", ArgumentSemantic.Assign)]
		BTDropInPaymentMethodType PaymentMethodType { get; set; }

		// @property (readonly, nonatomic) UIView * _Nonnull paymentIcon;
		[Export ("paymentIcon")]
		UIView PaymentIcon { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull paymentDescription;
		[Export ("paymentDescription")]
		string PaymentDescription { get; }

		// @property (nonatomic, strong) BTPaymentMethodNonce * _Nullable paymentMethod;
		[NullAllowed, Export ("paymentMethod", ArgumentSemantic.Strong)]
		BTPaymentMethodNonce PaymentMethod { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deviceData;
		[NullAllowed, Export ("deviceData", ArgumentSemantic.Strong)]
		string DeviceData { get; set; }

		// +(void)mostRecentPaymentMethodForClientToken:(NSString * _Nonnull)clientToken completion:(void (^ _Nonnull)(BTDropInResult * _Nullable, NSError * _Nullable))completion;
		[Static]
		[Export ("mostRecentPaymentMethodForClientToken:completion:")]
		void MostRecentPaymentMethodForClientToken (string clientToken, Action<BTDropInResult, NSError> completion);
	}

	// @interface BTDropInUICustomization : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTDropInUICustomization
	{
		// -(instancetype _Nonnull)initWithColorScheme:(BTDropInColorScheme)colorScheme;
		[Export ("initWithColorScheme:")]
		IntPtr Constructor (BTDropInColorScheme colorScheme);

		// @property (nonatomic, strong) UIColor * _Nonnull overlayColor;
		[Export ("overlayColor", ArgumentSemantic.Strong)]
		UIColor OverlayColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull tintColor;
		[Export ("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull barBackgroundColor;
		[Export ("barBackgroundColor", ArgumentSemantic.Strong)]
		UIColor BarBackgroundColor { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable fontFamily;
		[NullAllowed, Export ("fontFamily", ArgumentSemantic.Strong)]
		string FontFamily { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable boldFontFamily;
		[NullAllowed, Export ("boldFontFamily", ArgumentSemantic.Strong)]
		string BoldFontFamily { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull formBackgroundColor;
		[Export ("formBackgroundColor", ArgumentSemantic.Strong)]
		UIColor FormBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull formFieldBackgroundColor;
		[Export ("formFieldBackgroundColor", ArgumentSemantic.Strong)]
		UIColor FormFieldBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull primaryTextColor;
		[Export ("primaryTextColor", ArgumentSemantic.Strong)]
		UIColor PrimaryTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable navigationBarTitleTextColor;
		[NullAllowed, Export ("navigationBarTitleTextColor", ArgumentSemantic.Strong)]
		UIColor NavigationBarTitleTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull secondaryTextColor;
		[Export ("secondaryTextColor", ArgumentSemantic.Strong)]
		UIColor SecondaryTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull disabledColor;
		[Export ("disabledColor", ArgumentSemantic.Strong)]
		UIColor DisabledColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull placeholderTextColor;
		[Export ("placeholderTextColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull lineColor;
		[Export ("lineColor", ArgumentSemantic.Strong)]
		UIColor LineColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull errorForegroundColor;
		[Export ("errorForegroundColor", ArgumentSemantic.Strong)]
		UIColor ErrorForegroundColor { get; set; }

		// @property (nonatomic) UIBlurEffectStyle blurStyle;
		[Export ("blurStyle", ArgumentSemantic.Assign)]
		UIBlurEffectStyle BlurStyle { get; set; }

		// @property (nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
		[Export ("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
		UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }

		// @property (nonatomic) BOOL useBlurs;
		[Export ("useBlurs")]
		bool UseBlurs { get; set; }

		// @property (nonatomic) UIKeyboardType postalCodeFormFieldKeyboardType;
		[Export ("postalCodeFormFieldKeyboardType", ArgumentSemantic.Assign)]
		UIKeyboardType PostalCodeFormFieldKeyboardType { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull switchOnTintColor;
		[Export ("switchOnTintColor", ArgumentSemantic.Strong)]
		UIColor SwitchOnTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull switchThumbTintColor;
		[Export ("switchThumbTintColor", ArgumentSemantic.Strong)]
		UIColor SwitchThumbTintColor { get; set; }

		// @property (nonatomic) UIKeyboardAppearance keyboardAppearance;
		[Export ("keyboardAppearance", ArgumentSemantic.Assign)]
		UIKeyboardAppearance KeyboardAppearance { get; set; }

		// @property (nonatomic) BOOL disableDynamicType;
		[Export ("disableDynamicType")]
		bool DisableDynamicType { get; set; }
	}
}
