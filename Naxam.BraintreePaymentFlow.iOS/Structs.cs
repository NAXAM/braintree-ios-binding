using System;
using ObjCRuntime;

namespace BraintreePaymentFlow
{
    [Native]
    public enum BTThreeDSecureVersion : long {
        Version1,
        Version2,
    } 

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
        FailedLookup,
        FailedAuthentication,
        Configuration,
    }
}
