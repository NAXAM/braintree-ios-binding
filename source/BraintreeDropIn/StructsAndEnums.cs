using ObjCRuntime;

namespace BraintreeDropIn
{
	[Native]
	public enum BTDropInPaymentMethodType : long
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
		Hiper,
		Hipercard,
		Solo,
		Switch,
		UKMaestro,
		PayPal,
		Venmo,
		ApplePay
	}

	[Native]
	public enum BTFormFieldSetting : long
	{
		Disabled = 0,
		Optional,
		Required
	}

	[Native]
	public enum BTDropInErrorType : long
	{
		Unknown = 0,
		Authorization
	}

	[Native]
	public enum BTDropInColorScheme : long
	{
		Light,
		Dark,
		Dynamic
	}
}
