using System;
using ObjCRuntime;

namespace PayPalDataCollector
{
    [Native]
    public enum MagnesEnvironment : long {
        LIVE = 0,
        SANDBOX = 1,
        STAGE = 2
    } 

    [Native]
    public enum MagnesSourceFlow : long {
        MAGNES_SOURCE_PAYPAL = 10,
        MAGNES_SOURCE_EBAY = 11,
        MAGNES_SOURCE_BRAINTREE = 12,
        MAGNES_SOURCE_SIMILITY = 17,
        MAGNES_SOURCE_DEFAULT = -1
    } 
}