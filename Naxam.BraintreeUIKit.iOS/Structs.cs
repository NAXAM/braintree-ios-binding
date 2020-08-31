using System;
using ObjCRuntime;

namespace BraintreeUIKit
{
	[Native]
	public enum BTUIKCardNumberFormFieldState : long
	{
		Default = 0,
		Validate,
		Loading
	}

	[Native]
	public enum BTUIKPaymentOptionType : long
	{
		Unknown = 0,
		Amex,
		DinersClub,
		Discover,
		MasterCard,
		Visa,
		Jcb,
		Laser,
		Maestro,
		UnionPay,
		Solo,
		Switch,
		UKMaestro,
		PayPal,
		Coinbase,
		Venmo,
		ApplePay
	}

	[Native]
	public enum BTUIKVisualAssetType : long
	{
		Unknown = 0,
		CVVBack,
		CVVFront
	}

	[Native]
	public enum BTUIKVectorArtSize : long
	{
		Regular,
		Large
	}
}
