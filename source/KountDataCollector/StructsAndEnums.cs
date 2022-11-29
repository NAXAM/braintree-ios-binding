using System;
using ObjCRuntime;

namespace KountDataCollector
{
	[Native]
	public enum KDataCollectorErrorCode : long
	{
		Unknown = 0,
		NSError,
		Timeout,
		BadParameter,
		NoNetwork,
		ResponseValidation
	}

	[Native]
	public enum KLocationCollectorConfig : long
	{
		RequestPermission = 0,
		Passive,
		Skip
	}

	[Native]
	public enum KEnvironment : long
	{
		Unknown = 0,
		Test,
		Production
	}
}
