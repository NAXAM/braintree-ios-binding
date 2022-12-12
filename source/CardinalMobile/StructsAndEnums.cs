using System;
using ObjCRuntime;

namespace CardinalMobile
{
	[Native]
	public enum CardinalResponseActionCode : ulong
	{
		Success,
		NoAction,
		Failure,
		Error,
		Cancel,
		Timeout
	}

	public enum Severity : uint
	{
		Low,
		Medium,
		High
	}

	public enum CCADirectoryServerID : uint
	{
		EMVCo1,
		EMVCo2,
		AmexStaging,
		Visa,
		VisaSDK,
		Visa01,
		Visa02,
		Visa03,
		Visa04,
		MasterCard
	}

	public enum ButtonType : uint
	{
		Verify,
		Continue,
		Next,
		Cancel,
		Resend
	}

	[Native]
	public enum CardinalSessionEnvironment : ulong
	{
		Staging,
		Production
	}

	[Native]
	public enum CardinalSessionUIType : ulong
	{
		Native,
		Html,
		Both
	}
}
