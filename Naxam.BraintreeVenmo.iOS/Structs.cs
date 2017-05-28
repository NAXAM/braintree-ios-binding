using System;
using ObjCRuntime;

namespace BraintreeVenmo
{
	[Native]
	public enum BTVenmoDriverErrorType : long
	{
		Unknown = 0,
		Disabled,
		AppNotAvailable,
		BundleDisplayNameMissing,
		AppSwitchFailed,
		InvalidReturnURL,
		Integration,
		InvalidRequestURL
	}
}
