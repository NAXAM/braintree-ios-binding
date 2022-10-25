using System.Runtime.InteropServices;
using ObjCRuntime;

namespace BraintreeVenmo
{
	static class CFunctions
	{
		// extern int NS_ENUM (int NSInteger, int BTVenmoDriverErrorType);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern int NS_ENUM (int NSInteger, int BTVenmoDriverErrorType);
	}

	[Native]
	public enum BTVenmoPaymentMethodUsage : long
	{
		Unspecified = 0,
		MultiUse = 1,
		SingleUse = 2
	}
}
