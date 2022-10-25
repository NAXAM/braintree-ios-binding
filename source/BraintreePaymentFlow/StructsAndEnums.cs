using ObjCRuntime;

namespace BraintreePaymentFlow
{
	[Native]
	public enum BTPaymentFlowDriverErrorType : long
	{
		Unknown = 0,
		Disabled,
		AppSwitchFailed,
		InvalidReturnURL,
		Integration,
		Canceled
	}
}
