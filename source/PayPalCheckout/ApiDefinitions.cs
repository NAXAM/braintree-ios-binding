using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using PayPalCheckout;
using UIKit;

namespace PayPalCheckout
{
	// @interface AccessibilityCloseButton : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout24AccessibilityCloseButton")]
	interface AccessibilityCloseButton
	{
	}

	// @interface AddCardView : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout11AddCardView")]
	interface AddCardView
	{
	}

	// @interface AmountView : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout10AmountView")]
	interface AmountView
	{
	}

	// @interface PPCApproval : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCApproval
	{
		// @property (readonly, nonatomic, strong) PPCApprovalData * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		PPCApprovalData Data { get; }

		// @property (readonly, nonatomic, strong) PPCApprovalActions * _Nonnull actions;
		[Export ("actions", ArgumentSemantic.Strong)]
		PPCApprovalActions Actions { get; }
	}

	// @interface PPCApprovalActions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCApprovalActions
	{
		// -(void)captureOnComplete:(void (^ _Nonnull)(PPCCaptureActionSuccess * _Nullable, NSError * _Nullable))onComplete;
		[Export ("captureOnComplete:")]
		void CaptureOnComplete (Action<PPCCaptureActionSuccess, NSError> onComplete);

		// -(void)authorizeOnComplete:(void (^ _Nonnull)(PPCAuthorizeActionSuccess * _Nullable, NSError * _Nullable))onComplete;
		[Export ("authorizeOnComplete:")]
		void AuthorizeOnComplete (Action<PPCAuthorizeActionSuccess, NSError> onComplete);

		// -(void)patchWithRequest:(PPCPatchRequest * _Nonnull)request onComplete:(void (^ _Nonnull)(PPCPatchActionSuccess * _Nullable, NSError * _Nullable))onComplete;
		[Export ("patchWithRequest:onComplete:")]
		void PatchWithRequest (PPCPatchRequest request, Action<PPCPatchActionSuccess, NSError> onComplete);

		// -(void)executeBillingAgreementOnComplete:(void (^ _Nonnull)(PPCBillingActionData * _Nullable, NSError * _Nullable))onComplete;
		[Export ("executeBillingAgreementOnComplete:")]
		void ExecuteBillingAgreementOnComplete (Action<PPCBillingActionData, NSError> onComplete);
	}

	// @interface PPCApprovalData : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCApprovalData
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull payerID;
		[Export ("payerID")]
		string PayerID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull ecToken;
		[Export ("ecToken")]
		string EcToken { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable billingToken;
		[NullAllowed, Export ("billingToken")]
		string BillingToken { get; }

		// @property (readonly, nonatomic) enum PPCApprovalOrderIntent intent;
		[Export ("intent")]
		PPCApprovalOrderIntent Intent { get; }

		// @property (readonly, copy, nonatomic) NSUrl * _Nullable returnURL;
		[NullAllowed, Export ("returnURL", ArgumentSemantic.Copy)]
		NSUrl ReturnURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable paymentID;
		[NullAllowed, Export ("paymentID")]
		string PaymentID { get; }

		// @property (readonly, nonatomic, strong) PPCVaultData * _Nullable vaultData;
		[NullAllowed, Export ("vaultData", ArgumentSemantic.Strong)]
		PPCVaultData VaultData { get; }

		// @property (readonly, nonatomic, strong) PPCCorrelationIDs * _Nonnull correlationIDs;
		[Export ("correlationIDs", ArgumentSemantic.Strong)]
		PPCCorrelationIDs CorrelationIDs { get; }
	}

	// @interface AspectRatioImageView : UIImageView
	[BaseType (typeof(UIImageView), Name = "_TtC14PayPalCheckout20AspectRatioImageView")]
	interface AspectRatioImageView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface PPCAuthorizeActionSuccess : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCAuthorizeActionSuccess
	{
		// @property (readonly, nonatomic, strong) PPCOrderActionData * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		PPCOrderActionData Data { get; }
	}

	// @interface BackAction : UIButton
	[BaseType (typeof(UIButton), Name = "_TtC14PayPalCheckout10BackAction")]
	[DisableDefaultCtor]
	interface BackAction
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface Background : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout10Background")]
	interface Background
	{
		// -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("hitTest:withEvent:")]
		[return: NullAllowed]
		UIView HitTest (CGPoint point, [NullAllowed] UIEvent @event);
	}

	// @interface PPCBillingActionData : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCBillingActionData
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull billingId;
		[Export ("billingId")]
		string BillingId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull state;
		[Export ("state")]
		string State { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull billingData;
		[Export ("billingData", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> BillingData { get; }
	}

	// @interface BrandedBackgroundView : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout21BrandedBackgroundView")]
	interface BrandedBackgroundView
	{
	}

	// @interface PPCCaptureActionSuccess : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCCaptureActionSuccess
	{
		// @property (readonly, nonatomic, strong) PPCOrderActionData * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		PPCOrderActionData Data { get; }
	}

	// @interface CarouselCell : UICollectionViewCell
	[BaseType (typeof(UICollectionViewCell), Name = "_TtC14PayPalCheckout12CarouselCell")]
	interface CarouselCell
	{
		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export ("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse ();

		// -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("hitTest:withEvent:")]
		[return: NullAllowed]
		UIView HitTest (CGPoint point, [NullAllowed] UIEvent @event);
	}

	// @interface CarouselView : UIView <UICollectionViewDelegate>
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout12CarouselView")]
	interface CarouselView : IUICollectionViewDelegate
	{
		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)collectionView:(UICollectionView * _Nonnull)collectionView didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("collectionView:didSelectItemAtIndexPath:")]
		void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

		// -(void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
		[Export ("scrollViewDidScroll:")]
		void ScrollViewDidScroll (UIScrollView scrollView);

		// -(void)scrollViewDidEndScrollingAnimation:(UIScrollView * _Nonnull)scrollView;
		[Export ("scrollViewDidEndScrollingAnimation:")]
		void ScrollViewDidEndScrollingAnimation (UIScrollView scrollView);
	}

	// @interface CartDetailsView : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout15CartDetailsView")]
	interface CartDetailsView
	{
	}

	// @interface PPCheckout : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCheckout
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull sdkVersion;
		[Static]
		[Export ("sdkVersion")]
		string SdkVersion { get; }

		// @property (readonly, nonatomic, class) enum PPCUserAction userAction;
		[Static]
		[Export ("userAction")]
		PPCUserAction UserAction { get; }

		// @property (nonatomic, class) BOOL showsExitAlert;
		[Static]
		[Export ("showsExitAlert")]
		bool ShowsExitAlert { get; set; }

		// @property (nonatomic, class) BOOL showsExitSurvey;
		[Static]
		[Export ("showsExitSurvey")]
		bool ShowsExitSurvey { get; set; }

		// +(void)setCreateOrderCallback:(void (^ _Nonnull)(PPCCreateOrderAction * _Nonnull))createOrder;
		[Static]
		[Export ("setCreateOrderCallback:")]
		void SetCreateOrderCallback (Action<PPCCreateOrderAction> createOrder);

		// +(void)setOnApproveCallback:(void (^ _Nonnull)(PPCApproval * _Nonnull))onApprove;
		[Static]
		[Export ("setOnApproveCallback:")]
		void SetOnApproveCallback (Action<PPCApproval> onApprove);

		// +(void)setOnShippingChangeCallback:(void (^ _Nonnull)(PPCShippingChange * _Nonnull, PPCShippingChangeAction * _Nonnull))onShippingChange;
		[Static]
		[Export ("setOnShippingChangeCallback:")]
		void SetOnShippingChangeCallback (Action<PPCShippingChange, PPCShippingChangeAction> onShippingChange);

		// +(void)setOnCancelCallback:(void (^ _Nonnull)(void))onCancel;
		[Static]
		[Export ("setOnCancelCallback:")]
		void SetOnCancelCallback (Action onCancel);

		// +(void)setOnErrorCallback:(void (^ _Nonnull)(PPCErrorInfo * _Nonnull))onError;
		[Static]
		[Export ("setOnErrorCallback:")]
		void SetOnErrorCallback (Action<PPCErrorInfo> onError);

		// +(void)setConfig:(PPCheckoutConfig * _Nonnull)config;
		[Static]
		[Export ("setConfig:")]
		void SetConfig (PPCheckoutConfig config);

		// +(void)setCurrencyCode:(enum PPCCurrencyCode)currency;
		[Static]
		[Export ("setCurrencyCode:")]
		void SetCurrencyCode (PPCCurrencyCode currency);

		// +(void)startWithPresentingViewController:(UIViewController * _Nullable)presentingViewController createOrder:(void (^ _Nullable)(PPCCreateOrderAction * _Nonnull))createOrder onApprove:(void (^ _Nullable)(PPCApproval * _Nonnull))onApprove onShippingChange:(void (^ _Nullable)(PPCShippingChange * _Nonnull, PPCShippingChangeAction * _Nonnull))onShippingChange onCancel:(void (^ _Nullable)(void))onCancel onError:(void (^ _Nullable)(PPCErrorInfo * _Nonnull))onError;
		[Static]
		[Export ("startWithPresentingViewController:createOrder:onApprove:onShippingChange:onCancel:onError:")]
		void StartWithPresentingViewController ([NullAllowed] UIViewController presentingViewController, [NullAllowed] Action<PPCCreateOrderAction> createOrder, [NullAllowed] Action<PPCApproval> onApprove, [NullAllowed] Action<PPCShippingChange, PPCShippingChangeAction> onShippingChange, [NullAllowed] Action onCancel, [NullAllowed] Action<PPCErrorInfo> onError);
	}

	delegate void Callback3(NSString message, Callback1 callback);
	delegate void Callback1(NSString message, NSError error);
	delegate void Callback2(Callback1 callback);

    // @interface PPCheckoutConfig : NSObject <NSCopying>
    [BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCheckoutConfig : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nonnull clientID;
		[Export ("clientID")]
		string ClientID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable payToken;
		[NullAllowed, Export ("payToken")]
		string PayToken { get; set; }

		// @property (nonatomic) enum PPCUserAction userAction;
		[Export ("userAction", ArgumentSemantic.Assign)]
		PPCUserAction UserAction { get; set; }

		// @property (nonatomic) enum PPCEnvironment environment;
		[Export ("environment", ArgumentSemantic.Assign)]
		PPCEnvironment Environment { get; set; }

		// @property (nonatomic, strong) EnvironmentConfig * _Nonnull environmentConfig;
		[Export ("environmentConfig", ArgumentSemantic.Strong)]
		EnvironmentConfig EnvironmentConfig { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable)) onAuthenticate;
		[NullAllowed, Export ("onAuthenticate", ArgumentSemantic.Copy)]
        Callback2 OnAuthenticate { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(NSString * _Nullable, void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable)) onAuthStepUp;
		[NullAllowed, Export ("onAuthStepUp", ArgumentSemantic.Copy)]
        Callback3 OnAuthStepUp { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(PPCCreateOrderAction * _Nonnull) createOrder;
		[NullAllowed, Export ("createOrder", ArgumentSemantic.Copy)]
		Action<PPCCreateOrderAction> CreateOrder { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(PPCApproval * _Nonnull) onApprove;
		[NullAllowed, Export ("onApprove", ArgumentSemantic.Copy)]
		Action<PPCApproval> OnApprove { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onCancel;
		[NullAllowed, Export ("onCancel", ArgumentSemantic.Copy)]
		Action OnCancel { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(PPCErrorInfo * _Nonnull) onError;
		[NullAllowed, Export ("onError", ArgumentSemantic.Copy)]
		Action<PPCErrorInfo> OnError { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onLogout;
		[NullAllowed, Export ("onLogout", ArgumentSemantic.Copy)]
		Action OnLogout { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(PPCShippingChange * _Nonnull, PPCShippingChangeAction * _Nonnull) onShippingChange;
		[NullAllowed, Export ("onShippingChange", ArgumentSemantic.Copy)]
		Action<PPCShippingChange, PPCShippingChangeAction> OnShippingChange { get; set; }

		// @property (nonatomic, strong) UIViewController * _Nullable presentingViewController;
		[NullAllowed, Export ("presentingViewController", ArgumentSemantic.Strong)]
		UIViewController PresentingViewController { get; set; }

		// @property (nonatomic) BOOL debugEnabled;
		[Export ("debugEnabled")]
		bool DebugEnabled { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable merchantIDs;
		[NullAllowed, Export ("merchantIDs", ArgumentSemantic.Copy)]
		string[] MerchantIDs { get; set; }

		// -(instancetype _Nonnull)initWithClientID:(NSString * _Nonnull)clientID createOrder:(void (^ _Nullable)(PPCCreateOrderAction * _Nonnull))createOrder onApprove:(void (^ _Nullable)(PPCApproval * _Nonnull))onApprove onShippingChange:(void (^ _Nullable)(PPCShippingChange * _Nonnull, PPCShippingChangeAction * _Nonnull))onShippingChange onCancel:(void (^ _Nullable)(void))onCancel onError:(void (^ _Nullable)(PPCErrorInfo * _Nonnull))onError environment:(enum PPCEnvironment)environment __attribute__((objc_designated_initializer));
		[Export ("initWithClientID:createOrder:onApprove:onShippingChange:onCancel:onError:environment:")]
		[DesignatedInitializer]
		IntPtr Constructor (string clientID, [NullAllowed] Action<PPCCreateOrderAction> createOrder, [NullAllowed] Action<PPCApproval> onApprove, [NullAllowed] Action<PPCShippingChange, PPCShippingChangeAction> onShippingChange, [NullAllowed] Action onCancel, [NullAllowed] Action<PPCErrorInfo> onError, PPCEnvironment environment);

		// -(instancetype _Nonnull)initWithClientID:(NSString * _Nonnull)clientID returnUrl:(NSString * _Nonnull)returnUrl createOrder:(void (^ _Nullable)(PPCCreateOrderAction * _Nonnull))createOrder onApprove:(void (^ _Nullable)(PPCApproval * _Nonnull))onApprove onShippingChange:(void (^ _Nullable)(PPCShippingChange * _Nonnull, PPCShippingChangeAction * _Nonnull))onShippingChange onCancel:(void (^ _Nullable)(void))onCancel onError:(void (^ _Nullable)(PPCErrorInfo * _Nonnull))onError environment:(enum PPCEnvironment)environment __attribute__((deprecated("`init(clientID:returnUrl: ...)` has been deprecated and will be removed in a future version of the SDK. Use `init(clientID: ...)` instead")));
		[Export ("initWithClientID:returnUrl:createOrder:onApprove:onShippingChange:onCancel:onError:environment:")]
		IntPtr Constructor (string clientID, string returnUrl, [NullAllowed] Action<PPCCreateOrderAction> createOrder, [NullAllowed] Action<PPCApproval> onApprove, [NullAllowed] Action<PPCShippingChange, PPCShippingChangeAction> onShippingChange, [NullAllowed] Action onCancel, [NullAllowed] Action<PPCErrorInfo> onError, PPCEnvironment environment);

		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @interface PPCCorrelationIDs : NSObject
	[BaseType (typeof(NSObject))]
	interface PPCCorrelationIDs
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable fundingEligibilityDebugID;
		[NullAllowed, Export ("fundingEligibilityDebugID")]
		string FundingEligibilityDebugID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable eligibilityDebugID;
		[NullAllowed, Export ("eligibilityDebugID")]
		string EligibilityDebugID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable updateClientConfigDebugID;
		[NullAllowed, Export ("updateClientConfigDebugID")]
		string UpdateClientConfigDebugID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lsatUpgradeDebugID;
		[NullAllowed, Export ("lsatUpgradeDebugID")]
		string LsatUpgradeDebugID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fetchPayloadDebugID;
		[NullAllowed, Export ("fetchPayloadDebugID")]
		string FetchPayloadDebugID { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull fetchCartDebugIDs;
		[Export ("fetchCartDebugIDs", ArgumentSemantic.Copy)]
		string[] FetchCartDebugIDs { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable currencyConversionDebugID;
		[NullAllowed, Export ("currencyConversionDebugID")]
		string CurrencyConversionDebugID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable completeSCADebugID;
		[NullAllowed, Export ("completeSCADebugID")]
		string CompleteSCADebugID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable finishCheckoutDebugID;
		[NullAllowed, Export ("finishCheckoutDebugID")]
		string FinishCheckoutDebugID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable riskCorrelationID;
		[NullAllowed, Export ("riskCorrelationID")]
		string RiskCorrelationID { get; }

		// @property (readonly, nonatomic, strong) PPCSessionIDs * _Nonnull sessionIDs;
		[Export ("sessionIDs", ArgumentSemantic.Strong)]
		PPCSessionIDs SessionIDs { get; }
	}

	// @interface PPCCreateOrderAction : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCCreateOrderAction
	{
		// -(void)createWithOrder:(PPCOrderRequest * _Nonnull)order completion:(void (^ _Nonnull)(NSString * _Nullable))completion;
		[Export ("createWithOrder:completion:")]
		void CreateWithOrder (PPCOrderRequest order, Action<NSString> completion);

		// -(void)setWithOrderId:(NSString * _Nonnull)orderId;
		[Export ("setWithOrderId:")]
		void SetWithOrderId (string orderId);

		// -(void)setWithBillingAgreementToken:(NSString * _Nonnull)billingAgreementToken;
		[Export ("setWithBillingAgreementToken:")]
		void SetWithBillingAgreementToken (string billingAgreementToken);

		// -(void)setWithVaultApprovalSessionID:(NSString * _Nonnull)vaultApprovalSessionID;
		[Export ("setWithVaultApprovalSessionID:")]
		void SetWithVaultApprovalSessionID (string vaultApprovalSessionID);

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();
	}

	// @interface UnconstrainedTextLabel : UILabel
	[BaseType (typeof(UILabel), Name = "_TtC14PayPalCheckout22UnconstrainedTextLabel")]
	interface UnconstrainedTextLabel
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface DeliverySelectionHeaderView : UnconstrainedTextLabel
	[BaseType (typeof(UnconstrainedTextLabel), Name = "_TtC14PayPalCheckout27DeliverySelectionHeaderView")]
	interface DeliverySelectionHeaderView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface DeliveryView : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout12DeliveryView")]
	interface DeliveryView
	{
	}

	// @interface EnvironmentConfig : NSObject <NSCopying>
	[BaseType (typeof(NSObject), Name = "_TtC14PayPalCheckout17EnvironmentConfig")]
	interface EnvironmentConfig : INSCopying
	{
		// @property (nonatomic) BOOL checksEligibility;
		[Export ("checksEligibility")]
		bool ChecksEligibility { get; set; }

		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @interface PPCErrorInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCErrorInfo
	{
		// @property (readonly, nonatomic) NSError * _Nonnull error;
		[Export ("error")]
		NSError Error { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull reason;
		[Export ("reason")]
		string Reason { get; }

		// @property (readonly, nonatomic, strong) PPCCorrelationIDs * _Nonnull correlationIDs;
		[Export ("correlationIDs", ArgumentSemantic.Strong)]
		PPCCorrelationIDs CorrelationIDs { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull payToken;
		[Export ("payToken")]
		string PayToken { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull nativeSdkVersion;
		[Export ("nativeSdkVersion")]
		string NativeSdkVersion { get; }
	}

	// @interface ExtendedCheckoutConfig : PPCheckoutConfig
	[BaseType (typeof(PPCheckoutConfig), Name = "_TtC14PayPalCheckout22ExtendedCheckoutConfig")]
	interface ExtendedCheckoutConfig
	{
		// @property (copy, nonatomic) NSString * _Nullable sessionUID;
		[NullAllowed, Export ("sessionUID")]
		string SessionUID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable buttonSessionID;
		[NullAllowed, Export ("buttonSessionID")]
		string ButtonSessionID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable stickinessID;
		[NullAllowed, Export ("stickinessID")]
		string StickinessID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable pageUrl;
		[NullAllowed, Export ("pageUrl")]
		string PageUrl { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable facilitatorClientID;
		[NullAllowed, Export ("facilitatorClientID")]
		string FacilitatorClientID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull enableFunding;
		[Export ("enableFunding", ArgumentSemantic.Copy)]
		string[] EnableFunding { get; set; }

		// @property (nonatomic) enum PPCChannel channel;
		[Export ("channel", ArgumentSemantic.Assign)]
		PPCChannel Channel { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable appGuid;
		[NullAllowed, Export ("appGuid")]
		string AppGuid { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable deviceId;
		[NullAllowed, Export ("deviceId")]
		string DeviceId { get; set; }

		// @property (nonatomic) BOOL skipsShippingAddressContingency;
		[Export ("skipsShippingAddressContingency")]
		bool SkipsShippingAddressContingency { get; set; }

		// @property (nonatomic) BOOL supportsBillingAgreements;
		[Export ("supportsBillingAgreements")]
		bool SupportsBillingAgreements { get; set; }

		// @property (nonatomic) BOOL supportsWebFallbacks;
		[Export ("supportsWebFallbacks")]
		bool SupportsWebFallbacks { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable elmoExperimentsToSkip;
		[NullAllowed, Export ("elmoExperimentsToSkip", ArgumentSemantic.Copy)]
		string[] ElmoExperimentsToSkip { get; set; }

		// @property (readonly, nonatomic) BOOL usesFirebase;
		[Export ("usesFirebase")]
		bool UsesFirebase { get; }

		// @property (copy, nonatomic) void (^ _Nullable)(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable)) onAddCardStepUp;
		[NullAllowed, Export ("onAddCardStepUp", ArgumentSemantic.Copy)]
		Callback2 OnAddCardStepUp { get; set; }
	}

	// @interface Legalese : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout8Legalese")]
	interface Legalese
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface LineItemContainerView : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout21LineItemContainerView")]
	interface LineItemContainerView
	{
	}

	// @interface LogoImageView : UIImageView
	[BaseType (typeof(UIImageView), Name = "_TtC14PayPalCheckout13LogoImageView")]
	interface LogoImageView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image __attribute__((objc_designated_initializer));
		[Export ("initWithImage:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIImage image);

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image highlightedImage:(UIImage * _Nullable)highlightedImage __attribute__((objc_designated_initializer));
		[Export ("initWithImage:highlightedImage:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] UIImage image, [NullAllowed] UIImage highlightedImage);
	}

	// @interface PPCOrderActionData : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderActionData
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull status;
		[Export ("status")]
		string Status { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull orderData;
		[Export ("orderData", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> OrderData { get; }
	}

	// @interface PPCOrderAddress : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderAddress
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable addressLine1;
		[NullAllowed, Export ("addressLine1")]
		string AddressLine1 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable addressLine2;
		[NullAllowed, Export ("addressLine2")]
		string AddressLine2 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable adminArea1;
		[NullAllowed, Export ("adminArea1")]
		string AdminArea1 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable adminArea2;
		[NullAllowed, Export ("adminArea2")]
		string AdminArea2 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull countryCode;
		[Export ("countryCode")]
		string CountryCode { get; }

		// -(instancetype _Nonnull)initWithCountryCode:(NSString * _Nonnull)countryCode addressLine1:(NSString * _Nullable)addressLine1 addressLine2:(NSString * _Nullable)addressLine2 adminArea1:(NSString * _Nullable)adminArea1 adminArea2:(NSString * _Nullable)adminArea2 postalCode:(NSString * _Nullable)postalCode __attribute__((objc_designated_initializer));
		[Export ("initWithCountryCode:addressLine1:addressLine2:adminArea1:adminArea2:postalCode:")]
		[DesignatedInitializer]
		IntPtr Constructor (string countryCode, [NullAllowed] string addressLine1, [NullAllowed] string addressLine2, [NullAllowed] string adminArea1, [NullAllowed] string adminArea2, [NullAllowed] string postalCode);
	}

	// @interface PPCOrderApplicationContext : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderApplicationContext
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable brandName;
		[NullAllowed, Export ("brandName")]
		string BrandName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable locale;
		[NullAllowed, Export ("locale")]
		string Locale { get; }

		// @property (readonly, nonatomic) enum PPCOrderApplicationContextShippingPreference shippingPreference;
		[Export ("shippingPreference")]
		PPCOrderApplicationContextShippingPreference ShippingPreference { get; }

		// @property (readonly, nonatomic) enum PPCOrderApplicationContextUserAction userAction;
		[Export ("userAction")]
		PPCOrderApplicationContextUserAction UserAction { get; }

		// @property (readonly, nonatomic, strong) PPCOrderApplicationContextPaymentMethod * _Nullable paymentMethod;
		[NullAllowed, Export ("paymentMethod", ArgumentSemantic.Strong)]
		PPCOrderApplicationContextPaymentMethod PaymentMethod { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable returnUrl;
		[NullAllowed, Export ("returnUrl")]
		string ReturnUrl { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable cancelUrl;
		[NullAllowed, Export ("cancelUrl")]
		string CancelUrl { get; }

		// @property (readonly, nonatomic, strong) PPCOrderApplicationContextStoredPaymentSource * _Nullable storedPaymentSource;
		[NullAllowed, Export ("storedPaymentSource", ArgumentSemantic.Strong)]
		PPCOrderApplicationContextStoredPaymentSource StoredPaymentSource { get; }

		// -(instancetype _Nonnull)initWithBrandName:(NSString * _Nullable)brandName locale:(NSString * _Nullable)locale shippingPreference:(enum PPCOrderApplicationContextShippingPreference)shippingPreference userAction:(enum PPCOrderApplicationContextUserAction)userAction paymentMethod:(PPCOrderApplicationContextPaymentMethod * _Nullable)paymentMethod returnUrl:(NSString * _Nullable)returnUrl cancelUrl:(NSString * _Nullable)cancelUrl storedPaymentSource:(PPCOrderApplicationContextStoredPaymentSource * _Nullable)storedPaymentSource __attribute__((objc_designated_initializer));
		[Export ("initWithBrandName:locale:shippingPreference:userAction:paymentMethod:returnUrl:cancelUrl:storedPaymentSource:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string brandName, [NullAllowed] string locale, PPCOrderApplicationContextShippingPreference shippingPreference, PPCOrderApplicationContextUserAction userAction, [NullAllowed] PPCOrderApplicationContextPaymentMethod paymentMethod, [NullAllowed] string returnUrl, [NullAllowed] string cancelUrl, [NullAllowed] PPCOrderApplicationContextStoredPaymentSource storedPaymentSource);
	}

	// @interface PPCOrderApplicationContextPaymentMethod : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderApplicationContextPaymentMethod
	{
		// @property (readonly, nonatomic) enum PPCOrderApplicationContextPayerSelected payerSelected;
		[Export ("payerSelected")]
		PPCOrderApplicationContextPayerSelected PayerSelected { get; }

		// @property (readonly, nonatomic) enum PPCOrderApplicationContextPayeePreferred payeePreferred;
		[Export ("payeePreferred")]
		PPCOrderApplicationContextPayeePreferred PayeePreferred { get; }

		// @property (readonly, nonatomic) enum PPCOrderApplicationContextStandardEntryClassCode standardEntryClassCode;
		[Export ("standardEntryClassCode")]
		PPCOrderApplicationContextStandardEntryClassCode StandardEntryClassCode { get; }

		// -(instancetype _Nonnull)initWithPayerSelected:(enum PPCOrderApplicationContextPayerSelected)payerSelected payeePreferred:(enum PPCOrderApplicationContextPayeePreferred)payeePreferred standardEntryClassCode:(enum PPCOrderApplicationContextStandardEntryClassCode)standardEntryClassCode __attribute__((objc_designated_initializer));
		[Export ("initWithPayerSelected:payeePreferred:standardEntryClassCode:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCOrderApplicationContextPayerSelected payerSelected, PPCOrderApplicationContextPayeePreferred payeePreferred, PPCOrderApplicationContextStandardEntryClassCode standardEntryClassCode);
	}

	// @interface PPCOrderApplicationContextStoredPaymentSource : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderApplicationContextStoredPaymentSource
	{
		// @property (readonly, nonatomic) enum PPCOrderApplicationContextPaymentInitiator paymentInitiator;
		[Export ("paymentInitiator")]
		PPCOrderApplicationContextPaymentInitiator PaymentInitiator { get; }

		// @property (readonly, nonatomic) enum PPCOrderApplicationContextPaymentType paymentType;
		[Export ("paymentType")]
		PPCOrderApplicationContextPaymentType PaymentType { get; }

		// @property (readonly, nonatomic) enum PPCOrderApplicationContextUsage usage;
		[Export ("usage")]
		PPCOrderApplicationContextUsage Usage { get; }

		// @property (readonly, nonatomic, strong) PPCOrderApplicationContextPreviousNetworkTransactionReference * _Nullable previousNetworkTransactionReference;
		[NullAllowed, Export ("previousNetworkTransactionReference", ArgumentSemantic.Strong)]
		PPCOrderApplicationContextPreviousNetworkTransactionReference PreviousNetworkTransactionReference { get; }

		// -(instancetype _Nonnull)initWithPaymentInitiator:(enum PPCOrderApplicationContextPaymentInitiator)paymentInitiator paymentType:(enum PPCOrderApplicationContextPaymentType)paymentType usage:(enum PPCOrderApplicationContextUsage)usage previousNetworkTransactionReference:(PPCOrderApplicationContextPreviousNetworkTransactionReference * _Nullable)previousNetworkTransactionReference __attribute__((objc_designated_initializer));
		[Export ("initWithPaymentInitiator:paymentType:usage:previousNetworkTransactionReference:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCOrderApplicationContextPaymentInitiator paymentInitiator, PPCOrderApplicationContextPaymentType paymentType, PPCOrderApplicationContextUsage usage, [NullAllowed] PPCOrderApplicationContextPreviousNetworkTransactionReference previousNetworkTransactionReference);
	}

	// @interface PPCOrderApplicationContextPreviousNetworkTransactionReference : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderApplicationContextPreviousNetworkTransactionReference
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable date;
		[NullAllowed, Export ("date")]
		string Date { get; }

		// @property (readonly, nonatomic) enum PPCOrderApplicationContextNetwork network;
		[Export ("network")]
		PPCOrderApplicationContextNetwork Network { get; }

		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id network:(enum PPCOrderApplicationContextNetwork)network date:(NSString * _Nullable)date __attribute__((objc_designated_initializer));
		[Export ("initWithId:network:date:")]
		[DesignatedInitializer]
		IntPtr Constructor (string id, PPCOrderApplicationContextNetwork network, [NullAllowed] string date);
	}

	// @interface PPCOrderPayer : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderPayer
	{
		// @property (readonly, nonatomic, strong) PPCOrderPayerName * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		PPCOrderPayerName Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable emailAddress;
		[NullAllowed, Export ("emailAddress")]
		string EmailAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable payerId;
		[NullAllowed, Export ("payerId")]
		string PayerId { get; }

		// @property (readonly, nonatomic, strong) PPCOrderPayerPhone * _Nullable phone;
		[NullAllowed, Export ("phone", ArgumentSemantic.Strong)]
		PPCOrderPayerPhone Phone { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable birthDate;
		[NullAllowed, Export ("birthDate")]
		string BirthDate { get; }

		// @property (readonly, nonatomic, strong) PPCOrderPayerTaxInfo * _Nullable taxInfo;
		[NullAllowed, Export ("taxInfo", ArgumentSemantic.Strong)]
		PPCOrderPayerTaxInfo TaxInfo { get; }

		// @property (readonly, nonatomic, strong) PPCOrderAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		PPCOrderAddress Address { get; }

		// -(instancetype _Nonnull)initWithName:(PPCOrderPayerName * _Nullable)name emailAddress:(NSString * _Nullable)emailAddress payerId:(NSString * _Nullable)payerId phone:(PPCOrderPayerPhone * _Nullable)phone birthDate:(NSString * _Nullable)birthDate taxInfo:(PPCOrderPayerTaxInfo * _Nullable)taxInfo address:(PPCOrderAddress * _Nullable)address __attribute__((objc_designated_initializer));
		[Export ("initWithName:emailAddress:payerId:phone:birthDate:taxInfo:address:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] PPCOrderPayerName name, [NullAllowed] string emailAddress, [NullAllowed] string payerId, [NullAllowed] PPCOrderPayerPhone phone, [NullAllowed] string birthDate, [NullAllowed] PPCOrderPayerTaxInfo taxInfo, [NullAllowed] PPCOrderAddress address);
	}

	// @interface PPCOrderPayerName : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderPayerName
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable givenName;
		[NullAllowed, Export ("givenName")]
		string GivenName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable surname;
		[NullAllowed, Export ("surname")]
		string Surname { get; }

		// -(instancetype _Nonnull)initGivenName:(NSString * _Nullable)givenName surname:(NSString * _Nullable)surname __attribute__((objc_designated_initializer));
		[Export ("initGivenName:surname:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string givenName, [NullAllowed] string surname);
	}

	// @interface PPCOrderPayerPhone : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderPayerPhone
	{
		// @property (readonly, nonatomic) enum PPCOrderPayerPhoneType phoneType;
		[Export ("phoneType")]
		PPCOrderPayerPhoneType PhoneType { get; }

		// @property (readonly, nonatomic, strong) PPCOrderPayerPhoneNumber * _Nonnull phoneNumber;
		[Export ("phoneNumber", ArgumentSemantic.Strong)]
		PPCOrderPayerPhoneNumber PhoneNumber { get; }

		// -(instancetype _Nonnull)initWithPhoneNumber:(PPCOrderPayerPhoneNumber * _Nonnull)phoneNumber phoneType:(enum PPCOrderPayerPhoneType)phoneType __attribute__((objc_designated_initializer));
		[Export ("initWithPhoneNumber:phoneType:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCOrderPayerPhoneNumber phoneNumber, PPCOrderPayerPhoneType phoneType);
	}

	// @interface PPCOrderPayerPhoneNumber : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderPayerPhoneNumber
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull nationalNumber;
		[Export ("nationalNumber")]
		string NationalNumber { get; }

		// -(instancetype _Nonnull)initWithNationalNumber:(NSString * _Nonnull)nationalNumber __attribute__((objc_designated_initializer));
		[Export ("initWithNationalNumber:")]
		[DesignatedInitializer]
		IntPtr Constructor (string nationalNumber);
	}

	// @interface PPCOrderPayerTaxInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderPayerTaxInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull taxId;
		[Export ("taxId")]
		string TaxId { get; }

		// @property (readonly, nonatomic) enum PPCOrderPayerTaxIdType taxIdType;
		[Export ("taxIdType")]
		PPCOrderPayerTaxIdType TaxIdType { get; }

		// -(instancetype _Nonnull)initWithTaxId:(NSString * _Nonnull)taxId taxIdType:(enum PPCOrderPayerTaxIdType)taxIdType __attribute__((objc_designated_initializer));
		[Export ("initWithTaxId:taxIdType:")]
		[DesignatedInitializer]
		IntPtr Constructor (string taxId, PPCOrderPayerTaxIdType taxIdType);
	}

	// @interface PPCOrderRequest : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCOrderRequest
	{
		// @property (readonly, nonatomic) enum PPCOrderIntent intent;
		[Export ("intent")]
		PPCOrderIntent Intent { get; }

		// @property (readonly, nonatomic, strong) PPCOrderPayer * _Nullable payer;
		[NullAllowed, Export ("payer", ArgumentSemantic.Strong)]
		PPCOrderPayer Payer { get; }

		// @property (readonly, copy, nonatomic) NSArray<PPCPurchaseUnit *> * _Nonnull purchaseUnits;
		[Export ("purchaseUnits", ArgumentSemantic.Copy)]
		PPCPurchaseUnit[] PurchaseUnits { get; }

		// @property (readonly, nonatomic, strong) PPCOrderApplicationContext * _Nullable applicationContext;
		[NullAllowed, Export ("applicationContext", ArgumentSemantic.Strong)]
		PPCOrderApplicationContext ApplicationContext { get; }

		// -(instancetype _Nonnull)initWithIntent:(enum PPCOrderIntent)intent purchaseUnits:(NSArray<PPCPurchaseUnit *> * _Nonnull)purchaseUnits processingInstruction:(enum PPCOrderProcessingInstruction)processingInstruction payer:(PPCOrderPayer * _Nullable)payer applicationContext:(PPCOrderApplicationContext * _Nullable)applicationContext __attribute__((objc_designated_initializer));
		[Export ("initWithIntent:purchaseUnits:processingInstruction:payer:applicationContext:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCOrderIntent intent, PPCPurchaseUnit[] purchaseUnits, PPCOrderProcessingInstruction processingInstruction, [NullAllowed] PPCOrderPayer payer, [NullAllowed] PPCOrderApplicationContext applicationContext);
	}

	// @interface PPCPatchActionSuccess : NSObject
	[BaseType (typeof(NSObject))]
	interface PPCPatchActionSuccess
	{
	}

	// @interface PPCPatchRequest : NSObject
	[BaseType (typeof(NSObject))]
	interface PPCPatchRequest
	{
		// -(void)addWithShippingName:(PPCPurchaseUnitShippingName * _Nonnull)shippingName referenceId:(NSString * _Nullable)referenceId;
		[Export ("addWithShippingName:referenceId:")]
		void AddWithShippingName (PPCPurchaseUnitShippingName shippingName, [NullAllowed] string referenceId);

		// -(void)addWithShippingAddress:(PPCOrderAddress * _Nonnull)shippingAddress referenceId:(NSString * _Nullable)referenceId;
		[Export ("addWithShippingAddress:referenceId:")]
		void AddWithShippingAddress (PPCOrderAddress shippingAddress, [NullAllowed] string referenceId);

		// -(void)addWithShippingOptions:(NSArray<PPCShippingMethod *> * _Nonnull)shippingOptions referenceId:(NSString * _Nullable)referenceId;
		[Export ("addWithShippingOptions:referenceId:")]
		void AddWithShippingOptions (PPCShippingMethod[] shippingOptions, [NullAllowed] string referenceId);

		// -(void)replaceWithShippingName:(PPCPurchaseUnitShippingName * _Nonnull)shippingName referenceId:(NSString * _Nullable)referenceId;
		[Export ("replaceWithShippingName:referenceId:")]
		void ReplaceWithShippingName (PPCPurchaseUnitShippingName shippingName, [NullAllowed] string referenceId);

		// -(void)replaceWithShippingAddress:(PPCOrderAddress * _Nonnull)shippingAddress referenceId:(NSString * _Nullable)referenceId;
		[Export ("replaceWithShippingAddress:referenceId:")]
		void ReplaceWithShippingAddress (PPCOrderAddress shippingAddress, [NullAllowed] string referenceId);

		// -(void)replaceWithShippingOptions:(NSArray<PPCShippingMethod *> * _Nonnull)shippingOptions referenceId:(NSString * _Nullable)referenceId;
		[Export ("replaceWithShippingOptions:referenceId:")]
		void ReplaceWithShippingOptions (PPCShippingMethod[] shippingOptions, [NullAllowed] string referenceId);

		// -(void)replaceWithAmount:(PPCPurchaseUnitAmount * _Nonnull)amount referenceId:(NSString * _Nullable)referenceId;
		[Export ("replaceWithAmount:referenceId:")]
		void ReplaceWithAmount (PPCPurchaseUnitAmount amount, [NullAllowed] string referenceId);
	}

	// @interface PPCPayLaterButtonUIConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface PPCPayLaterButtonUIConfiguration
	{
		// -(instancetype _Nonnull)initWithColor:(enum PPCPayPalPayLaterButtonColor)color attributes:(PPCPaymentButtonAttributes * _Nonnull)attributes __attribute__((objc_designated_initializer));
		[Export ("initWithColor:attributes:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCPayPalPayLaterButtonColor color, PPCPaymentButtonAttributes attributes);
	}

	// @interface PPCPaymentButton : UIButton
	[BaseType (typeof(UIButton))]
	interface PPCPaymentButton
	{
		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		// -(void)checkoutFinished;
		[Export ("checkoutFinished")]
		void CheckoutFinished ();

		// @property (readonly, nonatomic) enum PPCPaymentButtonFundingSource fundingSource;
		[Export ("fundingSource")]
		PPCPaymentButtonFundingSource FundingSource { get; }

		// @property (nonatomic) enum PPCPaymentButtonColor color;
		[Export ("color", ArgumentSemantic.Assign)]
		PPCPaymentButtonColor Color { get; set; }

		// @property (nonatomic) enum PPCPaymentButtonEdges edges;
		[Export ("edges", ArgumentSemantic.Assign)]
		PPCPaymentButtonEdges Edges { get; set; }

		// @property (nonatomic) enum PPCPaymentButtonSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		PPCPaymentButtonSize Size { get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

	// @interface PPCPayPalButton : PPCPaymentButton
	[BaseType (typeof(PPCPaymentButton))]
	interface PPCPayPalButton
	{
		// -(instancetype _Nonnull)initWithInsets:(NSDirectionalEdgeInsets)insets color:(enum PPCPayPalButtonColor)color edges:(enum PPCPaymentButtonEdges)edges size:(enum PPCPaymentButtonSize)size label:(enum PPCPayPalButtonLabel)label isEnabled:(BOOL)isEnabled __attribute__((deprecated("Use PaymentButtonContainer() instead.")));
		[Export ("initWithInsets:color:edges:size:label:isEnabled:")]
		IntPtr Constructor (NSDirectionalEdgeInsets insets, PPCPayPalButtonColor color, PPCPaymentButtonEdges edges, PPCPaymentButtonSize size, PPCPayPalButtonLabel label, bool isEnabled);

		// -(instancetype _Nonnull)initWithColor:(enum PPCPayPalButtonColor)color edges:(enum PPCPaymentButtonEdges)edges size:(enum PPCPaymentButtonSize)size label:(enum PPCPayPalButtonLabel)label isEnabled:(BOOL)isEnabled __attribute__((deprecated("Use PaymentButtonContainer() instead.")));
		[Export ("initWithColor:edges:size:label:isEnabled:")]
		IntPtr Constructor (PPCPayPalButtonColor color, PPCPaymentButtonEdges edges, PPCPaymentButtonSize size, PPCPayPalButtonLabel label, bool isEnabled);
	}

	// @interface PPCPayPalButtonUIConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface PPCPayPalButtonUIConfiguration
	{
	}

	// @interface PPCPayPalCreditButton : PPCPaymentButton
	[BaseType (typeof(PPCPaymentButton))]
	interface PPCPayPalCreditButton
	{
		// -(instancetype _Nonnull)initWithInsets:(NSDirectionalEdgeInsets)insets color:(enum PPCPayPalCreditButtonColor)color edges:(enum PPCPaymentButtonEdges)edges size:(enum PPCPaymentButtonSize)size isEnabled:(BOOL)isEnabled __attribute__((deprecated("Use PaymentButtonContainer() instead.")));
		[Export ("initWithInsets:color:edges:size:isEnabled:")]
		IntPtr Constructor (NSDirectionalEdgeInsets insets, PPCPayPalCreditButtonColor color, PPCPaymentButtonEdges edges, PPCPaymentButtonSize size, bool isEnabled);

		// -(instancetype _Nonnull)initWithColor:(enum PPCPayPalCreditButtonColor)color edges:(enum PPCPaymentButtonEdges)edges size:(enum PPCPaymentButtonSize)size isEnabled:(BOOL)isEnabled __attribute__((deprecated("Use PaymentButtonContainer() instead.")));
		[Export ("initWithColor:edges:size:isEnabled:")]
		IntPtr Constructor (PPCPayPalCreditButtonColor color, PPCPaymentButtonEdges edges, PPCPaymentButtonSize size, bool isEnabled);
	}

	// @interface PPCPayPalCreditButtonUIConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface PPCPayPalCreditButtonUIConfiguration
	{
		// -(instancetype _Nonnull)initWithColor:(enum PPCPayPalCreditButtonColor)color attributes:(PPCPaymentButtonAttributes * _Nonnull)attributes __attribute__((objc_designated_initializer));
		[Export ("initWithColor:attributes:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCPayPalCreditButtonColor color, PPCPaymentButtonAttributes attributes);
	}

	// @interface PPCPayPalPayLaterButton : PPCPaymentButton
	[BaseType (typeof(PPCPaymentButton))]
	interface PPCPayPalPayLaterButton
	{
		// -(instancetype _Nonnull)initWithInsets:(NSDirectionalEdgeInsets)insets color:(enum PPCPayPalPayLaterButtonColor)color edges:(enum PPCPaymentButtonEdges)edges size:(enum PPCPaymentButtonSize)size isEnabled:(BOOL)isEnabled __attribute__((deprecated("Use PaymentButtonContainer() instead.")));
		[Export ("initWithInsets:color:edges:size:isEnabled:")]
		IntPtr Constructor (NSDirectionalEdgeInsets insets, PPCPayPalPayLaterButtonColor color, PPCPaymentButtonEdges edges, PPCPaymentButtonSize size, bool isEnabled);

		// -(instancetype _Nonnull)initWithColor:(enum PPCPayPalPayLaterButtonColor)color edges:(enum PPCPaymentButtonEdges)edges size:(enum PPCPaymentButtonSize)size isEnabled:(BOOL)isEnabled __attribute__((deprecated("Use PaymentButtonContainer() instead.")));
		[Export ("initWithColor:edges:size:isEnabled:")]
		IntPtr Constructor (PPCPayPalPayLaterButtonColor color, PPCPaymentButtonEdges edges, PPCPaymentButtonSize size, bool isEnabled);
	}

	// @interface PPCPaymentButtonAttributes : NSObject
	[BaseType (typeof(NSObject))]
	interface PPCPaymentButtonAttributes
	{
		// -(instancetype _Nonnull)initWithEdges:(enum PPCPaymentButtonEdges)edges size:(enum PPCPaymentButtonSize)size isEnabled:(BOOL)isEnabled __attribute__((objc_designated_initializer));
		[Export ("initWithEdges:size:isEnabled:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCPaymentButtonEdges edges, PPCPaymentButtonSize size, bool isEnabled);
	}

	// @interface PPCPaymentButtonContainer : UIView
	[BaseType (typeof(UIView))]
	interface PPCPaymentButtonContainer
	{
		// @property (copy, nonatomic) void (^ _Nullable)(PPCCreateOrderAction * _Nonnull) onCreateOrder;
		[NullAllowed, Export ("onCreateOrder", ArgumentSemantic.Copy)]
		Action<PPCCreateOrderAction> OnCreateOrder { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(PPCApproval * _Nonnull) onApproval;
		[NullAllowed, Export ("onApproval", ArgumentSemantic.Copy)]
		Action<PPCApproval> OnApproval { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onCancel;
		[NullAllowed, Export ("onCancel", ArgumentSemantic.Copy)]
		Action OnCancel { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(PPCErrorInfo * _Nonnull) onError;
		[NullAllowed, Export ("onError", ArgumentSemantic.Copy)]
		Action<PPCErrorInfo> OnError { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(PPCShippingChange * _Nonnull, PPCShippingChangeAction * _Nonnull) onShippingChange;
		[NullAllowed, Export ("onShippingChange", ArgumentSemantic.Copy)]
		Action<PPCShippingChange, PPCShippingChangeAction> OnShippingChange { get; set; }

		// -(instancetype _Nonnull)initWithPayPalButtonUIConfiguration:(PPCPayPalButtonUIConfiguration * _Nonnull)payPalButtonUIConfiguration payPalCreditButtonUIConfiguration:(PPCPayPalCreditButtonUIConfiguration * _Nonnull)payPalCreditButtonUIConfiguration payLaterButtonUIConfiguration:(PPCPayLaterButtonUIConfiguration * _Nonnull)payLaterButtonUIConfiguration delegate:(id<PPCPaymentButtonContainerDelegate> _Nullable)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithPayPalButtonUIConfiguration:payPalCreditButtonUIConfiguration:payLaterButtonUIConfiguration:delegate:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCPayPalButtonUIConfiguration payPalButtonUIConfiguration, PPCPayPalCreditButtonUIConfiguration payPalCreditButtonUIConfiguration, PPCPayLaterButtonUIConfiguration payLaterButtonUIConfiguration, [NullAllowed] IPPCPaymentButtonContainerDelegate @delegate);

		// -(void)setupOnCreateOrder:(void (^ _Nullable)(PPCCreateOrderAction * _Nonnull))onCreateOrder onApproval:(void (^ _Nullable)(PPCApproval * _Nonnull))onApproval onCancel:(void (^ _Nullable)(void))onCancel onError:(void (^ _Nullable)(PPCErrorInfo * _Nonnull))onError onShippingChange:(void (^ _Nullable)(PPCShippingChange * _Nonnull, PPCShippingChangeAction * _Nonnull))onShippingChange;
		[Export ("setupOnCreateOrder:onApproval:onCancel:onError:onShippingChange:")]
		void SetupOnCreateOrder ([NullAllowed] Action<PPCCreateOrderAction> onCreateOrder, [NullAllowed] Action<PPCApproval> onApproval, [NullAllowed] Action onCancel, [NullAllowed] Action<PPCErrorInfo> onError, [NullAllowed] Action<PPCShippingChange, PPCShippingChangeAction> onShippingChange);

		// -(void)configurePayPalButtonWith:(PPCPayPalButtonUIConfiguration * _Nonnull)configuration;
		[Export ("configurePayPalButtonWith:")]
		void ConfigurePayPalButtonWith (PPCPayPalButtonUIConfiguration configuration);

		// -(void)configurePayPalCreditButtonWith:(PPCPayPalCreditButtonUIConfiguration * _Nonnull)configuration;
		[Export ("configurePayPalCreditButtonWith:")]
		void ConfigurePayPalCreditButtonWith (PPCPayPalCreditButtonUIConfiguration configuration);

		// -(void)configurePayLaterButtonWith:(PPCPayLaterButtonUIConfiguration * _Nonnull)configuration;
		[Export ("configurePayLaterButtonWith:")]
		void ConfigurePayLaterButtonWith (PPCPayLaterButtonUIConfiguration configuration);

		// -(void)onButtonStart:(PPCPaymentButton * _Nonnull)button;
		[Export ("onButtonStart:")]
		void OnButtonStart (PPCPaymentButton button);

		// -(void)onButtonFinish:(PPCPaymentButton * _Nonnull)button;
		[Export ("onButtonFinish:")]
		void OnButtonFinish (PPCPaymentButton button);

		// -(void)button:(PPCPaymentButton * _Nonnull)button changedEligibilityStatus:(enum PPCPaymentButtonEligibilityStatus)status;
		[Export ("button:changedEligibilityStatus:")]
		void Button (PPCPaymentButton button, PPCPaymentButtonEligibilityStatus status);
	}

	partial interface IPPCPaymentButtonContainerDelegate { }

    // @protocol PPCPaymentButtonContainerDelegate
    [Protocol, Model]
	interface PPCPaymentButtonContainerDelegate
	{
		// @required -(void)onLoading;
		[Abstract]
		[Export ("onLoading")]
		void OnLoading ();

		// @required -(void)onFinishWithFundingEligibilityState:(PPCPaymentFundingEligibilityState * _Nullable)fundingEligibilityState error:(NSError * _Nullable)error;
		[Abstract]
		[Export ("onFinishWithFundingEligibilityState:error:")]
		void OnFinishWithFundingEligibilityState ([NullAllowed] PPCPaymentFundingEligibilityState fundingEligibilityState, [NullAllowed] NSError error);
	}

	// @interface PPCPaymentFundingEligibilityState : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPaymentFundingEligibilityState
	{
	}

	// @interface ProfileImageBubble : UIImageView
	[BaseType (typeof(UIImageView), Name = "_TtC14PayPalCheckout18ProfileImageBubble")]
	[DisableDefaultCtor]
	interface ProfileImageBubble
	{
		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

	// @interface PPCPurchaseUnit : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnit
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable referenceId;
		[NullAllowed, Export ("referenceId")]
		string ReferenceId { get; }

		// @property (readonly, nonatomic, strong) PPCPurchaseUnitAmount * _Nonnull amount;
		[Export ("amount", ArgumentSemantic.Strong)]
		PPCPurchaseUnitAmount Amount { get; }

		// @property (readonly, nonatomic, strong) PPCPurchaseUnitPayee * _Nullable payee;
		[NullAllowed, Export ("payee", ArgumentSemantic.Strong)]
		PPCPurchaseUnitPayee Payee { get; }

		// @property (readonly, nonatomic, strong) PPCPurchaseUnitPaymentInstruction * _Nullable paymentInstruction;
		[NullAllowed, Export ("paymentInstruction", ArgumentSemantic.Strong)]
		PPCPurchaseUnitPaymentInstruction PaymentInstruction { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable purchaseUnitDescription;
		[NullAllowed, Export ("purchaseUnitDescription")]
		string PurchaseUnitDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customId;
		[NullAllowed, Export ("customId")]
		string CustomId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable invoiceId;
		[NullAllowed, Export ("invoiceId")]
		string InvoiceId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable softDescriptor;
		[NullAllowed, Export ("softDescriptor")]
		string SoftDescriptor { get; }

		// @property (readonly, copy, nonatomic) NSArray<PPCPurchaseUnitItem *> * _Nullable items;
		[NullAllowed, Export ("items", ArgumentSemantic.Copy)]
		PPCPurchaseUnitItem[] Items { get; }

		// @property (readonly, nonatomic, strong) PPCPurchaseUnitShipping * _Nullable shipping;
		[NullAllowed, Export ("shipping", ArgumentSemantic.Strong)]
		PPCPurchaseUnitShipping Shipping { get; }

		// -(instancetype _Nonnull)initWithAmount:(PPCPurchaseUnitAmount * _Nonnull)amount referenceId:(NSString * _Nullable)referenceId payee:(PPCPurchaseUnitPayee * _Nullable)payee paymentInstruction:(PPCPurchaseUnitPaymentInstruction * _Nullable)paymentInstruction purchaseUnitDescription:(NSString * _Nullable)purchaseUnitDescription customId:(NSString * _Nullable)customId invoiceId:(NSString * _Nullable)invoiceId softDescriptor:(NSString * _Nullable)softDescriptor items:(NSArray<PPCPurchaseUnitItem *> * _Nullable)items shipping:(PPCPurchaseUnitShipping * _Nullable)shipping __attribute__((objc_designated_initializer));
		[Export ("initWithAmount:referenceId:payee:paymentInstruction:purchaseUnitDescription:customId:invoiceId:softDescriptor:items:shipping:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCPurchaseUnitAmount amount, [NullAllowed] string referenceId, [NullAllowed] PPCPurchaseUnitPayee payee, [NullAllowed] PPCPurchaseUnitPaymentInstruction paymentInstruction, [NullAllowed] string purchaseUnitDescription, [NullAllowed] string customId, [NullAllowed] string invoiceId, [NullAllowed] string softDescriptor, [NullAllowed] PPCPurchaseUnitItem[] items, [NullAllowed] PPCPurchaseUnitShipping shipping);
	}

	// @interface PPCPurchaseUnitAmount : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnitAmount
	{
		// @property (readonly, nonatomic) enum PPCCurrencyCode currencyCode;
		[Export ("currencyCode")]
		PPCCurrencyCode CurrencyCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
		string Value { get; }

		// @property (readonly, nonatomic, strong) PPCPurchaseUnitBreakdown * _Nullable breakdown;
		[NullAllowed, Export ("breakdown", ArgumentSemantic.Strong)]
		PPCPurchaseUnitBreakdown Breakdown { get; }

		// -(instancetype _Nonnull)initWithCurrencyCode:(enum PPCCurrencyCode)currencyCode value:(NSString * _Nonnull)value breakdown:(PPCPurchaseUnitBreakdown * _Nullable)breakdown __attribute__((objc_designated_initializer));
		[Export ("initWithCurrencyCode:value:breakdown:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCCurrencyCode currencyCode, string value, [NullAllowed] PPCPurchaseUnitBreakdown breakdown);
	}

	// @interface PPCPurchaseUnitBreakdown : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnitBreakdown
	{
		// @property (readonly, nonatomic, strong) PPCUnitAmount * _Nullable itemTotal;
		[NullAllowed, Export ("itemTotal", ArgumentSemantic.Strong)]
		PPCUnitAmount ItemTotal { get; }

		// @property (readonly, nonatomic, strong) PPCUnitAmount * _Nullable shipping;
		[NullAllowed, Export ("shipping", ArgumentSemantic.Strong)]
		PPCUnitAmount Shipping { get; }

		// @property (readonly, nonatomic, strong) PPCUnitAmount * _Nullable handling;
		[NullAllowed, Export ("handling", ArgumentSemantic.Strong)]
		PPCUnitAmount Handling { get; }

		// @property (readonly, nonatomic, strong) PPCUnitAmount * _Nullable taxTotal;
		[NullAllowed, Export ("taxTotal", ArgumentSemantic.Strong)]
		PPCUnitAmount TaxTotal { get; }

		// @property (readonly, nonatomic, strong) PPCUnitAmount * _Nullable insurance;
		[NullAllowed, Export ("insurance", ArgumentSemantic.Strong)]
		PPCUnitAmount Insurance { get; }

		// @property (readonly, nonatomic, strong) PPCUnitAmount * _Nullable shippingDiscount;
		[NullAllowed, Export ("shippingDiscount", ArgumentSemantic.Strong)]
		PPCUnitAmount ShippingDiscount { get; }

		// @property (readonly, nonatomic, strong) PPCUnitAmount * _Nullable discount;
		[NullAllowed, Export ("discount", ArgumentSemantic.Strong)]
		PPCUnitAmount Discount { get; }

		// -(instancetype _Nonnull)initWithItemTotal:(PPCUnitAmount * _Nullable)itemTotal shipping:(PPCUnitAmount * _Nullable)shipping handling:(PPCUnitAmount * _Nullable)handling taxTotal:(PPCUnitAmount * _Nullable)taxTotal insurance:(PPCUnitAmount * _Nullable)insurance shippingDiscount:(PPCUnitAmount * _Nullable)shippingDiscount discount:(PPCUnitAmount * _Nullable)discount __attribute__((objc_designated_initializer));
		[Export ("initWithItemTotal:shipping:handling:taxTotal:insurance:shippingDiscount:discount:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] PPCUnitAmount itemTotal, [NullAllowed] PPCUnitAmount shipping, [NullAllowed] PPCUnitAmount handling, [NullAllowed] PPCUnitAmount taxTotal, [NullAllowed] PPCUnitAmount insurance, [NullAllowed] PPCUnitAmount shippingDiscount, [NullAllowed] PPCUnitAmount discount);
	}

	// @interface PPCPurchaseUnitPayee : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnitPayee
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable emailAddress;
		[NullAllowed, Export ("emailAddress")]
		string EmailAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable merchantId;
		[NullAllowed, Export ("merchantId")]
		string MerchantId { get; }

		// -(instancetype _Nonnull)initWithEmailAddress:(NSString * _Nullable)emailAddress merchantId:(NSString * _Nullable)merchantId __attribute__((objc_designated_initializer));
		[Export ("initWithEmailAddress:merchantId:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string emailAddress, [NullAllowed] string merchantId);
	}

	// @interface PPCPurchaseUnitPaymentInstruction : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnitPaymentInstruction
	{
		// @property (readonly, copy, nonatomic) NSArray<PPCPurchaseUnitPlatformFees *> * _Nullable platformFees;
		[NullAllowed, Export ("platformFees", ArgumentSemantic.Copy)]
		PPCPurchaseUnitPlatformFees[] PlatformFees { get; }

		// @property (readonly, nonatomic) enum PPCPurchaseUnitDisbursementMode disbursementMode;
		[Export ("disbursementMode")]
		PPCPurchaseUnitDisbursementMode DisbursementMode { get; }

		// -(instancetype _Nonnull)initWithPlatformFees:(NSArray<PPCPurchaseUnitPlatformFees *> * _Nullable)platformFees disbursementMode:(enum PPCPurchaseUnitDisbursementMode)disbursementMode __attribute__((objc_designated_initializer));
		[Export ("initWithPlatformFees:disbursementMode:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] PPCPurchaseUnitPlatformFees[] platformFees, PPCPurchaseUnitDisbursementMode disbursementMode);
	}

	// @interface PPCPurchaseUnitPlatformFees : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnitPlatformFees
	{
		// @property (readonly, nonatomic, strong) PPCPurchaseUnitAmount * _Nonnull amount;
		[Export ("amount", ArgumentSemantic.Strong)]
		PPCPurchaseUnitAmount Amount { get; }

		// @property (readonly, nonatomic, strong) PPCPurchaseUnitPayee * _Nullable payee;
		[NullAllowed, Export ("payee", ArgumentSemantic.Strong)]
		PPCPurchaseUnitPayee Payee { get; }

		// -(instancetype _Nonnull)initWithAmount:(PPCPurchaseUnitAmount * _Nonnull)amount payee:(PPCPurchaseUnitPayee * _Nullable)payee __attribute__((objc_designated_initializer));
		[Export ("initWithAmount:payee:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCPurchaseUnitAmount amount, [NullAllowed] PPCPurchaseUnitPayee payee);
	}

	// @interface PPCPurchaseUnitItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnitItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic, strong) PPCUnitAmount * _Nonnull unitAmount;
		[Export ("unitAmount", ArgumentSemantic.Strong)]
		PPCUnitAmount UnitAmount { get; }

		// @property (readonly, nonatomic, strong) PPCPurchaseUnitTax * _Nullable tax;
		[NullAllowed, Export ("tax", ArgumentSemantic.Strong)]
		PPCPurchaseUnitTax Tax { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull quantity;
		[Export ("quantity")]
		string Quantity { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable itemDescription;
		[NullAllowed, Export ("itemDescription")]
		string ItemDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sku;
		[NullAllowed, Export ("sku")]
		string Sku { get; }

		// @property (readonly, nonatomic) enum PPCPurchaseUnitCategory category;
		[Export ("category")]
		PPCPurchaseUnitCategory Category { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name unitAmount:(PPCUnitAmount * _Nonnull)unitAmount quantity:(NSString * _Nonnull)quantity tax:(PPCPurchaseUnitTax * _Nullable)tax itemDescription:(NSString * _Nullable)itemDescription sku:(NSString * _Nullable)sku category:(enum PPCPurchaseUnitCategory)category __attribute__((objc_designated_initializer));
		[Export ("initWithName:unitAmount:quantity:tax:itemDescription:sku:category:")]
		[DesignatedInitializer]
		IntPtr Constructor (string name, PPCUnitAmount unitAmount, string quantity, [NullAllowed] PPCPurchaseUnitTax tax, [NullAllowed] string itemDescription, [NullAllowed] string sku, PPCPurchaseUnitCategory category);
	}

	// @interface PPCPurchaseUnitTax : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnitTax
	{
		// @property (readonly, nonatomic) enum PPCCurrencyCode currencyCode;
		[Export ("currencyCode")]
		PPCCurrencyCode CurrencyCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
		string Value { get; }

		// -(instancetype _Nonnull)initWithCurrencyCode:(enum PPCCurrencyCode)currencyCode value:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithCurrencyCode:value:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCCurrencyCode currencyCode, string value);
	}

	// @interface PPCPurchaseUnitShipping : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnitShipping
	{
		// @property (readonly, nonatomic, strong) PPCPurchaseUnitShippingName * _Nullable shippingName;
		[NullAllowed, Export ("shippingName", ArgumentSemantic.Strong)]
		PPCPurchaseUnitShippingName ShippingName { get; }

		// @property (readonly, nonatomic, strong) PPCOrderAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		PPCOrderAddress Address { get; }

		// @property (readonly, copy, nonatomic) NSArray<PPCShippingMethod *> * _Nullable options;
		[NullAllowed, Export ("options", ArgumentSemantic.Copy)]
		PPCShippingMethod[] Options { get; }

		// -(instancetype _Nonnull)initWithShippingName:(PPCPurchaseUnitShippingName * _Nullable)shippingName address:(PPCOrderAddress * _Nullable)address options:(NSArray<PPCShippingMethod *> * _Nullable)options __attribute__((objc_designated_initializer));
		[Export ("initWithShippingName:address:options:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] PPCPurchaseUnitShippingName shippingName, [NullAllowed] PPCOrderAddress address, [NullAllowed] PPCShippingMethod[] options);
	}

	// @interface PPCPurchaseUnitShippingName : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCPurchaseUnitShippingName
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable fullName;
		[NullAllowed, Export ("fullName")]
		string FullName { get; }

		// -(instancetype _Nonnull)initWithFullName:(NSString * _Nullable)fullName __attribute__((objc_designated_initializer));
		[Export ("initWithFullName:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string fullName);
	}

	// @interface RateChangePolicyHeaderView : UnconstrainedTextLabel
	[BaseType (typeof(UnconstrainedTextLabel), Name = "_TtC14PayPalCheckout26RateChangePolicyHeaderView")]
	interface RateChangePolicyHeaderView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface RateChangeView : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout14RateChangeView")]
	interface RateChangeView
	{
	}

	// @interface PPCSessionIDs : NSObject
	[BaseType (typeof(NSObject))]
	interface PPCSessionIDs
	{
		// @property (copy, nonatomic) NSString * _Nullable sdkSessionID;
		[NullAllowed, Export ("sdkSessionID")]
		string SdkSessionID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable orderSessionID;
		[NullAllowed, Export ("orderSessionID")]
		string OrderSessionID { get; set; }
	}

	// @interface PPCShippingChange : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCShippingChange
	{
		// @property (readonly, nonatomic) enum PPCShippingChangeType type;
		[Export ("type")]
		PPCShippingChangeType Type { get; }

		// @property (readonly, nonatomic, strong) PPCShippingChangeAddress * _Nonnull selectedShippingAddress;
		[Export ("selectedShippingAddress", ArgumentSemantic.Strong)]
		PPCShippingChangeAddress SelectedShippingAddress { get; }

		// @property (readonly, copy, nonatomic) NSArray<PPCShippingMethod *> * _Nonnull shippingMethods;
		[Export ("shippingMethods", ArgumentSemantic.Copy)]
		PPCShippingMethod[] ShippingMethods { get; }

		// @property (readonly, nonatomic, strong) PPCShippingMethod * _Nullable selectedShippingMethod;
		[NullAllowed, Export ("selectedShippingMethod", ArgumentSemantic.Strong)]
		PPCShippingMethod SelectedShippingMethod { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull payToken;
		[Export ("payToken")]
		string PayToken { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable paymentID;
		[NullAllowed, Export ("paymentID")]
		string PaymentID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable billingToken;
		[NullAllowed, Export ("billingToken")]
		string BillingToken { get; }
	}

	// @interface PPCShippingChangeAction : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCShippingChangeAction
	{
		// -(void)patchWithRequest:(PPCPatchRequest * _Nonnull)request onComplete:(void (^ _Nonnull)(PPCPatchActionSuccess * _Nullable, NSError * _Nullable))onComplete;
		[Export ("patchWithRequest:onComplete:")]
		void PatchWithRequest (PPCPatchRequest request, Action<PPCPatchActionSuccess, NSError> onComplete);

		// -(void)approve;
		[Export ("approve")]
		void Approve ();

		// -(void)reject;
		[Export ("reject")]
		void Reject ();
	}

	// @interface PPCShippingChangeAddress : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCShippingChangeAddress
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable addressID;
		[NullAllowed, Export ("addressID")]
		string AddressID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fullName;
		[NullAllowed, Export ("fullName")]
		string FullName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable city;
		[NullAllowed, Export ("city")]
		string City { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable state;
		[NullAllowed, Export ("state")]
		string State { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// -(instancetype _Nonnull)initWithAddressID:(NSString * _Nullable)addressID fullName:(NSString * _Nullable)fullName city:(NSString * _Nullable)city state:(NSString * _Nullable)state postalCode:(NSString * _Nullable)postalCode country:(NSString * _Nullable)country __attribute__((objc_designated_initializer));
		[Export ("initWithAddressID:fullName:city:state:postalCode:country:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string addressID, [NullAllowed] string fullName, [NullAllowed] string city, [NullAllowed] string state, [NullAllowed] string postalCode, [NullAllowed] string country);
	}

	// @interface PPCShippingMethod : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCShippingMethod
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label { get; }

		// @property (readonly, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { get; }

		// @property (readonly, nonatomic) enum PPCShippingType type;
		[Export ("type")]
		PPCShippingType Type { get; }

		// @property (readonly, nonatomic, strong) PPCUnitAmount * _Nullable amount;
		[NullAllowed, Export ("amount", ArgumentSemantic.Strong)]
		PPCUnitAmount Amount { get; }

		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id label:(NSString * _Nonnull)label selected:(BOOL)selected type:(enum PPCShippingType)type amount:(PPCUnitAmount * _Nullable)amount __attribute__((objc_designated_initializer));
		[Export ("initWithId:label:selected:type:amount:")]
		[DesignatedInitializer]
		IntPtr Constructor (string id, string label, bool selected, PPCShippingType type, [NullAllowed] PPCUnitAmount amount);
	}

	// @interface ShippingView : UIView
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout12ShippingView")]
	interface ShippingView
	{
	}

	// @interface SuggestionsView : UIView <UICollectionViewDelegateFlowLayout>
	[BaseType (typeof(UIView), Name = "_TtC14PayPalCheckout15SuggestionsView")]
	interface SuggestionsView : IUICollectionViewDelegateFlowLayout
	{
		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGSize)collectionView:(UICollectionView * _Nonnull)collectionView layout:(UICollectionViewLayout * _Nonnull)collectionViewLayout sizeForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
		[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
		CGSize CollectionView (UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, NSIndexPath indexPath);

		// -(CGSize)collectionView:(UICollectionView * _Nonnull)collectionView layout:(UICollectionViewLayout * _Nonnull)collectionViewLayout referenceSizeForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("collectionView:layout:referenceSizeForFooterInSection:")]
		CGSize CollectionView (UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

		// -(void)collectionView:(UICollectionView * _Nonnull)collectionView didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("collectionView:didSelectItemAtIndexPath:")]
		void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);
	}

	// @interface TransitionLabel : UILabel
	[BaseType (typeof(UILabel), Name = "_TtC14PayPalCheckout15TransitionLabel")]
	interface TransitionLabel
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}

	// @interface PPCUnitAmount : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCUnitAmount
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable value;
		[NullAllowed, Export ("value")]
		string Value { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable currencyCodeString;
		[NullAllowed, Export ("currencyCodeString")]
		string CurrencyCodeString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable currencyFormat;
		[NullAllowed, Export ("currencyFormat")]
		string CurrencyFormat { get; }

		// -(instancetype _Nonnull)initWithCurrencyCode:(enum PPCCurrencyCode)currencyCode value:(NSString * _Nonnull)value __attribute__((objc_designated_initializer));
		[Export ("initWithCurrencyCode:value:")]
		[DesignatedInitializer]
		IntPtr Constructor (PPCCurrencyCode currencyCode, string value);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);
	}

	// @interface PPCVaultData : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PPCVaultData
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull approvalSessionID;
		[Export ("approvalSessionID")]
		string ApprovalSessionID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull approvalTokenID;
		[Export ("approvalTokenID")]
		string ApprovalTokenID { get; }
	}
}
