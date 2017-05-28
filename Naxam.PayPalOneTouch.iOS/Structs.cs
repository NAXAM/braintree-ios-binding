using System;
using ObjCRuntime;

namespace PayPalOneTouch
{
	[Native]
	public enum PPOTRequestTarget : long
	{
		None,
		Browser,
		OnDeviceApplication,
		Unknown
	}

	[Native]
	public enum PPOTErrorCode : long
	{
		Unknown = -1000,
		ParsingFailed = -1001,
		NoTargetAppFound = -1002,
		OpenURLFailed = -1003,
		PersistedDataFetchFailed = -1004
	}

	[Native]
	public enum PPOTResultType : long
	{
		Error,
		Cancel,
		Success
	}
}
