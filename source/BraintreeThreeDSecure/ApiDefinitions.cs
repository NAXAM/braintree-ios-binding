using System;
using BraintreeThreeDSecure;
using Foundation;
using ObjCRuntime;
using BraintreeCore;
using BraintreeCard;
using BraintreePaymentFlow;

namespace BraintreeThreeDSecure
{
	// @interface BTConfiguration (ThreeDSecure)
	[Category]
	[BaseType(typeof(BTConfiguration))]
	interface BTConfiguration_ThreeDSecure
	{
		// @property (readonly, nonatomic, strong) int * cardinalAuthenticationJWT;
		[Export("cardinalAuthenticationJWT", ArgumentSemantic.Strong)]
		unsafe NSArray CardinalAuthenticationJWT();
	}

	// @interface BTPaymentFlowDriver (ThreeDSecure)
	[Category]
	[BaseType(typeof(BTPaymentFlowDriver))]
	interface BTPaymentFlowDriver_ThreeDSecure
	{
		// -(void)prepareLookup:(id)request completion:(void (^)(int * _Nullable, int * _Nullable))completionBlock;
		[Export ("prepareLookup:completion:")]
		unsafe void PrepareLookup (NSObject request, Action<NSArray, NSArray> completionBlock);

		// -(void)initializeChallengeWithLookupResponse:(id)lookupResponse request:(id)request completion:(void (^)(int * _Nullable, int * _Nullable))completionBlock;
		[Export ("initializeChallengeWithLookupResponse:request:completion:")]
		unsafe void InitializeChallengeWithLookupResponse (NSObject lookupResponse, NSObject request, Action<NSArray, NSArray> completionBlock);
	}

	// @interface BTThreeDSecureAdditionalInformation : NSObject
	[BaseType (typeof(NSObject))]
	interface BTThreeDSecureAdditionalInformation
	{
		// @property (copy, nonatomic) BTThreeDSecurePostalAddress * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Copy)]
		BTThreeDSecurePostalAddress ShippingAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable shippingMethodIndicator;
		[NullAllowed, Export ("shippingMethodIndicator")]
		string ShippingMethodIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable productCode;
		[NullAllowed, Export ("productCode")]
		string ProductCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable deliveryTimeframe;
		[NullAllowed, Export ("deliveryTimeframe")]
		string DeliveryTimeframe { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable deliveryEmail;
		[NullAllowed, Export ("deliveryEmail")]
		string DeliveryEmail { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable reorderIndicator;
		[NullAllowed, Export ("reorderIndicator")]
		string ReorderIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable preorderIndicator;
		[NullAllowed, Export ("preorderIndicator")]
		string PreorderIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable preorderDate;
		[NullAllowed, Export ("preorderDate")]
		string PreorderDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable giftCardAmount;
		[NullAllowed, Export ("giftCardAmount")]
		string GiftCardAmount { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable giftCardCurrencyCode;
		[NullAllowed, Export ("giftCardCurrencyCode")]
		string GiftCardCurrencyCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable giftCardCount;
		[NullAllowed, Export ("giftCardCount")]
		string GiftCardCount { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountAgeIndicator;
		[NullAllowed, Export ("accountAgeIndicator")]
		string AccountAgeIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountCreateDate;
		[NullAllowed, Export ("accountCreateDate")]
		string AccountCreateDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountChangeIndicator;
		[NullAllowed, Export ("accountChangeIndicator")]
		string AccountChangeIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountChangeDate;
		[NullAllowed, Export ("accountChangeDate")]
		string AccountChangeDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountPwdChangeIndicator;
		[NullAllowed, Export ("accountPwdChangeIndicator")]
		string AccountPwdChangeIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountPwdChangeDate;
		[NullAllowed, Export ("accountPwdChangeDate")]
		string AccountPwdChangeDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable shippingAddressUsageIndicator;
		[NullAllowed, Export ("shippingAddressUsageIndicator")]
		string ShippingAddressUsageIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable shippingAddressUsageDate;
		[NullAllowed, Export ("shippingAddressUsageDate")]
		string ShippingAddressUsageDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable transactionCountDay;
		[NullAllowed, Export ("transactionCountDay")]
		string TransactionCountDay { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable transactionCountYear;
		[NullAllowed, Export ("transactionCountYear")]
		string TransactionCountYear { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable addCardAttempts;
		[NullAllowed, Export ("addCardAttempts")]
		string AddCardAttempts { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountPurchases;
		[NullAllowed, Export ("accountPurchases")]
		string AccountPurchases { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable fraudActivity;
		[NullAllowed, Export ("fraudActivity")]
		string FraudActivity { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable shippingNameIndicator;
		[NullAllowed, Export ("shippingNameIndicator")]
		string ShippingNameIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable paymentAccountIndicator;
		[NullAllowed, Export ("paymentAccountIndicator")]
		string PaymentAccountIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable paymentAccountAge;
		[NullAllowed, Export ("paymentAccountAge")]
		string PaymentAccountAge { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable addressMatch;
		[NullAllowed, Export ("addressMatch")]
		string AddressMatch { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountID;
		[NullAllowed, Export ("accountID")]
		string AccountID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable ipAddress;
		[NullAllowed, Export ("ipAddress")]
		string IpAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable orderDescription;
		[NullAllowed, Export ("orderDescription")]
		string OrderDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable taxAmount;
		[NullAllowed, Export ("taxAmount")]
		string TaxAmount { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable userAgent;
		[NullAllowed, Export ("userAgent")]
		string UserAgent { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable authenticationIndicator;
		[NullAllowed, Export ("authenticationIndicator")]
		string AuthenticationIndicator { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable installment;
		[NullAllowed, Export ("installment")]
		string Installment { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable purchaseDate;
		[NullAllowed, Export ("purchaseDate")]
		string PurchaseDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable recurringEnd;
		[NullAllowed, Export ("recurringEnd")]
		string RecurringEnd { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable recurringFrequency;
		[NullAllowed, Export ("recurringFrequency")]
		string RecurringFrequency { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sdkMaxTimeout;
		[NullAllowed, Export ("sdkMaxTimeout")]
		string SdkMaxTimeout { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable workPhoneNumber;
		[NullAllowed, Export ("workPhoneNumber")]
		string WorkPhoneNumber { get; set; }
	}

	// @interface BTThreeDSecureLookup : NSObject
	[BaseType (typeof(NSObject))]
	interface BTThreeDSecureLookup
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable PAReq;
		[NullAllowed, Export ("PAReq")]
		string PAReq { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable MD;
		[NullAllowed, Export ("MD")]
		string MD { get; }

		// @property (readonly, nonatomic) NSURL * _Nullable acsURL;
		[NullAllowed, Export ("acsURL")]
		NSURL AcsURL { get; }

		// @property (readonly, nonatomic) NSURL * _Nullable termURL;
		[NullAllowed, Export ("termURL")]
		NSURL TermURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable threeDSecureVersion;
		[NullAllowed, Export ("threeDSecureVersion")]
		string ThreeDSecureVersion { get; }

		// @property (readonly, nonatomic) BOOL isThreeDSecureVersion2;
		[Export ("isThreeDSecureVersion2")]
		bool IsThreeDSecureVersion2 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable transactionID;
		[NullAllowed, Export ("transactionID")]
		string TransactionID { get; }

		// @property (readonly, nonatomic) BOOL requiresUserAuthentication;
		[Export ("requiresUserAuthentication")]
		bool RequiresUserAuthentication { get; }
	}

	// @interface BTThreeDSecurePostalAddress : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface BTThreeDSecurePostalAddress : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable givenName;
		[NullAllowed, Export ("givenName")]
		string GivenName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable surname;
		[NullAllowed, Export ("surname")]
		string Surname { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable streetAddress;
		[NullAllowed, Export ("streetAddress")]
		string StreetAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable extendedAddress;
		[NullAllowed, Export ("extendedAddress")]
		string ExtendedAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable line3;
		[NullAllowed, Export ("line3")]
		string Line3 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable locality;
		[NullAllowed, Export ("locality")]
		string Locality { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable region;
		[NullAllowed, Export ("region")]
		string Region { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable countryCodeAlpha2;
		[NullAllowed, Export ("countryCodeAlpha2")]
		string CountryCodeAlpha2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phoneNumber;
		[NullAllowed, Export ("phoneNumber")]
		string PhoneNumber { get; set; }
	}

	// @interface BTThreeDSecureRequest
	interface BTThreeDSecureRequest
	{
		// @property (copy, nonatomic) NSString * _Nonnull nonce;
		[Export ("nonce")]
		string Nonce { get; set; }

		// @property (copy, nonatomic) NSDecimalNumber * _Nonnull amount;
		[Export ("amount", ArgumentSemantic.Copy)]
		NSDecimalNumber Amount { get; set; }

		// @property (assign, nonatomic) BTThreeDSecureAccountType accountType;
		[Export ("accountType", ArgumentSemantic.Assign)]
		BTThreeDSecureAccountType AccountType { get; set; }

		// @property (copy, nonatomic) BTThreeDSecurePostalAddress * _Nullable billingAddress;
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Copy)]
		BTThreeDSecurePostalAddress BillingAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable mobilePhoneNumber;
		[NullAllowed, Export ("mobilePhoneNumber")]
		string MobilePhoneNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; set; }

		// @property (assign, nonatomic) BTThreeDSecureShippingMethod shippingMethod;
		[Export ("shippingMethod", ArgumentSemantic.Assign)]
		BTThreeDSecureShippingMethod ShippingMethod { get; set; }

		// @property (nonatomic, strong) BTThreeDSecureAdditionalInformation * _Nullable additionalInformation;
		[NullAllowed, Export ("additionalInformation", ArgumentSemantic.Strong)]
		BTThreeDSecureAdditionalInformation AdditionalInformation { get; set; }

		// @property (assign, nonatomic) BTThreeDSecureVersion versionRequested;
		[Export ("versionRequested", ArgumentSemantic.Assign)]
		BTThreeDSecureVersion VersionRequested { get; set; }

		// @property (nonatomic) BOOL challengeRequested;
		[Export ("challengeRequested")]
		bool ChallengeRequested { get; set; }

		// @property (nonatomic) BOOL exemptionRequested;
		[Export ("exemptionRequested")]
		bool ExemptionRequested { get; set; }

		// @property (nonatomic) BOOL dataOnlyRequested;
		[Export ("dataOnlyRequested")]
		bool DataOnlyRequested { get; set; }

		// @property (assign, nonatomic) BTThreeDSecureCardAddChallenge cardAddChallenge;
		[Export ("cardAddChallenge", ArgumentSemantic.Assign)]
		BTThreeDSecureCardAddChallenge CardAddChallenge { get; set; }

		// @property (nonatomic, strong) int * _Nullable v2UICustomization;
		[NullAllowed, Export ("v2UICustomization", ArgumentSemantic.Strong)]
		unsafe int* V2UICustomization { get; set; }

		// @property (nonatomic, strong) BTThreeDSecureV1UICustomization * _Nullable v1UICustomization;
		[NullAllowed, Export ("v1UICustomization", ArgumentSemantic.Strong)]
		BTThreeDSecureV1UICustomization V1UICustomization { get; set; }

		[Wrap ("WeakThreeDSecureRequestDelegate")]
		[NullAllowed]
		BTThreeDSecureRequestDelegate ThreeDSecureRequestDelegate { get; set; }

		// @property (nonatomic, weak) id<BTThreeDSecureRequestDelegate> _Nullable threeDSecureRequestDelegate;
		[NullAllowed, Export ("threeDSecureRequestDelegate", ArgumentSemantic.Weak)]
		NSObject WeakThreeDSecureRequestDelegate { get; set; }
	}

	// @protocol BTThreeDSecureRequestDelegate
	[Protocol, Model (AutoGeneratedName = true)]
	interface BTThreeDSecureRequestDelegate
	{
		// @required -(void)onLookupComplete:(BTThreeDSecureRequest * _Nonnull)request lookupResult:(BTThreeDSecureResult * _Nonnull)result next:(void (^ _Nonnull)(void))next;
		[Abstract]
		[Export ("onLookupComplete:lookupResult:next:")]
		void LookupResult (BTThreeDSecureRequest request, BTThreeDSecureResult result, Action next);
	}

	// @interface BTThreeDSecureResult
	interface BTThreeDSecureResult
	{
		// @property (readonly, nonatomic, strong) BTCardNonce * _Nullable tokenizedCard;
		[NullAllowed, Export ("tokenizedCard", ArgumentSemantic.Strong)]
		BTCardNonce TokenizedCard { get; }

		// @property (readonly, nonatomic, strong) BTThreeDSecureLookup * _Nullable lookup;
		[NullAllowed, Export ("lookup", ArgumentSemantic.Strong)]
		BTThreeDSecureLookup Lookup { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable errorMessage;
		[NullAllowed, Export ("errorMessage")]
		string ErrorMessage { get; }
	}

	// @interface BTThreeDSecureV1UICustomization : NSObject
	[BaseType (typeof(NSObject))]
	interface BTThreeDSecureV1UICustomization
	{
		// @property (copy, nonatomic) NSString * _Nullable redirectButtonText;
		[NullAllowed, Export ("redirectButtonText")]
		string RedirectButtonText { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable redirectDescription;
		[NullAllowed, Export ("redirectDescription")]
		string RedirectDescription { get; set; }
	}

	// @interface BTThreeDSecureV2BaseCustomization : NSObject
	[BaseType (typeof(NSObject))]
	interface BTThreeDSecureV2BaseCustomization
	{
		// @property (nonatomic, strong) NSString * _Nonnull textFontName;
		[Export ("textFontName", ArgumentSemantic.Strong)]
		string TextFontName { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		string TextColor { get; set; }

		// @property (nonatomic) int textFontSize;
		[Export ("textFontSize")]
		int TextFontSize { get; set; }
	}

	// @interface BTThreeDSecureV2ButtonCustomization : BTThreeDSecureV2BaseCustomization
	[BaseType (typeof(BTThreeDSecureV2BaseCustomization))]
	interface BTThreeDSecureV2ButtonCustomization
	{
		// @property (nonatomic, strong) NSString * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		string BackgroundColor { get; set; }

		// @property (nonatomic) int cornerRadius;
		[Export ("cornerRadius")]
		int CornerRadius { get; set; }
	}

	// @interface BTThreeDSecureV2LabelCustomization : BTThreeDSecureV2BaseCustomization
	[BaseType (typeof(BTThreeDSecureV2BaseCustomization))]
	interface BTThreeDSecureV2LabelCustomization
	{
		// @property (nonatomic, strong) NSString * _Nonnull headingTextColor;
		[Export ("headingTextColor", ArgumentSemantic.Strong)]
		string HeadingTextColor { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull headingTextFontName;
		[Export ("headingTextFontName", ArgumentSemantic.Strong)]
		string HeadingTextFontName { get; set; }

		// @property (nonatomic) int headingTextFontSize;
		[Export ("headingTextFontSize")]
		int HeadingTextFontSize { get; set; }
	}

	// @interface BTThreeDSecureV2TextBoxCustomization : BTThreeDSecureV2BaseCustomization
	[BaseType (typeof(BTThreeDSecureV2BaseCustomization))]
	interface BTThreeDSecureV2TextBoxCustomization
	{
		// @property (nonatomic) int borderWidth;
		[Export ("borderWidth")]
		int BorderWidth { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull borderColor;
		[Export ("borderColor", ArgumentSemantic.Strong)]
		string BorderColor { get; set; }

		// @property (nonatomic) int cornerRadius;
		[Export ("cornerRadius")]
		int CornerRadius { get; set; }
	}

	// @interface BTThreeDSecureV2ToolbarCustomization : BTThreeDSecureV2BaseCustomization
	[BaseType (typeof(BTThreeDSecureV2BaseCustomization))]
	interface BTThreeDSecureV2ToolbarCustomization
	{
		// @property (nonatomic, strong) NSString * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		string BackgroundColor { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull headerText;
		[Export ("headerText", ArgumentSemantic.Strong)]
		string HeaderText { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull buttonText;
		[Export ("buttonText", ArgumentSemantic.Strong)]
		string ButtonText { get; set; }
	}

	// @interface BTThreeDSecureV2UICustomization : NSObject
	[BaseType (typeof(NSObject))]
	interface BTThreeDSecureV2UICustomization
	{
		// -(void)setButtonCustomization:(BTThreeDSecureV2ButtonCustomization * _Nonnull)buttonCustomization buttonType:(BTThreeDSecureV2ButtonType)buttonType;
		[Export ("setButtonCustomization:buttonType:")]
		void SetButtonCustomization (BTThreeDSecureV2ButtonCustomization buttonCustomization, BTThreeDSecureV2ButtonType buttonType);

		// @property (nonatomic, strong) BTThreeDSecureV2ToolbarCustomization * _Nonnull toolbarCustomization;
		[Export ("toolbarCustomization", ArgumentSemantic.Strong)]
		BTThreeDSecureV2ToolbarCustomization ToolbarCustomization { get; set; }

		// @property (nonatomic, strong) BTThreeDSecureV2LabelCustomization * _Nonnull labelCustomization;
		[Export ("labelCustomization", ArgumentSemantic.Strong)]
		BTThreeDSecureV2LabelCustomization LabelCustomization { get; set; }

		// @property (nonatomic, strong) BTThreeDSecureV2TextBoxCustomization * _Nonnull textBoxCustomization;
		[Export ("textBoxCustomization", ArgumentSemantic.Strong)]
		BTThreeDSecureV2TextBoxCustomization TextBoxCustomization { get; set; }
	}
}
