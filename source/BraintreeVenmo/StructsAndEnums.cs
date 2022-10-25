using System.Runtime.InteropServices;
using ObjCRuntime;

namespace BraintreeVenmo
{
	[Native]
	public enum BTVenmoPaymentMethodUsage : long
	{
		Unspecified = 0,
		MultiUse = 1,
		SingleUse = 2
	}
}
