using System;
using ObjCRuntime;

namespace BraintreePaymentFlow
{
    [Native]
    public enum BTPaymentFlowDriverErrorType : long 
    {
        Unknown = 0,

        /// PaymentFlow is disabled in configuration.
        Disabled,
        
        /// UIApplication failed to switch to browser.
        AppSwitchFailed,
        
        /// Return URL was invalid.
        InvalidReturnURL,
        
        /// Braintree SDK is integrated incorrectly.
        Integration,
        
        /// Request URL was invalid, configuration may be missing required values.
        InvalidRequestURL,

        /// Payment flow was canceled, typically initiated by the user when exiting early from the flow.
        Canceled,
    }

    [Native]
    public enum BTThreeDSecureFlowErrorType : long 
    {
        Unknown = 0,
        
        /// 3D Secure failed during the backend card lookup phase; please retry
        FailedLookup,
        
        /// 3D Secure failed during the user-facing authentication phase; please retry
        FailedAuthentication,
    }
}
