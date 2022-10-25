using Foundation;

namespace PayPalDataCollector
{
	// @interface PPDataCollector : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC19PayPalDataCollector15PPDataCollector")]
	interface PPDataCollector
	{
		// +(NSString * _Nonnull)clientMetadataID:(NSString * _Nullable)pairingID __attribute__((warn_unused_result("")));
		[Static]
		[Export ("clientMetadataID:")]
		string ClientMetadataID ([NullAllowed] string pairingID);

		// +(NSString * _Nonnull)clientMetadataID:(NSString * _Nullable)pairingID isSandbox:(BOOL)isSandbox __attribute__((warn_unused_result("")));
		[Static]
		[Export ("clientMetadataID:isSandbox:")]
		string ClientMetadataID ([NullAllowed] string pairingID, bool isSandbox);

		// +(NSString * _Nonnull)collectPayPalDeviceData __attribute__((warn_unused_result("")));
		[Static]
		[Export ("collectPayPalDeviceData")]
		[Verify (MethodToProperty)]
		string CollectPayPalDeviceData { get; }

		// +(NSString * _Nonnull)collectPayPalDeviceDataWithIsSandbox:(BOOL)isSandbox __attribute__((warn_unused_result("")));
		[Static]
		[Export ("collectPayPalDeviceDataWithIsSandbox:")]
		string CollectPayPalDeviceDataWithIsSandbox (bool isSandbox);
	}
}
