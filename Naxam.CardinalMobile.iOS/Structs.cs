using System;
using ObjCRuntime;

namespace CardinalMobile
{
	[Native]
	public enum Severity : long {
		Low,
		Medium,
		High
	}

	[Native]
	public enum ButtonType : long {
		Verify,
		Continue,
		Next,
		Cancel,
		Resend
	}

	[Native]
	public enum CCADirectoryServerID : long {
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

	[Native]
	public enum CardinalSessionEnvironment : long {
		Staging,
		Production
	};

	[Native]
	public enum CardinalSessionUIType : long {
		Native,
		HTML,
		Both,
	};

	[Native]
	public enum CardinalResponseActionCode : long {
		Success,
		NoAction,
		Failure,
		Error,
		Cancel,
		Timeout
	}
}
