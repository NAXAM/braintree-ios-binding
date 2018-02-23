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
    [BaseType(typeof(NSObject))]
    interface BTCard
    {
        // -(instancetype _Nonnull)initWithNumber:(NSString * _Nonnull)number expirationMonth:(NSString * _Nonnull)expirationMonth expirationYear:(NSString * _Nonnull)expirationYear cvv:(NSString * _Nullable)cvv;
        [Export("initWithNumber:expirationMonth:expirationYear:cvv:")]
        IntPtr Constructor(string number, string expirationMonth, string expirationYear, [NullAllowed] string cvv);

        // -(instancetype _Nonnull)initWithParameters:(NSDictionary * _Nonnull)parameters __attribute__((objc_designated_initializer));
        [Export("initWithParameters:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSDictionary parameters);
 
        // @property (copy, nonatomic) NSString * _Nullable number;
        [NullAllowed, Export("number")]
        string Number { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable expirationMonth;
        [NullAllowed, Export("expirationMonth")]
        string ExpirationMonth { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable expirationYear;
        [NullAllowed, Export("expirationYear")]
        string ExpirationYear { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable cvv;
        [NullAllowed, Export("cvv")]
        string Cvv { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable cardholderName;
        [NullAllowed, Export("cardholderName")]
        string CardholderName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable streetAddress;
        [NullAllowed, Export("streetAddress")]
        string StreetAddress { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable locality;
        [NullAllowed, Export("locality")]
        string Locality { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable region;
        [NullAllowed, Export("region")]
        string Region { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable countryName;
        [NullAllowed, Export("countryName")]
        string CountryName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable countryCodeAlpha2;
        [NullAllowed, Export("countryCodeAlpha2")]
        string CountryCodeAlpha2 { get; set; }

        // @property (assign, nonatomic) BOOL shouldValidate;
        [Export("shouldValidate")]
        bool ShouldValidate { get; set; }

        // @property (nonatomic, nullable, copy) NSString *firstName;
        [NullAllowed, Export("firstName")]
        string FirstName { get; set; }

        // @property (nonatomic, nullable, copy) NSString *lastName;
        [NullAllowed, Export("lastName")]
        string LastName { get; set; }

        //@property (nonatomic, nullable, copy) NSString *company;
        [NullAllowed, Export("company")]
        string Company { get; set; }

        //@property (nonatomic, nullable, copy) NSString *extendedAddress;
        [NullAllowed, Export("extendedAddress")]
        string ExtendedAddress { get; set; }

        //@property (nonatomic, nullable, copy) NSString *countryCodeAlpha3;
        [NullAllowed, Export("countryCodeAlpha3")]
        string CountryCodeAlpha3 { get; set; }

        //@property (nonatomic, nullable, copy) NSString *countryCodeNumeric;
        [NullAllowed, Export("countryCodeNumeric")]
        string CountryCodeNumeric { get; set; }
    }

    // @interface BTCardNonce : BTPaymentMethodNonce
    [BaseType(typeof(BTPaymentMethodNonce))]
    interface BTCardNonce
    {
        // @property (readonly, assign, nonatomic) BTCardNetwork cardNetwork;
        [Export("cardNetwork", ArgumentSemantic.Assign)]
        BTCardNetwork CardNetwork { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable lastTwo;
        [NullAllowed, Export("lastTwo", ArgumentSemantic.Copy)]
        string LastTwo { get; }

        // @property (nonatomic, readonly, strong) BTBinData *binData;
        [Export("binData", ArgumentSemantic.Strong)]
        BTBinData BinData { get; }

        // +(instancetype _Nonnull)cardNonceWithJSON:(BTJSON * _Nonnull)cardJSON;
        [Static]
        [Export("cardNonceWithJSON:")]
        BTCardNonce CardNonceWithJSON(BTJSON cardJSON);

        // /**
        // @brief The 3D Secure info for the card number associated with this nonce.
        // */
        // @property (nonatomic, readonly, strong) BTThreeDSecureInfo *threeDSecureInfo;
        [Export("threeDSecureInfo", ArgumentSemantic.Strong)]
        BTThreeDSecureInfo ThreeDSecureInfo { get; }
    }

    [Static]
    partial interface BTCardClientConstants
    {
        // extern NSString *const _Nonnull BTCardClientErrorDomain;
        [Field("BTCardClientErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }
    }

    // @interface BTCardClient : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BTCardClient
    {
        // -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient __attribute__((objc_designated_initializer));
        [Export("initWithAPIClient:")]
        [DesignatedInitializer]
        IntPtr Constructor(BTAPIClient apiClient);

        // -(void)tokenizeCard:(BTCard * _Nonnull)card completion:(void (^ _Nonnull)(BTCardNonce * _Nullable, NSError * _Nullable))completion;
        [Export("tokenizeCard:completion:")]
        void TokenizeCard(BTCard card, Action<BTCardNonce, NSError> completion);

        // -(void)tokenizeCard:(BTCardRequest * _Nonnull)request options:(NSDictionary * _Nullable)options completion:(void (^ _Nonnull)(BTCardNonce * _Nullable, NSError * _Nullable))completion;
        [Export("tokenizeCard:options:completion:")]
        void TokenizeCard(BTCardRequest request, [NullAllowed] NSDictionary options, Action<BTCardNonce, NSError> completion);
    }

    // @interface BTCardRequest : NSObject
    [BaseType(typeof(NSObject))]
    interface BTCardRequest
    {
        // -(instancetype _Nonnull)initWithCard:(BTCard * _Nonnull)card;
        [Export("initWithCard:")]
        IntPtr Constructor(BTCard card);

        // @property (nonatomic, strong) BTCard * _Nonnull card;
        [Export("card", ArgumentSemantic.Strong)]
        BTCard Card { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable mobilePhoneNumber;
        [NullAllowed, Export("mobilePhoneNumber")]
        string MobilePhoneNumber { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable mobileCountryCode;
        [NullAllowed, Export("mobileCountryCode")]
        string MobileCountryCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable smsCode;
        [NullAllowed, Export("smsCode")]
        string SmsCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable enrollmentID;
        [NullAllowed, Export("enrollmentID")]
        string EnrollmentID { get; set; }
    }

    // @interface BTThreeDSecureInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface BTThreeDSecureInfo  {
        // /**
        //  @brief Create a `BTThreeDSecureInfo` object from JSON.
        //  */
        // - (instancetype)initWithJSON:(BTJSON *)json;
        [Export("initWithJSON:")]
        IntPtr Constructor(BTJSON json);

        // /**
        //  @brief If the 3D Secure liability shift has occurred
        //  */
        // @property (nonatomic, readonly, assign) BOOL liabilityShifted;
        [Export("liabilityShifted", ArgumentSemantic.Assign)]
        bool LiabilityShifted { get; }

        // /**
        //  @brief If the 3D Secure liability shift is possible
        //  */
        // @property (nonatomic, readonly, assign) BOOL liabilityShiftPossible;
        [Export("liabilityShiftPossible", ArgumentSemantic.Assign)]
        bool LiabilityShiftPossible { get; }

        // /**
        //  @brief If the 3D Secure lookup was performed
        //  */
        // @property (nonatomic, readonly, assign) BOOL wasVerified;
        [Export("wasVerified", ArgumentSemantic.Assign)]
        bool WasVerified { get; }
    }
}