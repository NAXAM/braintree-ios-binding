using System;
using BraintreeCard;
using BraintreeCore;
using Foundation;
using ObjCRuntime;

namespace BraintreeCard
{
	//[Static]
	//partial interface Constants
	//{
	//	// extern double BraintreeCardVersionNumber;
	//	[Field ("BraintreeCardVersionNumber", "__Internal")]
	//	double BraintreeCardVersionNumber { get; }

	//	// extern const unsigned char [] BraintreeCardVersionString;
	//	[Field ("BraintreeCardVersionString", "__Internal")]
	//	byte[] BraintreeCardVersionString { get; }
	//}

	// @interface BTCard : NSObject
	[BaseType (typeof(NSObject))]
	interface BTCard
	{
		// -(instancetype _Nonnull)initWithNumber:(NSString * _Nonnull)number expirationMonth:(NSString * _Nonnull)expirationMonth expirationYear:(NSString * _Nonnull)expirationYear cvv:(NSString * _Nullable)cvv;
		[Export ("initWithNumber:expirationMonth:expirationYear:cvv:")]
		IntPtr Constructor (string number, string expirationMonth, string expirationYear, [NullAllowed] string cvv);

		// -(instancetype _Nonnull)initWithParameters:(NSDictionary * _Nonnull)parameters __attribute__((objc_designated_initializer));
		[Export ("initWithParameters:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSDictionary parameters);

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

		// @property (copy, nonatomic) NSString * _Nullable streetAddress;
		[NullAllowed, Export ("streetAddress")]
		string StreetAddress { get; set; }

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

		// @property (assign, nonatomic) BOOL shouldValidate;
		[Export ("shouldValidate")]
		bool ShouldValidate { get; set; }
	}

	// @interface BTCardNonce : BTPaymentMethodNonce
	[BaseType (typeof(BTPaymentMethodNonce))]
	interface BTCardNonce
	{
		// @property (readonly, assign, nonatomic) BTCardNetwork cardNetwork;
		[Export ("cardNetwork", ArgumentSemantic.Assign)]
		BTCardNetwork CardNetwork { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastTwo;
		[NullAllowed, Export ("lastTwo")]
		string LastTwo { get; }

		// +(instancetype _Nonnull)cardNonceWithJSON:(BTJSON * _Nonnull)cardJSON;
		[Static]
		[Export ("cardNonceWithJSON:")]
		BTCardNonce CardNonceWithJSON (BTJSON cardJSON);
	}

	[Static]
	partial interface BTCardClientConstants
	{
		// extern NSString *const _Nonnull BTCardClientErrorDomain;
		[Field ("BTCardClientErrorDomain", "__Internal")]
		NSString ErrorDomain { get; }
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
}