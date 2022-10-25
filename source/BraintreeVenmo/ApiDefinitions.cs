using System;
using BraintreeVenmo;
using Foundation;
using ObjCRuntime;
using BraintreeCore;

namespace BraintreeVenmo
{
	// @interface BTConfiguration (Venmo)
	[Category]
	[BaseType(typeof(BTConfiguration))]
	interface BTConfiguration_Venmo
	{
		// @property (readonly, assign, nonatomic) int isVenmoEnabled;
		[Export("isVenmoEnabled")]
		int IsVenmoEnabled();

		// @property (readonly, nonatomic, strong) NSString * venmoAccessToken;
		[Export ("venmoAccessToken", ArgumentSemantic.Strong)]
		unsafe string VenmoAccessToken();

		// @property (readonly, nonatomic, strong) NSString * venmoMerchantID;
		[Export("venmoMerchantID", ArgumentSemantic.Strong)]
		unsafe string VenmoMerchantID();

		// @property (readonly, nonatomic, strong) NSString * venmoEnvironment;
		[Export("venmoEnvironment", ArgumentSemantic.Strong)]
		unsafe string VenmoEnvironment();
	}

	// @interface BTVenmoAccountNonce : BTPaymentMethodNonce
	[BaseType(typeof(BTPaymentMethodNonce))]
	interface BTVenmoAccountNonce
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Copy)]
		unsafe string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable externalId;
		[NullAllowed, Export ("externalId", ArgumentSemantic.Copy)]
		unsafe string ExternalId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName", ArgumentSemantic.Copy)]
		unsafe string FirstName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName", ArgumentSemantic.Copy)]
		unsafe string LastName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phoneNumber;
		[NullAllowed, Export ("phoneNumber", ArgumentSemantic.Copy)]
		unsafe string PhoneNumber { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable username;
		[NullAllowed, Export ("username", ArgumentSemantic.Copy)]
		unsafe string Username { get; }
	}

	// @interface BTVenmoDriver
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface BTVenmoDriver
	{
		// -(instancetype)initWithAPIClient:(id)apiClient;
		[Export ("initWithAPIClient:")]
		IntPtr Constructor (NSObject apiClient);

		// -(void)tokenizeVenmoAccountWithVenmoRequest:(id)venmoRequest completion:(void (^)(BTVenmoAccountNonce * _Nullable, NSError * _Nullable))completionBlock;
		[Export ("tokenizeVenmoAccountWithVenmoRequest:completion:")]
		unsafe void TokenizeVenmoAccountWithVenmoRequest (NSObject venmoRequest, Action<BTVenmoAccountNonce, NSError> completionBlock);

		// -(id)isiOSAppAvailableForAppSwitch;
		[Export ("isiOSAppAvailableForAppSwitch")]
		NSObject IsiOSAppAvailableForAppSwitch { get; }

		// -(void)openVenmoAppPageInAppStore;
		[Export ("openVenmoAppPageInAppStore")]
		void OpenVenmoAppPageInAppStore ();
	}

	// @interface BTVenmoRequest : NSObject
	[BaseType (typeof(NSObject))]
	interface BTVenmoRequest
	{
		// @property (copy, nonatomic) NSString * _Nullable profileID;
		[NullAllowed, Export ("profileID")]
		string ProfileID { get; set; }

		// @property (nonatomic) BOOL vault;
		[Export ("vault")]
		bool Vault { get; set; }

		// @property (nonatomic) BTVenmoPaymentMethodUsage paymentMethodUsage;
		[Export ("paymentMethodUsage", ArgumentSemantic.Assign)]
		BTVenmoPaymentMethodUsage PaymentMethodUsage { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; set; }
	}
}
