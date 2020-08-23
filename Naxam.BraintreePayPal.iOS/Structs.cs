using System;
using ObjCRuntime;

namespace BraintreePayPal
{
	[Native]
	public enum BTPayPalLineItemKind : long {
		Debit = 1,
		Credit,
	}

	[Native]
	public enum BTPayPalRequestIntent : long
	{
		Authorize = 1,
		Sale,
		Order
	}

	[Native]
	public enum BTPayPalRequestLandingPageType : long
	{
		Default = 1,
		Login,
		Billing
	}

	[Native]
	public enum BTPayPalRequestUserAction : long
	{
		Default = 1,
		Commit
	}

	[Native]
	public enum BTPayPalDriverErrorType : long
	{
		Unknown = 0,
		Disabled,
		IntegrationReturnURLScheme,
		AppSwitchFailed,
		InvalidConfiguration,
		InvalidRequest,
		Integration
	}
}
