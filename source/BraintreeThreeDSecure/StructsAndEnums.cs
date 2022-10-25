using System.Runtime.InteropServices;
using ObjCRuntime;

namespace BraintreeThreeDSecure
{
	static class CFunctions
	{
		// extern int NS_ENUM (int NSInteger, int BTThreeDSecureFlowErrorType);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern int NS_ENUM (int NSInteger, int BTThreeDSecureFlowErrorType);
	}

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
