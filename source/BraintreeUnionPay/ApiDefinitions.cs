using System;
using BraintreeUnionPay;
using Foundation;

namespace BraintreeUnionPay
{
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

	// @interface UnionPay
	interface UnionPay
	{
		// -(void)fetchCapabilities:(NSString * _Nonnull)cardNumber completion:(void (^ _Nonnull)(BTCardCapabilities * _Nullable, NSError * _Nullable))completion;
		[Export ("fetchCapabilities:completion:")]
		void FetchCapabilities (string cardNumber, Action<BTCardCapabilities, NSError> completion);

		// -(void)enrollCard:(id)request completion:(void (^ _Nonnull)(NSString * _Nullable, BOOL, NSError * _Nullable))completion;
		[Export ("enrollCard:completion:")]
		void EnrollCard (NSObject request, Action<NSString, bool, NSError> completion);
	}

	// @interface UnionPay
	interface UnionPay
	{
		// @property (readonly, assign, nonatomic) BOOL isUnionPayEnabled;
		[Export ("isUnionPayEnabled")]
		bool IsUnionPayEnabled { }
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
}
