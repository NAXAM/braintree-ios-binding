using System;
using BraintreeDataCollector;
using Foundation;
using ObjCRuntime;
using BraintreeCore;

namespace BraintreeDataCollector
{
	// @interface BTConfiguration (DataCollector)
	[Category]
	[BaseType(typeof(BTConfiguration))]
	interface DataCollector
	{
		// @property (readonly, assign, nonatomic) int isKountEnabled;
		[Export("isKountEnabled")]
		int IsKountEnabled();

		// @property (readonly, assign, nonatomic) NSString * kountMerchantID;
		[Export("kountMerchantID", ArgumentSemantic.Assign)]
		unsafe string KountMerchantID();
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
