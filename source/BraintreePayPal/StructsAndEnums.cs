using System.Runtime.InteropServices;
using ObjCRuntime;

namespace BraintreePayPal
{
	[Native]
	public enum BTPayPalDriverErrorType : long
	{
		Unknown = 0,
		Disabled,
		InvalidRequest,
		Integration,
		Canceled
	}

	[Native]
	public enum BTPayPalLineItemKind : long
	{
		Debit = 1,
		Credit
	}

	[Native]
	public enum BTPayPalPaymentType : ulong
	{
		Checkout,
		Vault
	}

	[Native]
	public enum BTPayPalRequestLandingPageType : long
	{
		Default = 1,
		Login,
		Billing
	}
}
