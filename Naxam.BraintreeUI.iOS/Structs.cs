using System;
using ObjCRuntime;

namespace BraintreeUI
{
	[Native]
	public enum BTUIPaymentOptionType : long
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
		Venmo
	}

	[Native]
	public enum BTUICardFormOptionalFields : ulong
	{
		None = 0,
		Cvv = 1 << 0,
		PostalCode = 1 << 1,
		PhoneNumber = 1 << 2,
		All = Cvv | PostalCode | PhoneNumber
	}

	[Native]
	public enum BTUICardFormField : ulong
	{
		Number = 0,
		Expiration,
		Cvv,
		PostalCode,
		PhoneNumber
	}

	[Native]
	public enum BTCardHintDisplayMode : long
	{
		ardType,
		VVHint
	}
}
