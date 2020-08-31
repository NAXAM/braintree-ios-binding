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

    [BaseType(typeof(NSObject))]
    interface BTAuthenticationInsight
    {
        // @property (nonatomic, nullable, copy) NSString *regulationEnvironment;
        [NullAllowed, Export("regulationEnvironment")]
        string RegulationEnvironment { get; set; }

        // - (instancetype)initWithJSON:(BTJSON *)json;
        [Export("initWithJSON:")]
        IntPtr Constructor(BTJSON json);

    }

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

        // @property (nonatomic, assign) BOOL authenticationInsightRequested;
        [Export("authenticationInsightRequested")]
        bool AuthenticationInsightRequested { get; set; }


        // @property (nonatomic, nullable, copy) NSString *merchantAccountId;
        [NullAllowed, Export("merchantAccountId")]
        string MerchantAccountId { get; set; }

        // Internal APIs
        // // - (NSDictionary *)parameters;
        // [NullAllowed, Export("parameters")]
        // string Parameters { get; set; }

        // // - (NSDictionary *)graphQLParameters;
        // [NullAllowed, Export("graphQLParameters")]
        // string GraphQLParameters { get; set; }

        // // extern NSString * const BTCardGraphQLTokenizationMutation;
        // [Field("BTCardGraphQLTokenizationMutation", "__Internal")]
        // NSString BTCardGraphQLTokenizationMutation { get; }

        // // extern NSString * const BTCardGraphQLTokenizationWithAuthenticationInsightMutation;
        // [Field("BTCardGraphQLTokenizationWithAuthenticationInsightMutation", "__Internal")]
        // NSString BTCardGraphQLTokenizationWithAuthenticationInsightMutation { get; }
    }

    // @interface BTCardNonce : BTPaymentMethodNonce
    [BaseType(typeof(BTPaymentMethodNonce))]
    interface BTCardNonce
    {
        // @property (readonly, assign, nonatomic) BTCardNetwork cardNetwork;
        [Export("cardNetwork", ArgumentSemantic.Assign)]
        BTCardNetwork CardNetwork { get; }
        
        // @property (nonatomic, nullable, readonly, copy) NSString *expirationMonth;
        [Export("expirationMonth", ArgumentSemantic.Copy)]
        string ExpirationMonth { get; }

        // @property (nonatomic, nullable, readonly, copy) NSString *expirationYear;
        [Export("expirationYear", ArgumentSemantic.Copy)]
        string ExpirationYear { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable lastTwo;
        [NullAllowed, Export("lastTwo", ArgumentSemantic.Copy)]
        string LastTwo { get; }

        // @property (nonatomic, nullable, readonly, copy) NSString *lastFour;
        [NullAllowed, Export("lastFour", ArgumentSemantic.Strong)]
        string LastFour { get; }

        // @property (nonatomic, nullable, readonly, copy) NSString *bin;
        [NullAllowed, Export("bin", ArgumentSemantic.Strong)]
        string Bin { get; }

        // @property (nonatomic, readonly, strong) BTBinData *binData;
        [Export("binData", ArgumentSemantic.Strong)]
        BTBinData BinData { get; }

        // /**
        // @brief The 3D Secure info for the card number associated with this nonce.
        // */
        // @property (nonatomic, readonly, strong) BTThreeDSecureInfo *threeDSecureInfo;
        [Export("threeDSecureInfo", ArgumentSemantic.Strong)]
        BTThreeDSecureInfo ThreeDSecureInfo { get; }

        // @property (nonatomic, nullable, readonly, strong) BTAuthenticationInsight *authenticationInsight;
        [NullAllowed, Export("authenticationInsight", ArgumentSemantic.Strong)]
        BTAuthenticationInsight AuthenticationInsight { get; }
// - (instancetype)initWithNonce:(nonnull NSString *)nonce
//                   description:(nullable NSString *)description
//                   cardNetwork:(BTCardNetwork)cardNetwork
//               expirationMonth:(nullable NSString *)expirationMonth
//                expirationYear:(nullable NSString *)expirationYear
//                       lastTwo:(nullable NSString *)lastTwo
//                      lastFour:(nullable NSString *)lastFour
//                     isDefault:(BOOL)isDefault
//                      cardJSON:(BTJSON *)cardJSON
//               authInsightJSON:(nullable BTJSON *)authInsightJSON;
        [Export("initWithNonce:description:cardNetwork:expirationMonth:expirationYear:lastTwo:lastFour:isDefault:cardJSON:authInsightJSON:")]
        IntPtr Constructor(
            string nonce, [NullAllowed] string description, BTCardNetwork cardNetwork, 
            [NullAllowed] string expirationMonth, [NullAllowed] string expirationYear, 
            [NullAllowed] string lastTwo, [NullAllowed] string lastFour, bool isDefault,
            BTJSON cardJSON, [NullAllowed] BTJSON authInsightJSON);

        // + (instancetype)cardNonceWithJSON:(BTJSON *)cardJSON;
        [Static]
        [Export("cardNonceWithJSON:")]
        BTCardNonce CardNonceWithJSON(BTJSON cardJSON);

        // + (instancetype)cardNonceWithGraphQLJSON:(BTJSON *)json;
        [Static]
        [Export("cardNonceWithGraphQLJSON:")]
        BTCardNonce cardNonceWithGraphQLJSON(BTJSON cardJSON);
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

        // + (NSDictionary *)validationErrorUserInfo:(NSDictionary *)userInfo;
        [Export("validationErrorUserInfo:")]
        void ValidationErrorUserInfo(NSDictionary userInfo);

        // + (void)setPayPalDataCollectorClassString:(nonnull NSString *)payPalDataCollectorClassString;
        [Export("setPayPalDataCollectorClassString:")]
        void SetPayPalDataCollectorClassString(string payPalDataCollectorClassString);

        // + (void)setPayPalDataCollectorClass:(nonnull Class)payPalDataCollectorClass;
        [Export("setPayPalDataCollectorClass:")]
        void SetPayPalDataCollectorClass(Class payPalDataCollectorClass);
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

    [Category]
	[BaseType (typeof(BTConfiguration))]
    interface BTConfiguration_Card {
        // @property (nonatomic, readonly, assign) BOOL collectFraudData;
        [Export("collectFraudData")]
        bool GetCollectFraudData();
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

        // @property (nonatomic, readonly, nullable) NSString *acsTransactionId;
        [NullAllowed, Export("acsTransactionId", ArgumentSemantic.None)]
        string acsTransactionId { get; }

        // @property (nonatomic, readonly, nullable) NSString *authenticationTransactionStatus;
        [NullAllowed, Export("authenticationTransactionStatus", ArgumentSemantic.None)]
        string AuthenticationTransactionStatus { get; }

        // @property (nonatomic, readonly, nullable) NSString *authenticationTransactionStatusReason;
        [NullAllowed, Export("authenticationTransactionStatusReason", ArgumentSemantic.None)]
        string AuthenticationTransactionStatusReason { get; }

        // @property (nonatomic, readonly, nullable) NSString *cavv;
        [NullAllowed,Export("cavv", ArgumentSemantic.None)]
        string Cavv { get; }

        // @property (nonatomic, readonly, nullable) NSString *dsTransactionId;
        [NullAllowed, Export("dsTransactionId", ArgumentSemantic.None)]
        string DsTransactionId { get; }

        // @property (nonatomic, readonly, nullable) NSString *eciFlag;
        [Export("eciFlag", ArgumentSemantic.None)]
        string EciFlag { get; }

        // @property (nonatomic, readonly, nullable) NSString *enrolled;
        [Export("enrolled", ArgumentSemantic.None)]
        bool Enrolled { get; }

        // @property (nonatomic, readonly, assign) BOOL liabilityShifted;
        [Export("liabilityShifted", ArgumentSemantic.None)]
        bool LiabilityShifted { get; }

        // @property (nonatomic, readonly, nullable) NSString *lookupTransactionStatus;
        [NullAllowed, Export("lookupTransactionStatus", ArgumentSemantic.None)]
        string LookupTransactionStatus { get; }

        // @property (nonatomic, readonly, nullable) NSString *lookupTransactionStatusReason;
        [NullAllowed, Export("lookupTransactionStatusReason", ArgumentSemantic.None)]
        string LookupTransactionStatusReason { get; }

        // @property (nonatomic, readonly, nullable) NSString *paresStatus;
        [NullAllowed, Export("paresStatus", ArgumentSemantic.None)]
        string ParesStatus { get; }

        // @property (nonatomic, readonly, nullable) NSString *status;
        [NullAllowed, Export("status", ArgumentSemantic.None)]
        string Status { get; }

        // @property (nonatomic, readonly, nullable) NSString *threeDSecureAuthenticationId;
        [NullAllowed, Export("threeDSecureAuthenticationId", ArgumentSemantic.None)]
        string ThreeDSecureAuthenticationId { get; }

        // @property (nonatomic, readonly, nullable) NSString *threeDSecureServerTransactionId;
        [NullAllowed, Export("threeDSecureServerTransactionId", ArgumentSemantic.None)]
        string ThreeDSecureServerTransactionId { get; }

        // @property (nonatomic, readonly, nullable) NSString *threeDSecureVersion;
        [NullAllowed, Export("threeDSecureVersion", ArgumentSemantic.None)]
        string ThreeDSecureVersion { get; }

        // @property (nonatomic, readonly, assign) BOOL liabilityShiftPossible;
        [Export("liabilityShiftPossible", ArgumentSemantic.Assign)]
        bool LiabilityShiftPossible { get; }

        // /**
        //  @brief If the 3D Secure lookup was performed
        //  */
        // @property (nonatomic, readonly, assign) BOOL wasVerified;
        [Export("wasVerified", ArgumentSemantic.Assign)]
        bool WasVerified { get; }
        
        // @property (nonatomic, readonly, nullable) NSString *xid;
        [NullAllowed, Export("xid", ArgumentSemantic.None)]
        string Xid { get; }

        // @property (nonatomic, nullable, copy) NSString *errorMessage;
        [NullAllowed, Export("errorMessage", ArgumentSemantic.None)]
        string ErrorMessage { get; }
    }
}