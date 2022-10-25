using System;
using BraintreeVenmo;
using Foundation;
using ObjCRuntime;

namespace BraintreeVenmo
{
	// @interface Venmo
	interface Venmo
	{
		// @property (readonly, assign, nonatomic) int isVenmoEnabled;
		[Export ("isVenmoEnabled")]
		int IsVenmoEnabled { }

		// @property (readonly, nonatomic, strong) int * venmoAccessToken;
		[Export ("venmoAccessToken", ArgumentSemantic.Strong)]
		unsafe int* VenmoAccessToken { }

		// @property (readonly, nonatomic, strong) int * venmoMerchantID;
		[Export ("venmoMerchantID", ArgumentSemantic.Strong)]
		unsafe int* VenmoMerchantID { }

		// @property (readonly, nonatomic, strong) int * venmoEnvironment;
		[Export ("venmoEnvironment", ArgumentSemantic.Strong)]
		unsafe int* VenmoEnvironment { }
	}

	// @interface BTVenmoAccountNonce
	interface BTVenmoAccountNonce
	{
		// @property (readonly, copy, nonatomic) int * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Copy)]
		unsafe int* Email { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable externalId;
		[NullAllowed, Export ("externalId", ArgumentSemantic.Copy)]
		unsafe int* ExternalId { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable firstName;
		[NullAllowed, Export ("firstName", ArgumentSemantic.Copy)]
		unsafe int* FirstName { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable lastName;
		[NullAllowed, Export ("lastName", ArgumentSemantic.Copy)]
		unsafe int* LastName { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable phoneNumber;
		[NullAllowed, Export ("phoneNumber", ArgumentSemantic.Copy)]
		unsafe int* PhoneNumber { get; }

		// @property (readonly, copy, nonatomic) int * _Nullable username;
		[NullAllowed, Export ("username", ArgumentSemantic.Copy)]
		unsafe int* Username { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }
	}

	// @interface BTVenmoDriver
	[DisableDefaultCtor]
	interface BTVenmoDriver
	{
		// -(instancetype)initWithAPIClient:(id)apiClient;
		[Export ("initWithAPIClient:")]
		IntPtr Constructor (NSObject apiClient);

		// -(void)tokenizeVenmoAccountWithVenmoRequest:(id)venmoRequest completion:(void (^)(BTVenmoAccountNonce * _Nullable, int * _Nullable))completionBlock;
		[Export ("tokenizeVenmoAccountWithVenmoRequest:completion:")]
		unsafe void TokenizeVenmoAccountWithVenmoRequest (NSObject venmoRequest, Action<BTVenmoAccountNonce, int*> completionBlock);

		// -(id)isiOSAppAvailableForAppSwitch;
		[Export ("isiOSAppAvailableForAppSwitch")]
		[Verify (MethodToProperty)]
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

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreeVenmoVersionNumber;
		[Field ("BraintreeVenmoVersionNumber", "__Internal")]
		double BraintreeVenmoVersionNumber { get; }

		// extern const unsigned char [] BraintreeVenmoVersionString;
		[Field ("BraintreeVenmoVersionString", "__Internal")]
		byte[] BraintreeVenmoVersionString { get; }
	}
}
