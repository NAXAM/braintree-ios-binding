using System;
using Foundation;

namespace PayPalDataCollector
{
	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern double PayPalDataCollectorVersionNumber;
	//	[Field("PayPalDataCollectorVersionNumber", "__Internal")]
	//	double PayPalDataCollectorVersionNumber { get; }

	//	// extern const unsigned char [] PayPalDataCollectorVersionString;
	//	[Field("PayPalDataCollectorVersionString", "__Internal")]
	//	byte[] PayPalDataCollectorVersionString { get; }
	//}

	// typedef void (^PPRCClientMetadataIDProviderNetworkResponseBlock)(NSHTTPURLResponse * _Nonnull, NSData * _Nonnull);
	delegate void PPRCClientMetadataIDProviderNetworkResponseBlock(NSHttpUrlResponse arg0, NSData arg1);

	// typedef void (^PPRCClientMetadataIDProviderNetworkAdapterBlock)(NSURLRequest * _Nonnull, PPRCClientMetadataIDProviderNetworkResponseBlock _Nonnull);
	delegate void PPRCClientMetadataIDProviderNetworkAdapterBlock(NSUrlRequest arg0, PPRCClientMetadataIDProviderNetworkResponseBlock arg1);

	// @interface PPRCClientMetadataIDProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface PPRCClientMetadataIDProvider
	{
		// -(instancetype _Nonnull)initWithAppGuid:(NSString * _Nonnull)appGuid sourceAppVersion:(NSString * _Nonnull)sourceAppVersion networkAdapterBlock:(PPRCClientMetadataIDProviderNetworkAdapterBlock _Nonnull)networkAdapterBlock;
		[Export("initWithAppGuid:sourceAppVersion:networkAdapterBlock:")]
		IntPtr Constructor(string appGuid, string sourceAppVersion, PPRCClientMetadataIDProviderNetworkAdapterBlock networkAdapterBlock);

		// -(instancetype _Nonnull)initWithAppGuid:(NSString * _Nonnull)appGuid sourceAppVersion:(NSString * _Nonnull)sourceAppVersion networkAdapterBlock:(PPRCClientMetadataIDProviderNetworkAdapterBlock _Nonnull)networkAdapterBlock pairingID:(NSString * _Nullable)pairingID;
		[Export("initWithAppGuid:sourceAppVersion:networkAdapterBlock:pairingID:")]
		IntPtr Constructor(string appGuid, string sourceAppVersion, PPRCClientMetadataIDProviderNetworkAdapterBlock networkAdapterBlock, [NullAllowed] string pairingID);

		// -(NSString * _Nonnull)clientMetadataID:(NSString * _Nullable)pairingID;
		[Export("clientMetadataID:")]
		string ClientMetadataID([NullAllowed] string pairingID);
	}

	// @interface PPDataCollector : NSObject
	[BaseType(typeof(NSObject))]
	interface PPDataCollector
	{
		// +(NSString * _Nonnull)clientMetadataID:(NSString * _Nullable)pairingID;
		[Static]
		[Export("clientMetadataID:")]
		string GetClientMetadataID([NullAllowed] string pairingID);

        // +(NSString * _Nonnull)clientMetadataID __attribute__((deprecated("Use [PPDataCollector collectPayPalDeviceData] to generate a device data string.")));
        [Static]
        [Export("clientMetadataID")]
        string GetClientMetadataID();

        // +(NSString * _Nonnull)collectPayPalDeviceData;
        [Static]
        [Export("collectPayPalDeviceData")]
        string CollectPayPalDeviceData();
	}
}
