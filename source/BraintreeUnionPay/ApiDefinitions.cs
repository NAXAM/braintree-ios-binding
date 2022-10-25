using System;
using BraintreeUnionPay;
using Foundation;
using BraintreeCore;
using BraintreeCard;

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

	// @interface BTCardClient (UnionPay)
	[Category]
	[BaseType(typeof(BTCardClient))]
	interface BTCardClient_UnionPay
	{
		// -(void)fetchCapabilities:(NSString * _Nonnull)cardNumber completion:(void (^ _Nonnull)(BTCardCapabilities * _Nullable, NSError * _Nullable))completion;
		[Export ("fetchCapabilities:completion:")]
		void FetchCapabilities (string cardNumber, Action<BTCardCapabilities, NSError> completion);

		// -(void)enrollCard:(BTCardRequest *)request completion:(void (^ _Nonnull)(NSString * _Nullable, BOOL, NSError * _Nullable))completion;
		[Export ("enrollCard:completion:")]
		void EnrollCard (BTCardRequest request, Action<NSString, bool, NSError> completion);
	}

	// @interface BTConfiguration (UnionPay)
	[Category]
	[BaseType(typeof(BTConfiguration))]
	interface BTConfiguration_UnionPay
	{
		// @property (readonly, assign, nonatomic) BOOL isUnionPayEnabled;
		[Export("isUnionPayEnabled")]
		bool IsUnionPayEnabled();
	}
}
