using System;
using BraintreeCard;
using BraintreeUnionPay;
using Foundation;

namespace BraintreeUnionPay
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreeCoreVersionNumber;
		[Field ("BraintreeCoreVersionNumber", "__Internal")]
		double BraintreeCoreVersionNumber { get; }

		// extern const unsigned char [] BraintreeCoreVersionString;
		[Field ("BraintreeCoreVersionString", "__Internal")]
		byte[] BraintreeCoreVersionString { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTJSONErrorDomain;
		[Field ("BTJSONErrorDomain", "__Internal")]
		NSString BTJSONErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTAPIClientErrorDomain;
		[Field ("BTAPIClientErrorDomain", "__Internal")]
		NSString BTAPIClientErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTAppSwitchWillSwitchNotification;
		[Field ("BTAppSwitchWillSwitchNotification", "__Internal")]
		NSString BTAppSwitchWillSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchDidSwitchNotification;
		[Field ("BTAppSwitchDidSwitchNotification", "__Internal")]
		NSString BTAppSwitchDidSwitchNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchWillProcessPaymentInfoNotification;
		[Field ("BTAppSwitchWillProcessPaymentInfoNotification", "__Internal")]
		NSString BTAppSwitchWillProcessPaymentInfoNotification { get; }

		// extern NSString *const _Nonnull BTAppSwitchNotificationTargetKey;
		[Field ("BTAppSwitchNotificationTargetKey", "__Internal")]
		NSString BTAppSwitchNotificationTargetKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTClientTokenKeyVersion;
		[Field ("BTClientTokenKeyVersion", "__Internal")]
		NSString BTClientTokenKeyVersion { get; }

		// extern NSString *const _Nonnull BTClientTokenErrorDomain;
		[Field ("BTClientTokenErrorDomain", "__Internal")]
		NSString BTClientTokenErrorDomain { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyAuthorizationFingerprint;
		[Field ("BTClientTokenKeyAuthorizationFingerprint", "__Internal")]
		NSString BTClientTokenKeyAuthorizationFingerprint { get; }

		// extern NSString *const _Nonnull BTClientTokenKeyConfigURL;
		[Field ("BTClientTokenKeyConfigURL", "__Internal")]
		NSString BTClientTokenKeyConfigURL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTCustomerInputBraintreeValidationErrorsKey;
		[Field ("BTCustomerInputBraintreeValidationErrorsKey", "__Internal")]
		NSString BTCustomerInputBraintreeValidationErrorsKey { get; }

		// extern NSString *const BTHTTPErrorDomain;
		[Field ("BTHTTPErrorDomain", "__Internal")]
		NSString BTHTTPErrorDomain { get; }

		// extern NSString *const BTHTTPURLResponseKey;
		[Field ("BTHTTPURLResponseKey", "__Internal")]
		NSString BTHTTPURLResponseKey { get; }

		// extern NSString *const BTHTTPJSONResponseBodyKey;
		[Field ("BTHTTPJSONResponseBodyKey", "__Internal")]
		NSString BTHTTPJSONResponseBodyKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull BTTokenizationServiceErrorDomain;
		[Field ("BTTokenizationServiceErrorDomain", "__Internal")]
		NSString BTTokenizationServiceErrorDomain { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceAppSwitchDelegateOption;
		[Field ("BTTokenizationServiceAppSwitchDelegateOption", "__Internal")]
		NSString BTTokenizationServiceAppSwitchDelegateOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceViewPresentingDelegateOption;
		[Field ("BTTokenizationServiceViewPresentingDelegateOption", "__Internal")]
		NSString BTTokenizationServiceViewPresentingDelegateOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServicePayPalScopesOption;
		[Field ("BTTokenizationServicePayPalScopesOption", "__Internal")]
		NSString BTTokenizationServicePayPalScopesOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceAmountOption;
		[Field ("BTTokenizationServiceAmountOption", "__Internal")]
		NSString BTTokenizationServiceAmountOption { get; }

		// extern NSString *const _Nonnull BTTokenizationServiceNonceOption;
		[Field ("BTTokenizationServiceNonceOption", "__Internal")]
		NSString BTTokenizationServiceNonceOption { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreeCardVersionNumber;
		[Field ("BraintreeCardVersionNumber", "__Internal")]
		double BraintreeCardVersionNumber { get; }

		// extern const unsigned char [] BraintreeCardVersionString;
		[Field ("BraintreeCardVersionString", "__Internal")]
		byte[] BraintreeCardVersionString { get; }

		// extern NSString *const _Nonnull BTCardClientErrorDomain;
		[Field ("BTCardClientErrorDomain", "__Internal")]
		NSString BTCardClientErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double BraintreeUnionPayVersionNumber;
		[Field ("BraintreeUnionPayVersionNumber", "__Internal")]
		double BraintreeUnionPayVersionNumber { get; }

		// extern const unsigned char [] BraintreeUnionPayVersionString;
		[Field ("BraintreeUnionPayVersionString", "__Internal")]
		byte[] BraintreeUnionPayVersionString { get; }
	}

	// @interface BTCardCapabilities : NSObject
	[BaseType (typeof(NSObject))]
	interface BTCardCapabilities
	{
		// @property (assign, nonatomic) BOOL isUnionPay;
		[Export ("isUnionPay")]
		bool IsUnionPay { get; set; }

		// @property (assign, nonatomic) BOOL isDebit;
		[Export ("isDebit")]
		bool IsDebit { get; set; }

		// @property (assign, nonatomic) BOOL supportsTwoStepAuthAndCapture;
		[Export ("supportsTwoStepAuthAndCapture")]
		bool SupportsTwoStepAuthAndCapture { get; set; }

		// @property (assign, nonatomic) BOOL isSupported;
		[Export ("isSupported")]
		bool IsSupported { get; set; }
	}

	// @interface UnionPay (BTCardClient)
	[Category]
	[BaseType (typeof(BTCardClient))]
	interface BTCardClient_UnionPay
	{
		// -(void)fetchCapabilities:(NSString * _Nonnull)cardNumber completion:(void (^ _Nonnull)(BTCardCapabilities * _Nullable, NSError * _Nullable))completion;
		[Export ("fetchCapabilities:completion:")]
		void FetchCapabilities (string cardNumber, Action<BTCardCapabilities, NSError> completion);

		// -(void)enrollCard:(BTCardRequest * _Nonnull)request completion:(void (^ _Nonnull)(NSString * _Nullable, BOOL, NSError * _Nullable))completion;
		[Export ("enrollCard:completion:")]
		void EnrollCard (BTCardRequest request, Action<NSString, bool, NSError> completion);
	}

	// @interface UnionPay (BTConfiguration)
	[Category]
	[BaseType (typeof(BTConfiguration))]
	interface BTConfiguration_UnionPay
	{
		// @property (readonly, assign, nonatomic) BOOL isUnionPayEnabled;
		[Export ("isUnionPayEnabled")]
		bool IsUnionPayEnabled { get; }
	}
}
