using System;
using Foundation;
using PayPalUtils;

namespace PayPalUtils
{
    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //	// extern double PayPalUtilsVersionNumber;
    //	[Field ("PayPalUtilsVersionNumber", "__Internal")]
    //	double PayPalUtilsVersionNumber { get; }

    //	// extern const unsigned char [] PayPalUtilsVersionString;
    //	[Field ("PayPalUtilsVersionString", "__Internal")]
    //	byte[] PayPalUtilsVersionString { get; }
    //}

    // @interface PPOTDevice : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTDevice
    {
        // +(NSString * _Nonnull)hardwarePlatform;
        [Static]
        [Export("hardwarePlatform")]
        string HardwarePlatform { get; }

        // +(NSString * _Nonnull)deviceName;
        [Static]
        [Export("deviceName")]
        string DeviceName { get; }

        // +(NSString * _Nonnull)complicatedDeviceLocale;
        [Static]
        [Export("complicatedDeviceLocale")]
        string ComplicatedDeviceLocale { get; }

        // +(NSString * _Nonnull)appropriateIdentifier;
        [Static]
        [Export("appropriateIdentifier")]
        string AppropriateIdentifier { get; }

        // +(void)clearIdentifier;
        [Static]
        [Export("clearIdentifier")]
        void ClearIdentifier();
    }

    // @interface PPOTEncryptionHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTEncryptionHelper
    {
        // +(NSData * _Nonnull)generate256BitKey;
        [Static]
        [Export("generate256BitKey")]
        NSData Generate256BitKey();

        // +(NSData * _Nullable)encryptAESCTRData:(NSData * _Nonnull)plainData encryptionKey:(NSData * _Nonnull)key;
        [Static]
        [Export("encryptAESCTRData:encryptionKey:")]
        [return: NullAllowed]
        NSData EncryptAESCTRData(NSData plainData, NSData key);

        // +(NSData * _Nullable)decryptAESCTRData:(NSData * _Nonnull)cipherData encryptionKey:(NSData * _Nonnull)key;
        [Static]
        [Export("decryptAESCTRData:encryptionKey:")]
        [return: NullAllowed]
        NSData DecryptAESCTRData(NSData cipherData, NSData key);

        // +(NSData * _Nullable)encryptRSAData:(NSData * _Nonnull)plainData certificate:(NSData * _Nonnull)certificate;
        [Static]
        [Export("encryptRSAData:certificate:")]
        [return: NullAllowed]
        NSData EncryptRSAData(NSData plainData, NSData certificate);
    }

    // @interface PPOTJSONHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTJSONHelper
    {
        // +(NSString * _Nullable)stringFromDictionary:(NSDictionary * _Nonnull)dictionary withKey:(NSString * _Nonnull)key;
        [Static]
        [Export("stringFromDictionary:withKey:")]
        [return: NullAllowed]
        string StringFromDictionary(NSDictionary dictionary, string key);

        // +(NSDictionary * _Nullable)dictionaryFromDictionary:(NSDictionary * _Nonnull)dictionary withKey:(NSString * _Nonnull)key;
        [Static]
        [Export("dictionaryFromDictionary:withKey:")]
        [return: NullAllowed]
        NSDictionary DictionaryFromDictionary(NSDictionary dictionary, string key);

        // +(NSArray * _Nullable)arrayFromDictionary:(NSDictionary * _Nonnull)dictionary withKey:(NSString * _Nonnull)key;
        [Static]
        [Export("arrayFromDictionary:withKey:")]
        [return: NullAllowed]
        NSObject[] ArrayFromDictionary(NSDictionary dictionary, string key);

        // +(NSArray * _Nullable)stringArrayFromDictionary:(NSDictionary * _Nonnull)dictionary withKey:(NSString * _Nonnull)key;
        [Static]
        [Export("stringArrayFromDictionary:withKey:")]
        [return: NullAllowed]
        NSObject[] StringArrayFromDictionary(NSDictionary dictionary, string key);

        // +(NSArray * _Nullable)dictionaryArrayFromDictionary:(NSDictionary * _Nonnull)dictionary withKey:(NSString * _Nonnull)key;
        [Static]
        [Export("dictionaryArrayFromDictionary:withKey:")]
        [return: NullAllowed]
        NSObject[] DictionaryArrayFromDictionary(NSDictionary dictionary, string key);

        // +(NSString * _Nullable)base64EncodedJSONStringWithDictionary:(NSDictionary * _Nonnull)dictionary;
        [Static]
        [Export("base64EncodedJSONStringWithDictionary:")]
        [return: NullAllowed]
        string Base64EncodedJSONStringWithDictionary(NSDictionary dictionary);

        // +(NSDictionary * _Nullable)dictionaryWithBase64EncodedJSONString:(NSString * _Nonnull)base64String;
        [Static]
        [Export("dictionaryWithBase64EncodedJSONString:")]
        [return: NullAllowed]
        NSDictionary DictionaryWithBase64EncodedJSONString(string base64String);

        // +(NSNumber * _Nullable)numberFromDictionary:(NSDictionary * _Nonnull)dictionary withKey:(NSString * _Nonnull)key;
        [Static]
        [Export("numberFromDictionary:withKey:")]
        [return: NullAllowed]
        NSNumber NumberFromDictionary(NSDictionary dictionary, string key);
    }

    // @interface PPOTMacros : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTMacros
    {
        // +(NSUInteger)deviceSystemMajorVersion;
        [Static]
        [Export("deviceSystemMajorVersion")]
        nuint DeviceSystemMajorVersion { get; }
    }

    // @interface PPOTPinnedCertificates : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTPinnedCertificates
    {
        // +(NSArray *)trustedCertificates;
        [Static]
        [Export("trustedCertificates")]
        NSObject[] TrustedCertificates { get; }
    }

    // @interface PPOTSimpleKeychain : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTSimpleKeychain
    {
        // +(BOOL)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key;
        [Static]
        [Export("setData:forKey:")]
        bool SetData([NullAllowed] NSData data, string key);

        // +(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key;
        [Static]
        [Export("dataForKey:")]
        [return: NullAllowed]
        NSData DataForKey(string key);

        // +(id _Nullable)unarchiveObjectWithDataForKey:(NSString * _Nonnull)key;
        [Static]
        [Export("unarchiveObjectWithDataForKey:")]
        [return: NullAllowed]
        NSObject UnarchiveObjectWithDataForKey(string key);
    }

    // @interface PPOTString : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTString
    {
        // +(NSString * _Nonnull)stringByURLEncodingAllCharactersInString:(NSString * _Nonnull)aString;
        [Static]
        [Export("stringByURLEncodingAllCharactersInString:")]
        string StringByURLEncodingAllCharactersInString(string aString);

        // +(NSString * _Nonnull)stringByBase64EncodingData:(NSData * _Nonnull)data;
        [Static]
        [Export("stringByBase64EncodingData:")]
        string StringByBase64EncodingData(NSData data);

        // +(NSData * _Nullable)decodeBase64WithString:(NSString * _Nonnull)strBase64;
        [Static]
        [Export("decodeBase64WithString:")]
        [return: NullAllowed]
        NSData DecodeBase64WithString(string strBase64);

        // +(NSString * _Nonnull)generateUniquishIdentifier;
        [Static]
        [Export("generateUniquishIdentifier")]
        string GenerateUniquishIdentifier();

        // +(NSString * _Nonnull)hexStringFromData:(NSData * _Nonnull)data;
        [Static]
        [Export("hexStringFromData:")]
        string HexStringFromData(NSData data);

        // +(NSData * _Nonnull)dataWithHexString:(NSString * _Nonnull)hexString;
        [Static]
        [Export("dataWithHexString:")]
        NSData DataWithHexString(string hexString);
    }

    // @interface PPOTTime : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTTime
    {
        // +(NSDateFormatter * _Nonnull)rfc3339DateFormatter;
        [Static]
        [Export("rfc3339DateFormatter")]
        NSDateFormatter Rfc3339DateFormatter { get; }

        // +(NSDate * _Nullable)dateFromRFC3339LikeString:(NSString * _Nullable)dateStr;
        [Static]
        [Export("dateFromRFC3339LikeString:")]
        [return: NullAllowed]
        NSDate DateFromRFC3339LikeString([NullAllowed] string dateStr);
    }

    // typedef void (^PPOTURLSessionCompletionBlock)(NSData * _Nullable, NSHTTPURLResponse * _Nullable, NSError * _Nullable);
    delegate void PPOTURLSessionCompletionBlock([NullAllowed] NSData arg0, [NullAllowed] NSHttpUrlResponse arg1, [NullAllowed] NSError arg2);

    // @interface PPOTURLSession : NSObject
    [BaseType(typeof(NSObject))]
    interface PPOTURLSession
    {
        // +(PPOTURLSession * _Nonnull)session;
        [Static]
        [Export("session")]
        PPOTURLSession Session { get; }

        // +(PPOTURLSession * _Nonnull)sessionWithTimeoutIntervalForRequest:(NSTimeInterval)timeoutIntervalForRequest;
        [Static]
        [Export("sessionWithTimeoutIntervalForRequest:")]
        PPOTURLSession SessionWithTimeoutIntervalForRequest(double timeoutIntervalForRequest);

        // -(void)sendRequest:(NSURLRequest * _Nonnull)request completionBlock:(PPOTURLSessionCompletionBlock _Nullable)completionBlock;
        [Export("sendRequest:completionBlock:")]
        void SendRequest(NSUrlRequest request, [NullAllowed] PPOTURLSessionCompletionBlock completionBlock);

        // -(void)finishTasksAndInvalidate;
        [Export("finishTasksAndInvalidate")]
        void FinishTasksAndInvalidate();
    }
}
