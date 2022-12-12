using System;
using BraintreeCard;
using Foundation;
using ObjCRuntime;
using BraintreeCore;

namespace BraintreeCard
{
	// @interface BTAuthenticationInsight : NSObject
	[BaseType (typeof(NSObject))]
	interface BTAuthenticationInsight
	{
		// @property (copy, nonatomic) NSString * _Nullable regulationEnvironment;
		[NullAllowed, Export ("regulationEnvironment")]
		string RegulationEnvironment { get; set; }
	}

	// @interface BTCard : NSObject
	[BaseType (typeof(NSObject))]
	interface BTCard
	{
		// @property (copy, nonatomic) NSString * _Nullable number;
		[NullAllowed, Export ("number")]
		string Number { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable expirationMonth;
		[NullAllowed, Export ("expirationMonth")]
		string ExpirationMonth { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable expirationYear;
		[NullAllowed, Export ("expirationYear")]
		string ExpirationYear { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable cvv;
		[NullAllowed, Export ("cvv")]
		string Cvv { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable cardholderName;
		[NullAllowed, Export ("cardholderName")]
		string CardholderName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName")]
		string FirstName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName")]
		string LastName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable company;
		[NullAllowed, Export ("company")]
		string Company { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable streetAddress;
		[NullAllowed, Export ("streetAddress")]
		string StreetAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable extendedAddress;
		[NullAllowed, Export ("extendedAddress")]
		string ExtendedAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable locality;
		[NullAllowed, Export ("locality")]
		string Locality { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable region;
		[NullAllowed, Export ("region")]
		string Region { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable countryName;
		[NullAllowed, Export ("countryName")]
		string CountryName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable countryCodeAlpha2;
		[NullAllowed, Export ("countryCodeAlpha2")]
		string CountryCodeAlpha2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable countryCodeAlpha3;
		[NullAllowed, Export ("countryCodeAlpha3")]
		string CountryCodeAlpha3 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable countryCodeNumeric;
		[NullAllowed, Export ("countryCodeNumeric")]
		string CountryCodeNumeric { get; set; }

		// @property (assign, nonatomic) BOOL shouldValidate;
		[Export ("shouldValidate")]
		bool ShouldValidate { get; set; }

		// @property (assign, nonatomic) BOOL authenticationInsightRequested;
		[Export ("authenticationInsightRequested")]
		bool AuthenticationInsightRequested { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable merchantAccountID;
		[NullAllowed, Export ("merchantAccountID")]
		string MerchantAccountID { get; set; }
	}

	// @interface BTCardClient : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BTCardClient
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
		[Export ("initWithAPIClient:")]
		[DesignatedInitializer]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)tokenizeCard:(BTCard * _Nonnull)card completion:(void (^ _Nonnull)(BTCardNonce * _Nullable, NSError * _Nullable))completion;
		[Export ("tokenizeCard:completion:")]
		void TokenizeCard (BTCard card, Action<BTCardNonce, NSError> completion);

		// -(void)tokenizeCard:(BTCardRequest * _Nonnull)request options:(NSDictionary * _Nullable)options completion:(void (^ _Nonnull)(BTCardNonce * _Nullable, NSError * _Nullable))completion;
		[Export ("tokenizeCard:options:completion:")]
		void TokenizeCard (BTCardRequest request, [NullAllowed] NSDictionary options, Action<BTCardNonce, NSError> completion);
	}

	// @interface BTCardNonce: BTPaymentMethodNonce
	[BaseType(typeof(BTPaymentMethodNonce))]
	interface BTCardNonce
	{
		// @property (readonly, assign, nonatomic) BTCardNetwork cardNetwork;
		[Export ("cardNetwork")]
		BTCardNetwork CardNetwork { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable expirationMonth;
		[NullAllowed, Export ("expirationMonth")]
		string ExpirationMonth { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable expirationYear;
		[NullAllowed, Export ("expirationYear")]
		string ExpirationYear { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable cardholderName;
		[NullAllowed, Export ("cardholderName")]
		string CardholderName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastTwo;
		[NullAllowed, Export ("lastTwo")]
		string LastTwo { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastFour;
		[NullAllowed, Export ("lastFour")]
		string LastFour { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable bin;
		[NullAllowed, Export ("bin")]
		string Bin { get; }

		// @property (readonly, nonatomic, strong) BTBinData * _Nonnull binData;
		[Export ("binData", ArgumentSemantic.Strong)]
		unsafe BTBinData BinData { get; }

		// @property (readonly, nonatomic, strong) BTThreeDSecureInfo * _Nonnull threeDSecureInfo;
		[Export ("threeDSecureInfo", ArgumentSemantic.Strong)]
		BTThreeDSecureInfo ThreeDSecureInfo { get; }

		// @property (readonly, nonatomic, strong) BTAuthenticationInsight * _Nullable authenticationInsight;
		[NullAllowed, Export ("authenticationInsight", ArgumentSemantic.Strong)]
		BTAuthenticationInsight AuthenticationInsight { get; }
	}

	// @interface BTCardRequest : NSObject
	[BaseType (typeof(NSObject))]
	interface BTCardRequest
	{
		// -(instancetype _Nonnull)initWithCard:(BTCard * _Nonnull)card;
		[Export ("initWithCard:")]
		IntPtr Constructor (BTCard card);

		// @property (nonatomic, strong) BTCard * _Nonnull card;
		[Export ("card", ArgumentSemantic.Strong)]
		BTCard Card { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable mobilePhoneNumber;
		[NullAllowed, Export ("mobilePhoneNumber")]
		string MobilePhoneNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable mobileCountryCode;
		[NullAllowed, Export ("mobileCountryCode")]
		string MobileCountryCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable smsCode;
		[NullAllowed, Export ("smsCode")]
		string SmsCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable enrollmentID;
		[NullAllowed, Export ("enrollmentID")]
		string EnrollmentID { get; set; }
	}

	// @interface BTThreeDSecureInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface BTThreeDSecureInfo
	{
		// -(instancetype _Nonnull)initWithJSON:(BTJSON * _Nonnull)json;
		[Export ("initWithJSON:")]
		IntPtr Constructor (BTJSON json);

		// @property (readonly, nonatomic) NSString * _Nullable acsTransactionID;
		[NullAllowed, Export ("acsTransactionID")]
		string AcsTransactionID { get; }

		// @property (readonly, nonatomic) NSString * _Nullable authenticationTransactionStatus;
		[NullAllowed, Export ("authenticationTransactionStatus")]
		string AuthenticationTransactionStatus { get; }

		// @property (readonly, nonatomic) NSString * _Nullable authenticationTransactionStatusReason;
		[NullAllowed, Export ("authenticationTransactionStatusReason")]
		string AuthenticationTransactionStatusReason { get; }

		// @property (readonly, nonatomic) NSString * _Nullable cavv;
		[NullAllowed, Export ("cavv")]
		string Cavv { get; }

		// @property (readonly, nonatomic) NSString * _Nullable dsTransactionID;
		[NullAllowed, Export ("dsTransactionID")]
		string DsTransactionID { get; }

		// @property (readonly, nonatomic) NSString * _Nullable eciFlag;
		[NullAllowed, Export ("eciFlag")]
		string EciFlag { get; }

		// @property (readonly, nonatomic) NSString * _Nullable enrolled;
		[NullAllowed, Export ("enrolled")]
		string Enrolled { get; }

		// @property (readonly, assign, nonatomic) BOOL liabilityShifted;
		[Export ("liabilityShifted")]
		bool LiabilityShifted { get; }

		// @property (readonly, assign, nonatomic) BOOL liabilityShiftPossible;
		[Export ("liabilityShiftPossible")]
		bool LiabilityShiftPossible { get; }

		// @property (readonly, nonatomic) NSString * _Nullable lookupTransactionStatus;
		[NullAllowed, Export ("lookupTransactionStatus")]
		string LookupTransactionStatus { get; }

		// @property (readonly, nonatomic) NSString * _Nullable lookupTransactionStatusReason;
		[NullAllowed, Export ("lookupTransactionStatusReason")]
		string LookupTransactionStatusReason { get; }

		// @property (readonly, nonatomic) NSString * _Nullable paresStatus;
		[NullAllowed, Export ("paresStatus")]
		string ParesStatus { get; }

		// @property (readonly, nonatomic) NSString * _Nullable status;
		[NullAllowed, Export ("status")]
		string Status { get; }

		// @property (readonly, nonatomic) NSString * _Nullable threeDSecureAuthenticationID;
		[NullAllowed, Export ("threeDSecureAuthenticationID")]
		string ThreeDSecureAuthenticationID { get; }

		// @property (readonly, nonatomic) NSString * _Nullable threeDSecureServerTransactionID;
		[NullAllowed, Export ("threeDSecureServerTransactionID")]
		string ThreeDSecureServerTransactionID { get; }

		// @property (readonly, nonatomic) NSString * _Nullable threeDSecureVersion;
		[NullAllowed, Export ("threeDSecureVersion")]
		string ThreeDSecureVersion { get; }

		// @property (readonly, assign, nonatomic) BOOL wasVerified;
		[Export ("wasVerified")]
		bool WasVerified { get; }

		// @property (readonly, nonatomic) NSString * _Nullable xid;
		[NullAllowed, Export ("xid")]
		string Xid { get; }
	}
}
