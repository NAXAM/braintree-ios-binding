using System;
using BraintreeCore;
using BraintreeUI;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace BraintreeUI
{
    // [Static]
    // [Verify (ConstantsInterfaceAssociation)]
    // partial interface Constants
    // {
    // 	// extern double BraintreeUIVersionNumber;
    // 	[Field ("BraintreeUIVersionNumber", "__Internal")]
    // 	double BraintreeUIVersionNumber { get; }

    // 	// extern const unsigned char [] BraintreeUIVersionString;
    // 	[Field ("BraintreeUIVersionString", "__Internal")]
    // 	byte[] BraintreeUIVersionString { get; }
    // }

    // @interface BTDropInViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface BTDropInViewController
    {
        // -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient;
        [Export("initWithAPIClient:")]
        IntPtr Constructor(BTAPIClient apiClient);

        // @property (nonatomic, strong) BTAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        BTAPIClient ApiClient { get; set; }

        // @property (nonatomic, strong) BTPaymentRequest * _Nullable paymentRequest;
        [NullAllowed, Export("paymentRequest", ArgumentSemantic.Strong)]
        BTPaymentRequest PaymentRequest { get; set; }

        // @property (nonatomic, strong) NSArray * _Nonnull paymentMethodNonces;
        [Export("paymentMethodNonces", ArgumentSemantic.Strong)]
        NSObject[] PaymentMethodNonces { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        BTDropInViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<BTDropInViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) BTUI * _Nullable theme;
        [NullAllowed, Export("theme", ArgumentSemantic.Strong)]
        BTUI Theme { get; set; }

        // -(void)fetchPaymentMethodsOnCompletion:(void (^ _Nonnull)())completionBlock;
        [Export("fetchPaymentMethodsOnCompletion:")]
        void FetchPaymentMethodsOnCompletion(Action completionBlock);

        // -(void)setCardNumber:(NSString * _Nullable)cardNumber;
        [Export("setCardNumber:")]
        void SetCardNumber([NullAllowed] string cardNumber);

        // -(void)setCardExpirationMonth:(NSInteger)expirationMonth year:(NSInteger)expirationYear;
        [Export("setCardExpirationMonth:year:")]
        void SetCardExpirationMonth(nint expirationMonth, nint expirationYear);
    }

    // @protocol BTDropInViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTDropInViewControllerDelegate
    {
        // @required -(void)dropInViewController:(BTDropInViewController * _Nonnull)viewController didSucceedWithTokenization:(BTPaymentMethodNonce * _Nonnull)paymentMethodNonce;
        [Abstract]
        [Export("dropInViewController:didSucceedWithTokenization:")]
        void DropInViewController(BTDropInViewController viewController, BTPaymentMethodNonce paymentMethodNonce);

        // @required -(void)dropInViewControllerDidCancel:(BTDropInViewController * _Nonnull)viewController;
        [Abstract]
        [Export("dropInViewControllerDidCancel:")]
        void DropInViewControllerDidCancel(BTDropInViewController viewController);

        // @optional -(void)dropInViewControllerDidLoad:(BTDropInViewController * _Nonnull)viewController;
        [Export("dropInViewControllerDidLoad:")]
        void DropInViewControllerDidLoad(BTDropInViewController viewController);

        // @optional -(void)dropInViewControllerWillComplete:(BTDropInViewController * _Nonnull)viewController;
        [Export("dropInViewControllerWillComplete:")]
        void DropInViewControllerWillComplete(BTDropInViewController viewController);
    }

    // @interface BTPaymentRequest : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface BTPaymentRequest : INSCopying
    {
        // @property (copy, nonatomic) NSString * _Nullable summaryTitle;
        [NullAllowed, Export("summaryTitle")]
        string SummaryTitle { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable summaryDescription;
        [NullAllowed, Export("summaryDescription")]
        string SummaryDescription { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull displayAmount;
        [Export("displayAmount")]
        string DisplayAmount { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull callToActionText;
        [Export("callToActionText")]
        string CallToActionText { get; set; }

        // @property (assign, nonatomic) BOOL shouldHideCallToAction;
        [Export("shouldHideCallToAction")]
        bool ShouldHideCallToAction { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable amount;
        [NullAllowed, Export("amount")]
        string Amount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable currencyCode;
        [NullAllowed, Export("currencyCode")]
        string CurrencyCode { get; set; }

        // @property (assign, nonatomic) BOOL noShipping;
        [Export("noShipping")]
        bool NoShipping { get; set; }

        // @property (assign, nonatomic) BOOL presentViewControllersFromTop;
        [Export("presentViewControllersFromTop")]
        bool PresentViewControllersFromTop { get; set; }

        // @property (assign, nonatomic) BOOL showDefaultPaymentMethodNonceFirst;
        [Export("showDefaultPaymentMethodNonceFirst")]
        bool ShowDefaultPaymentMethodNonceFirst { get; set; }

        // @property (nonatomic, strong) BTPostalAddress * _Nullable shippingAddress;
        [NullAllowed, Export("shippingAddress", ArgumentSemantic.Strong)]
        BTPostalAddress ShippingAddress { get; set; }

        // @property (nonatomic, strong) NSSet<NSString *> * _Nullable additionalPayPalScopes;
        [NullAllowed, Export("additionalPayPalScopes", ArgumentSemantic.Strong)]
        NSSet<NSString> AdditionalPayPalScopes { get; set; }
    }

    // @interface BTUIVectorArtView : UIView
    [BaseType(typeof(UIView))]
    interface BTUIVectorArtView
    {
        // -(void)drawArt;
        [Export("drawArt")]
        void DrawArt();

        // @property (assign, nonatomic) CGSize artDimensions;
        [Export("artDimensions", ArgumentSemantic.Assign)]
        CGSize ArtDimensions { get; set; }

        // -(UIImage *)imageOfSize:(CGSize)size;
        [Export("imageOfSize:")]
        UIImage ImageOfSize(CGSize size);
    }

    // @interface BTUI : NSObject
    [BaseType(typeof(NSObject))]
    interface BTUI
    {
        // +(BTUI *)braintreeTheme;
        [Static]
        [Export("braintreeTheme")]
        BTUI BraintreeTheme { get; }

        // -(UIColor *)idealGray;
        [Export("idealGray")]
        UIColor IdealGray { get; }

        // -(UIColor *)defaultTintColor;
        [Export("defaultTintColor")]
        UIColor DefaultTintColor { get; }

        // -(UIColor *)viewBackgroundColor;
        [Export("viewBackgroundColor")]
        UIColor ViewBackgroundColor { get; }

        // -(UIColor *)callToActionColor;
        [Export("callToActionColor")]
        UIColor CallToActionColor { get; }

        // -(UIColor *)callToActionColorHighlighted;
        [Export("callToActionColorHighlighted")]
        UIColor CallToActionColorHighlighted { get; }

        // -(UIColor *)disabledButtonColor;
        [Export("disabledButtonColor")]
        UIColor DisabledButtonColor { get; }

        // -(UIColor *)titleColor;
        [Export("titleColor")]
        UIColor TitleColor { get; }

        // -(UIColor *)detailColor;
        [Export("detailColor")]
        UIColor DetailColor { get; }

        // -(UIColor *)borderColor;
        [Export("borderColor")]
        UIColor BorderColor { get; }

        // -(UIColor *)textFieldTextColor;
        [Export("textFieldTextColor")]
        UIColor TextFieldTextColor { get; }

        // -(UIColor *)textFieldPlaceholderColor;
        [Export("textFieldPlaceholderColor")]
        UIColor TextFieldPlaceholderColor { get; }

        // -(UIColor *)sectionHeaderTextColor;
        [Export("sectionHeaderTextColor")]
        UIColor SectionHeaderTextColor { get; }

        // -(UIColor *)textFieldFloatLabelTextColor;
        [Export("textFieldFloatLabelTextColor")]
        UIColor TextFieldFloatLabelTextColor { get; }

        // -(UIColor *)cardHintBorderColor;
        [Export("cardHintBorderColor")]
        UIColor CardHintBorderColor { get; }

        // -(UIColor *)errorBackgroundColor;
        [Export("errorBackgroundColor")]
        UIColor ErrorBackgroundColor { get; }

        // -(UIColor *)errorForegroundColor;
        [Export("errorForegroundColor")]
        UIColor ErrorForegroundColor { get; }

        // -(CGFloat)highlightedBrightnessAdjustment;
        [Export("highlightedBrightnessAdjustment")]
        nfloat HighlightedBrightnessAdjustment { get; }

        // -(UIColor *)payBlue;
        [Export("payBlue")]
        UIColor PayBlue { get; }

        // -(UIColor *)palBlue;
        [Export("palBlue")]
        UIColor PalBlue { get; }

        // -(UIColor *)payPalButtonBlue;
        [Export("payPalButtonBlue")]
        UIColor PayPalButtonBlue { get; }

        // -(UIColor *)payPalButtonActiveBlue;
        [Export("payPalButtonActiveBlue")]
        UIColor PayPalButtonActiveBlue { get; }

        // -(UIColor *)venmoPrimaryBlue;
        [Export("venmoPrimaryBlue")]
        UIColor VenmoPrimaryBlue { get; }

        // -(UIColor *)coinbasePrimaryBlue;
        [Export("coinbasePrimaryBlue")]
        UIColor CoinbasePrimaryBlue { get; }

        // -(UIFont *)controlFont;
        [Export("controlFont")]
        UIFont ControlFont { get; }

        // -(UIFont *)controlTitleFont;
        [Export("controlTitleFont")]
        UIFont ControlTitleFont { get; }

        // -(UIFont *)controlDetailFont;
        [Export("controlDetailFont")]
        UIFont ControlDetailFont { get; }

        // -(UIFont *)textFieldFont;
        [Export("textFieldFont")]
        UIFont TextFieldFont { get; }

        // -(UIFont *)textFieldFloatLabelFont;
        [Export("textFieldFloatLabelFont")]
        UIFont TextFieldFloatLabelFont { get; }

        // -(UIFont *)sectionHeaderFont;
        [Export("sectionHeaderFont")]
        UIFont SectionHeaderFont { get; }

        // -(NSDictionary *)textFieldTextAttributes;
        [Export("textFieldTextAttributes")]
        NSDictionary TextFieldTextAttributes { get; }

        // -(NSDictionary *)textFieldPlaceholderAttributes;
        [Export("textFieldPlaceholderAttributes")]
        NSDictionary TextFieldPlaceholderAttributes { get; }

        // -(CGFloat)borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; }

        // -(CGFloat)cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; }

        // -(CGFloat)formattedEntryKerning;
        [Export("formattedEntryKerning")]
        nfloat FormattedEntryKerning { get; }

        // -(CGFloat)horizontalMargin;
        [Export("horizontalMargin")]
        nfloat HorizontalMargin { get; }

        // -(CGFloat)paymentButtonMinHeight;
        [Export("paymentButtonMinHeight")]
        nfloat PaymentButtonMinHeight { get; }

        // -(CGFloat)paymentButtonMaxHeight;
        [Export("paymentButtonMaxHeight")]
        nfloat PaymentButtonMaxHeight { get; }

        // -(CGFloat)paymentButtonWordMarkHeight __attribute__((deprecated("")));
        [Export("paymentButtonWordMarkHeight")]
        nfloat PaymentButtonWordMarkHeight { get; }

        // -(CGFloat)quickTransitionDuration;
        [Export("quickTransitionDuration")]
        nfloat QuickTransitionDuration { get; }

        // -(CGFloat)transitionDuration;
        [Export("transitionDuration")]
        nfloat TransitionDuration { get; }

        // -(CGFloat)minimumVisibilityTime;
        [Export("minimumVisibilityTime")]
        nfloat MinimumVisibilityTime { get; }

        // -(BTUIVectorArtView *)vectorArtViewForPaymentInfoType:(NSString *)typeString;
        [Export("vectorArtViewForPaymentInfoType:")]
        BTUIVectorArtView VectorArtViewForPaymentInfoType(string typeString);

        // -(BTUIVectorArtView *)vectorArtViewForPaymentOptionType:(BTUIPaymentOptionType)type;
        [Export("vectorArtViewForPaymentOptionType:")]
        BTUIVectorArtView VectorArtViewForPaymentOptionType(BTUIPaymentOptionType type);

        // +(BTUIPaymentOptionType)paymentOptionTypeForPaymentInfoType:(NSString *)typeString;
        [Static]
        [Export("paymentOptionTypeForPaymentInfoType:")]
        BTUIPaymentOptionType PaymentOptionTypeForPaymentInfoType(string typeString);

        // +(UIActivityIndicatorViewStyle)activityIndicatorViewStyleForBarTintColor:(UIColor *)color;
        [Static]
        [Export("activityIndicatorViewStyleForBarTintColor:")]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyleForBarTintColor(UIColor color);
    }

    // @interface BTUIThemedView : UIView
    [BaseType(typeof(UIView))]
    interface BTUIThemedView
    {
        // @property (nonatomic, strong) BTUI * theme;
        [Export("theme", ArgumentSemantic.Strong)]
        BTUI Theme { get; set; }
    }

    // @interface BTPaymentButton : BTUIThemedView
    [BaseType(typeof(BTUIThemedView))]
    interface BTPaymentButton
    {
        // -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient completion:(void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable))completion;
        [Export("initWithAPIClient:completion:")]
        IntPtr Constructor(BTAPIClient apiClient, Action<BTPaymentMethodNonce, NSError> completion);

        // @property (nonatomic, strong) BTAPIClient * _Nullable apiClient;
        [NullAllowed, Export("apiClient", ArgumentSemantic.Strong)]
        BTAPIClient ApiClient { get; set; }

        // @property (nonatomic, strong) BTPaymentRequest * _Nullable paymentRequest;
        [NullAllowed, Export("paymentRequest", ArgumentSemantic.Strong)]
        BTPaymentRequest PaymentRequest { get; set; }

        // @property (copy, nonatomic) void (^ _Nonnull)(BTPaymentMethodNonce * _Nullable, NSError * _Nullable) completion;
        [Export("completion", ArgumentSemantic.Copy)]
        Action<BTPaymentMethodNonce, NSError> Completion { get; set; }

        // @property (nonatomic, strong) NSOrderedSet<NSString *> * _Nonnull enabledPaymentOptions;
        [Export("enabledPaymentOptions", ArgumentSemantic.Strong)]
        NSOrderedSet<NSString> EnabledPaymentOptions { get; set; }

        // @property (nonatomic, strong) BTConfiguration * _Nullable configuration;
        [NullAllowed, Export("configuration", ArgumentSemantic.Strong)]
        BTConfiguration Configuration { get; set; }

        [Wrap("WeakAppSwitchDelegate")]
        [NullAllowed]
        BTAppSwitchDelegate AppSwitchDelegate { get; set; }

        // @property (nonatomic, weak) id<BTAppSwitchDelegate> _Nullable appSwitchDelegate;
        [NullAllowed, Export("appSwitchDelegate", ArgumentSemantic.Weak)]
        NSObject WeakAppSwitchDelegate { get; set; }

        [Wrap("WeakViewControllerPresentingDelegate")]
        [NullAllowed]
        BTViewControllerPresentingDelegate ViewControllerPresentingDelegate { get; set; }

        // @property (nonatomic, weak) id<BTViewControllerPresentingDelegate> _Nullable viewControllerPresentingDelegate;
        [NullAllowed, Export("viewControllerPresentingDelegate", ArgumentSemantic.Weak)]
        NSObject WeakViewControllerPresentingDelegate { get; set; }

        // @property (readonly, nonatomic) BOOL hasAvailablePaymentMethod;
        [Export("hasAvailablePaymentMethod")]
        bool HasAvailablePaymentMethod { get; }
    }

    // @interface BTUICardFormView : BTUIThemedView
    [BaseType(typeof(BTUIThemedView))]
    interface BTUICardFormView
    {
        [Wrap("WeakDelegate")]
        BTUICardFormViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<BTUICardFormViewDelegate> delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, assign, nonatomic) BOOL valid;
        [Export("valid")]
        bool Valid { get; }

        // @property (copy, nonatomic) NSString * number;
        [Export("number")]
        string Number { get; set; }

        // @property (copy, nonatomic) NSString * cvv;
        [Export("cvv")]
        string Cvv { get; set; }

        // @property (copy, nonatomic) NSString * postalCode;
        [Export("postalCode")]
        string PostalCode { get; set; }

        // @property (readonly, copy, nonatomic) NSString * expirationMonth;
        [Export("expirationMonth")]
        string ExpirationMonth { get; }

        // @property (readonly, copy, nonatomic) NSString * expirationYear;
        [Export("expirationYear")]
        string ExpirationYear { get; }

        // @property (readonly, copy, nonatomic) NSString * phoneNumber;
        [Export("phoneNumber")]
        string PhoneNumber { get; }

        // -(void)setExpirationDate:(NSDate *)expirationDate;
        [Export("setExpirationDate:")]
        void SetExpirationDate(NSDate expirationDate);

        // -(void)setExpirationMonth:(NSInteger)expirationMonth year:(NSInteger)expirationYear;
        [Export("setExpirationMonth:year:")]
        void SetExpirationMonth(nint expirationMonth, nint expirationYear);

        // -(void)showTopLevelError:(NSString *)message;
        [Export("showTopLevelError:")]
        void ShowTopLevelError(string message);

        // -(void)showErrorForField:(BTUICardFormField)field;
        [Export("showErrorForField:")]
        void ShowErrorForField(BTUICardFormField field);

        // @property (assign, nonatomic) BOOL alphaNumericPostalCode;
        [Export("alphaNumericPostalCode")]
        bool AlphaNumericPostalCode { get; set; }

        // @property (assign, nonatomic) BTUICardFormOptionalFields optionalFields;
        [Export("optionalFields", ArgumentSemantic.Assign)]
        BTUICardFormOptionalFields OptionalFields { get; set; }

        // @property (assign, nonatomic) BOOL vibrate;
        [Export("vibrate")]
        bool Vibrate { get; set; }
    }

    // @protocol BTUICardFormViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTUICardFormViewDelegate
    {
        // @optional -(void)cardFormViewDidChange:(BTUICardFormView *)cardFormView;
        [Export("cardFormViewDidChange:")]
        void CardFormViewDidChange(BTUICardFormView cardFormView);

        // @optional -(void)cardFormViewDidBeginEditing:(BTUICardFormView *)cardFormView;
        [Export("cardFormViewDidBeginEditing:")]
        void CardFormViewDidBeginEditing(BTUICardFormView cardFormView);

        // @optional -(void)cardFormViewDidEndEditing:(BTUICardFormView *)cardFormView;
        [Export("cardFormViewDidEndEditing:")]
        void CardFormViewDidEndEditing(BTUICardFormView cardFormView);
    }

    // @interface BTUICardHint : BTUIThemedView
    [BaseType(typeof(BTUIThemedView))]
    interface BTUICardHint
    {
        // @property (assign, nonatomic) BTUIPaymentOptionType cardType;
        [Export("cardType", ArgumentSemantic.Assign)]
        BTUIPaymentOptionType CardType { get; set; }

        // @property (assign, nonatomic) BTCardHintDisplayMode displayMode;
        [Export("displayMode", ArgumentSemantic.Assign)]
        BTCardHintDisplayMode DisplayMode { get; set; }

        // @property (assign, nonatomic) BOOL highlighted;
        [Export("highlighted")]
        bool Highlighted { get; set; }

        // -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
        [Export("setHighlighted:animated:")]
        void SetHighlighted(bool highlighted, bool animated);

        // -(void)setCardType:(BTUIPaymentOptionType)cardType animated:(BOOL)animated;
        [Export("setCardType:animated:")]
        void SetCardType(BTUIPaymentOptionType cardType, bool animated);

        // -(void)setDisplayMode:(BTCardHintDisplayMode)displayMode animated:(BOOL)animated;
        [Export("setDisplayMode:animated:")]
        void SetDisplayMode(BTCardHintDisplayMode displayMode, bool animated);
    }

    // @interface BTUICoinbaseButton : UIControl
    [BaseType(typeof(UIControl))]
    interface BTUICoinbaseButton
    {
        // @property (nonatomic, strong) BTUI * theme;
        [Export("theme", ArgumentSemantic.Strong)]
        BTUI Theme { get; set; }
    }

    // @interface BTUICTAControl : UIControl
    [BaseType(typeof(UIControl))]
    interface BTUICTAControl
    {
        // @property (copy, nonatomic) NSString * _Nullable displayAmount;
        [NullAllowed, Export("displayAmount")]
        string DisplayAmount { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull callToAction;
        [Export("callToAction")]
        string CallToAction { get; set; }

        // -(void)showLoadingState:(BOOL)loadingState;
        [Export("showLoadingState:")]
        void ShowLoadingState(bool loadingState);

        // @property (nonatomic, strong) BTUI * _Nonnull theme;
        [Export("theme", ArgumentSemantic.Strong)]
        BTUI Theme { get; set; }
    }

    // @interface BTUIPaymentMethodView : BTUIThemedView
    [BaseType(typeof(BTUIThemedView))]
    interface BTUIPaymentMethodView
    {
        // @property (assign, nonatomic) BTUIPaymentOptionType type;
        [Export("type", ArgumentSemantic.Assign)]
        BTUIPaymentOptionType Type { get; set; }

        // @property (copy, nonatomic) NSString * detailDescription;
        [Export("detailDescription")]
        string DetailDescription { get; set; }

        // @property (getter = isProcessing, assign, nonatomic) BOOL processing;
        [Export("processing")]
        bool Processing { [Bind("isProcessing")] get; set; }
    }

    // @interface BTUIPayPalButton : UIControl
    [BaseType(typeof(UIControl))]
    interface BTUIPayPalButton
    {
        // @property (nonatomic, strong) BTUI * theme;
        [Export("theme", ArgumentSemantic.Strong)]
        BTUI Theme { get; set; }

        // @property (nonatomic, strong) BTUIPayPalWordmarkVectorArtView * payPalWordmark;
        [Export("payPalWordmark", ArgumentSemantic.Strong)]
        BTUIPayPalWordmarkVectorArtView PayPalWordmark { get; set; }
    }

    // @interface BTUISummaryView : BTUIThemedView
    [BaseType(typeof(BTUIThemedView))]
    interface BTUISummaryView
    {
        // @property (copy, nonatomic) NSString * slug;
        [Export("slug")]
        string Slug { get; set; }

        // @property (copy, nonatomic) NSString * summary;
        [Export("summary")]
        string Summary { get; set; }

        // @property (copy, nonatomic) NSString * amount;
        [Export("amount")]
        string Amount { get; set; }
    }

    // @interface BTUIVenmoButton : UIControl
    [BaseType(typeof(UIControl))]
    interface BTUIVenmoButton
    {
        // @property (nonatomic, strong) BTUI * theme;
        [Export("theme", ArgumentSemantic.Strong)]
        BTUI Theme { get; set; }
    }

    // @interface BTUI (UIColor)
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_BTUI
    {
        // +(instancetype)bt_colorWithBytesR:(NSInteger)r G:(NSInteger)g B:(NSInteger)b A:(NSInteger)a;
        [Static]
        [Export("bt_colorWithBytesR:G:B:A:")]
        UIColor Bt_colorWithBytesR(nint r, nint g, nint b, nint a);

        // +(instancetype)bt_colorWithBytesR:(NSInteger)r G:(NSInteger)g B:(NSInteger)b;
        [Static]
        [Export("bt_colorWithBytesR:G:B:")]
        UIColor Bt_colorWithBytesR(nint r, nint g, nint b);

        // +(instancetype)bt_colorFromHex:(NSString *)hex alpha:(CGFloat)alpha;
        [Static]
        [Export("bt_colorFromHex:alpha:")]
        UIColor Bt_colorFromHex(string hex, nfloat alpha);

        // -(instancetype)bt_adjustedBrightness:(CGFloat)adjustment;
        [Static, Export("bt_adjustedBrightness:")]
        UIColor Bt_adjustedBrightness(nfloat adjustment);
    }

    // @interface BTUIPayPalWordmarkVectorArtView : BTUIVectorArtView
    [BaseType(typeof(BTUIVectorArtView))]
    interface BTUIPayPalWordmarkVectorArtView
    {
        // @property (nonatomic, strong) BTUI * theme;
        [Export("theme", ArgumentSemantic.Strong)]
        BTUI Theme { get; set; }
    }
}
