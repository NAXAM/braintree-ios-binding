using ObjCRuntime;

namespace PPRiskMagnes
{
	[Native]
	public enum MagnesSource : long
	{
		Paypal = 10,
		Ebay = 11,
		Braintree = 12,
		Simility = 17,
		Venmo = 18,
		Default = 19
	}

	[Native]
	public enum Environment : long
	{
		Live = 0,
		Sandbox = 1,
		Stage = 2
	}

	[Native]
	public enum MagnesErrors : long
	{
		MagnesErrorsInvalidInputError = 100
	}
}
