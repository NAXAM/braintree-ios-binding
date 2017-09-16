using System;
using Braintree3DSecure;
using BraintreeCard;
using BraintreeCore;
using Foundation;
using ObjCRuntime;

namespace Braintree3DSecure
{
    //[Static]
    //[Verify (ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //	// extern double Braintree3DSecureVersionNumber;
    //	[Field ("Braintree3DSecureVersionNumber", "__Internal")]
    //	double Braintree3DSecureVersionNumber { get; }

    //	// extern const unsigned char [] Braintree3DSecureVersionString;
    //	[Field ("Braintree3DSecureVersionString", "__Internal")]
    //	byte[] Braintree3DSecureVersionString { get; }
    //} 

    // @interface BTThreeDSecureCardNonce : BTCardNonce
    [BaseType(typeof(BTCardNonce))]
    interface BTThreeDSecureCardNonce
    {
        // @property (readonly, assign, nonatomic) BOOL liabilityShifted;
        [Export("liabilityShifted")]
        bool LiabilityShifted { get; }

        // @property (readonly, assign, nonatomic) BOOL liabilityShiftPossible;
        [Export("liabilityShiftPossible")]
        bool LiabilityShiftPossible { get; }

        // -(instancetype _Nonnull)initWithNonce:(NSString * _Nonnull)nonce description:(NSString * _Nullable)description cardNetwork:(BTCardNetwork)cardNetwork lastTwo:(NSString * _Nullable)lastTwo threeDSecureJSON:(BTJSON * _Nonnull)threeDSecureJSON isDefault:(BOOL)isDefault cardJSON:(BTJSON *)cardJSON;
        [Export("initWithNonce:description:cardNetwork:lastTwo:threeDSecureJSON:isDefault:")]
        IntPtr Constructor(string nonce, [NullAllowed] string description, BTCardNetwork cardNetwork, [NullAllowed] string lastTwo, BTJSON threeDSecureJSON, bool isDefault, BTJSON cardJSON);
    }

    // @interface BTThreeDSecureDriver : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BTThreeDSecureDriver
    {
        // -(instancetype _Nonnull)initWithAPIClient:(BTAPIClient * _Nonnull)apiClient delegate:(id<BTViewControllerPresentingDelegate> _Nonnull)delegate __attribute__((objc_designated_initializer));
        [Export("initWithAPIClient:delegate:")]
        [DesignatedInitializer]
        IntPtr Constructor(BTAPIClient apiClient, BTViewControllerPresentingDelegate @delegate);

        // -(void)verifyCardWithNonce:(NSString * _Nonnull)nonce amount:(NSDecimalNumber * _Nonnull)amount completion:(void (^ _Nonnull)(BTThreeDSecureCardNonce * _Nullable, NSError * _Nullable))completionBlock;
        [Export("verifyCardWithNonce:amount:completion:")]
        void VerifyCardWithNonce(string nonce, NSDecimalNumber amount, Action<BTThreeDSecureCardNonce, NSError> completionBlock);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        BTViewControllerPresentingDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<BTViewControllerPresentingDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }
    }

    [Static]
    partial interface BTThreeDSecureConstants
    {
        // extern NSString *const BTThreeDSecureErrorDomain;
        [Field("BTThreeDSecureErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }

        // extern NSString *const BTThreeDSecureInfoKey;
        [Field("BTThreeDSecureInfoKey", "__Internal")]
        NSString InfoKey { get; }

        // extern NSString *const BTThreeDSecureValidationErrorsKey;
        [Field("BTThreeDSecureValidationErrorsKey", "__Internal")]
        NSString ValidationErrorsKey { get; }
    }
}