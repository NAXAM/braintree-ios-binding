using System;
using ObjCRuntime;

namespace BraintreeDropIn
{
	[Native]
    public enum BTFormFieldSetting : long {
        Disabled = 0,
        Optional,
        Required
    }
}