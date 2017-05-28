using System;
using ObjCRuntime;

namespace Braintree3DSecure
{
	[Native]
	public enum BTThreeDSecureErrorType : long
	{
		Unknown = 0,
		FailedLookup,
		FailedAuthentication,
		Integration
	}
}
