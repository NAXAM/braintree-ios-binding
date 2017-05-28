using System;
using Foundation;

namespace PayPal.Risk
{
	// typedef void (^PPRCClientMetadataIDProviderNetworkResponseBlock)(NSHTTPURLResponse * _Nonnull, NSData * _Nonnull);
	delegate void PPRCClientMetadataIDProviderNetworkResponseBlock (NSHttpUrlResponse arg0, NSData arg1);

	// typedef void (^PPRCClientMetadataIDProviderNetworkAdapterBlock)(NSURLRequest * _Nonnull, PPRCClientMetadataIDProviderNetworkResponseBlock _Nonnull);
	delegate void PPRCClientMetadataIDProviderNetworkAdapterBlock (NSUrlRequest arg0, PPRCClientMetadataIDProviderNetworkResponseBlock arg1);

	// @interface PPRCClientMetadataIDProvider : NSObject
	[BaseType (typeof(NSObject))]
	interface PPRCClientMetadataIDProvider
	{
		// -(instancetype _Nonnull)initWithAppGuid:(NSString * _Nonnull)appGuid sourceAppVersion:(NSString * _Nonnull)sourceAppVersion networkAdapterBlock:(PPRCClientMetadataIDProviderNetworkAdapterBlock _Nonnull)networkAdapterBlock;
		[Export ("initWithAppGuid:sourceAppVersion:networkAdapterBlock:")]
		IntPtr Constructor (string appGuid, string sourceAppVersion, PPRCClientMetadataIDProviderNetworkAdapterBlock networkAdapterBlock);

		// -(instancetype _Nonnull)initWithAppGuid:(NSString * _Nonnull)appGuid sourceAppVersion:(NSString * _Nonnull)sourceAppVersion networkAdapterBlock:(PPRCClientMetadataIDProviderNetworkAdapterBlock _Nonnull)networkAdapterBlock pairingID:(NSString * _Nullable)pairingID;
		[Export ("initWithAppGuid:sourceAppVersion:networkAdapterBlock:pairingID:")]
		IntPtr Constructor (string appGuid, string sourceAppVersion, PPRCClientMetadataIDProviderNetworkAdapterBlock networkAdapterBlock, [NullAllowed] string pairingID);

		// -(NSString * _Nonnull)clientMetadataID:(NSString * _Nullable)pairingID;
		[Export ("clientMetadataID:")]
		string ClientMetadataID ([NullAllowed] string pairingID);
	}
}
