using System.Runtime.InteropServices;
using ObjCRuntime;

namespace BraintreeThreeDSecure
{
	[Native]
	public enum BTThreeDSecureVersion : long
	{
		BTThreeDSecureVersion1,
		BTThreeDSecureVersion2
	}

	[Native]
	public enum BTThreeDSecureAccountType : long
	{
		Unspecified,
		Credit,
		Debit
	}

	[Native]
	public enum BTThreeDSecureShippingMethod : long
	{
		Unspecified,
		SameDay,
		Expedited,
		Priority,
		Ground,
		ElectronicDelivery,
		ShipToStore
	}

	[Native]
	public enum BTThreeDSecureCardAddChallenge : long
	{
		Unspecified,
		Requested,
		NotRequested
	}

	[Native]
	public enum BTThreeDSecureV2ButtonType : long
	{
		Verify,
		Continue,
		Next,
		Cancel,
		Resend
	}
}
