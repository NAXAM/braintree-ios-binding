using System;
using BraintreeDataCollector;
using Foundation;
using ObjCRuntime;
using BraintreeCore;

namespace BraintreeDataCollector
{
	// @interface DataCollector
	[BaseType(typeof(NSObject))]
	interface DataCollector
	{
		// @property (readonly, assign, nonatomic) int isKountEnabled;
		[Export ("isKountEnabled")]
		int IsKountEnabled { get; }

		// @property (readonly, assign, nonatomic) int * kountMerchantID;
		[Export ("kountMerchantID", ArgumentSemantic.Assign)]
		unsafe NSArray KountMerchantID { get; }
	}

	// @interface BTDataCollector : NSObject
	[BaseType (typeof(NSObject))]
	interface BTDataCollector
	{
		// -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient;
		[Export ("initWithAPIClient:")]
		IntPtr Constructor (BTAPIClient apiClient);

		// -(void)collectDeviceData:(void (^ _Nonnull)(NSString * _Nonnull))completion;
		[Export ("collectDeviceData:")]
		void CollectDeviceData (Action<NSString> completion);

		// -(void)setFraudMerchantID:(NSString * _Nonnull)fraudMerchantID;
		[Export ("setFraudMerchantID:")]
		void SetFraudMerchantID (string fraudMerchantID);
	}
}
