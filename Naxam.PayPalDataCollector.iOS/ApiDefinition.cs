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

        // + (nonnull PPRMOCMagnesSDKResult *)collectPayPalDeviceInfoWithClientMetadataID:(nullable NSString *)clientMetadataID;
        [Static]
        [Export("collectPayPalDeviceInfoWithClientMetadataID:")]
        PPRMOCMagnesSDKResult CollectPayPalDeviceInfoWithClientMetadataID(string clientMetadataID);

        // + (nonnull NSString *)generateClientMetadataID:(nullable NSString *)clientMetadataID disableBeacon:(BOOL)disableBeacon data:(nullable NSDictionary *)data;
        [Static, Export("generateClientMetadataID:disableBeacon:data:")]
        string GenerateClientMetadataID(string clientMetadataID,bool disableBeacon, NSDictionary data);

        // + (nonnull NSString *)generateClientMetadataIDWithoutBeacon:(nullable NSString *)clientMetadataID data:(nullable NSDictionary *)data;
        [Static, Export("generateClientMetadataIDWithoutBeacon:data:")]
        string GenerateClientMetadataIDWithoutBeacon(string clientMetadataID, NSDictionary data);

        // + (nonnull NSString *)generateClientMetadataID;
        [Static, Export("generateClientMetadataID")]
        string GenerateClientMetadataID();
    }

    [BaseType(typeof(NSObject))]
    interface PPRMOCMagnesSDKResult {
        // - (id)initWithDeviceInfo:(NSDictionary *)deviceInfo
        //             withPayPalClientMetaDataId:(NSString *)cmid;
        [Export("initWithDeviceInfo:withPayPalClientMetaDataId:")]
        IntPtr Constructor(NSDictionary deviceInfo, string cmid);

        // - (NSDictionary *)getDeviceInfo;
        [Export("getDeviceInfo")]
        NSDictionary GetDeviceInfo();

        // - (NSString *)getPayPalClientMetaDataId;
        [Export("getPayPalClientMetaDataId")]
        string GetPayPalClientMetaDataId();
    }

    [BaseType(typeof(NSObject))]
    interface PPRMOCMagnesSDK {
        // + (PPRMOCMagnesSDK *)shared;
        [Export("shared"), Static]
        PPRMOCMagnesSDK Shared();

        // - (void)setUpEnvironment:(MagnesEnvironment)env
        //         withOptionalAppGuid:(NSString *)appGuid
        //         withOptionalAPNToken:(NSString *)apnToken
        //   disableRemoteConfiguration:(Boolean)isRemoteConfigDisabled
        //            disableBeacon:(Boolean)isBeaconDisabled
        //              forMagnesSource:(MagnesSourceFlow)magnesSource;
        [Export("setUpEnvironment:withOptionalAppGuid:withOptionalAPNToken:disableRemoteConfiguration:disableBeacon:forMagnesSource:")]
        void SetUpEnvironment(MagnesEnvironment environment, [NullAllowed]string appGuid, [NullAllowed]string apnToken, bool isRemoteConfigDisabled, bool isBeaconDisabled, MagnesSourceFlow magnesSource);

        // - (PPRMOCMagnesSDKResult *)collect;
        [Export("collect")]
        PPRMOCMagnesSDKResult Collect();

        // - (PPRMOCMagnesSDKResult *)collectWithPayPalClientMetadataId:(NSString *)cmid
        //                                     withAdditionalData:(NSDictionary *)additionalData;
        [Export("collectWithPayPalClientMetadataId:withAdditionalData:")]
        PPRMOCMagnesSDKResult CollectWithPayPalClientMetadataId(string cmid, NSDictionary additionalData);

        // - (PPRMOCMagnesSDKResult *)collectAndSubmit;
        [Export("collectAndSubmit")]
        PPRMOCMagnesSDKResult CollectAndSubmit();

        // - (PPRMOCMagnesSDKResult *)collectAndSubmitWithPayPalClientMetadataId:(NSString *)cmid
        //                                              withAdditionalData:(NSDictionary *)additionalData;
        [Export("collectAndSubmitWithPayPalClientMetadataId:withAdditionalData:")]
        PPRMOCMagnesSDKResult CollectAndSubmitWithPayPalClientMetadataId(string cmid, NSDictionary additionalData);
    }

}
