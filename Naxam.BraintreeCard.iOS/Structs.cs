using System;
using ObjCRuntime;

namespace BraintreeCard
{
	[Native]
	public enum BTCardClientErrorType : long
	{
		Unknown = 0,
		Integration,
		PaymentOptionNotEnabled,
		CustomerInputInvalid
	}
}