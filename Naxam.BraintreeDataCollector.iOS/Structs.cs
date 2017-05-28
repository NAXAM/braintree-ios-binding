using System;
using ObjCRuntime;

namespace BraintreeDataCollector
{
	[Native]
	public enum BTDataCollectorEnvironment : long
	{
		Development,
		Qa,
		Sandbox,
		Production
	}
}
