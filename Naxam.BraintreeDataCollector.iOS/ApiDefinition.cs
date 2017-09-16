using System;
using BraintreeCore;
using Foundation;
using ObjCRuntime;

namespace BraintreeDataCollector
{
    // [Static]
    // [Verify (ConstantsInterfaceAssociation)]
    // partial interface Constants
    // {
    // 	// extern double BraintreeDataCollectorVersionNumber;
    // 	[Field ("BraintreeDataCollectorVersionNumber", "__Internal")]
    // 	double BraintreeDataCollectorVersionNumber { get; }

    // 	// extern const unsigned char [] BraintreeDataCollectorVersionString;
    // 	[Field ("BraintreeDataCollectorVersionString", "__Internal")]
    // 	byte[] BraintreeDataCollectorVersionString { get; }
    // }

    [Static]
    partial interface BTDataCollectorKountConstants
    {
        // extern NSString *const _Nonnull BTDataCollectorKountErrorDomain;
        [Field("BTDataCollectorKountErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }
    }

    // @interface BTDataCollector : NSObject
    [BaseType(typeof(NSObject))]
    interface BTDataCollector
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        BTDataCollectorDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<BTDataCollectorDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithEnvironment:(BTDataCollectorEnvironment)environment __attribute__((deprecated("Use BTDataCollector initWithAPIClient: instead")));
        [Export("initWithEnvironment:")]
        IntPtr Constructor(BTDataCollectorEnvironment environment);

        // -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient;
        [Export("initWithAPIClient:")]
        IntPtr Constructor(BTAPIClient apiClient);

        // -(void)collectFraudData:(void (^ _Nonnull)(NSString * _Nonnull))completion;
        [Export("collectFraudData:")]
        void CollectFraudData(Action<NSString> completion);

        // -(void)collectCardFraudData:(void (^ _Nonnull)(NSString * _Nonnull))completion;
        [Export("collectCardFraudData:")]
        void CollectCardFraudData(Action<NSString> completion);

        // -(void)setFraudMerchantId:(NSString * _Nonnull)fraudMerchantId;
        [Export("setFraudMerchantId:")]
        void SetFraudMerchantId(string fraudMerchantId);

        // -(void)setCollectorUrl:(NSString * _Nonnull)url __attribute__((deprecated("The collector URL is no longer used. The environment will be automatically chosen.")));
        [Export("setCollectorUrl:")]
        void SetCollectorUrl(string url);

        // +(NSString * _Nullable)payPalClientMetadataId __attribute__((deprecated("Integrate PayPalDataCollector and use PPDataCollector +clientMetadataID instead.")));
        [Static]
        [NullAllowed, Export("payPalClientMetadataId")]
        string PayPalClientMetadataId { get; }

        // -(NSString * _Nonnull)collectCardFraudData __attribute__((deprecated("Use BTDataCollector -collectCardFraudData: instead")));
        [Export("collectCardFraudData")]
        string CollectCardFraudData();
        // -(NSString * _Nonnull)collectPayPalClientMetadataId __attribute__((deprecated("Integrate PayPalDataCollector and use PPDataCollector +collectPayPalDeviceData instead.")));
        [Export("collectPayPalClientMetadataId")]
        string CollectPayPalClientMetadataId();

        // -(NSString * _Nonnull)collectFraudData __attribute__((deprecated("Use BTDataCollector -collectFraudData: instead")));
        [Export("collectFraudData")]
        string CollectFraudData();
    }

    // @protocol BTDataCollectorDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BTDataCollectorDelegate
    {
        // @required -(void)dataCollectorDidComplete:(BTDataCollector * _Nonnull)dataCollector;
        [Abstract]
        [Export("dataCollectorDidComplete:")]
        void DataCollectorDidComplete(BTDataCollector dataCollector);

        // @optional -(void)dataCollectorDidStart:(BTDataCollector * _Nonnull)dataCollector;
        [Export("dataCollectorDidStart:")]
        void DataCollectorDidStart(BTDataCollector dataCollector);

        // @optional -(void)dataCollector:(BTDataCollector * _Nonnull)dataCollector didFailWithError:(NSError * _Nonnull)error;
        [Export("dataCollector:didFailWithError:")]
        void DataCollector(BTDataCollector dataCollector, NSError error);
    }
}
