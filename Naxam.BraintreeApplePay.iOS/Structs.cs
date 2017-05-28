using System;
using ObjCRuntime;

namespace BraintreeApplePay
{
	[Native]
	public enum BTApplePayErrorType : long
	{
		Unknown = 0,
		Unsupported,
		Integration
	}
}
