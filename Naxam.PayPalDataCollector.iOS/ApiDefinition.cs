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
