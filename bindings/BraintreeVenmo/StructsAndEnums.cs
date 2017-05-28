using System;
using ObjCRuntime;

namespace BraintreeVenmo
{
	[Native]
	public enum BTClientMetadataSourceType : nint
	{
		Unknown = 0,
		PayPalApp,
		PayPalBrowser,
		VenmoApp,
		Form
	}

	[Native]
	public enum BTClientMetadataIntegrationType : nint
	{
		Custom,
		DropIn,
		DropIn2,
		Unknown
	}

	[Native]
	public enum BTJSONErrorCode : nint
	{
		ValueUnknown = 0,
		ValueInvalid = 1,
		AccessInvalid = 2
	}

	[Native]
	public enum BTAPIClientErrorType : nint
	{
		Unknown = 0,
		ConfigurationUnavailable,
		NotAuthorized
	}

	[Native]
	public enum BTAppSwitchTarget : nint
	{
		Unknown = 0,
		NativeApp,
		WebBrowser
	}

	[Native]
	public enum BTClientTokenError : nint
	{
		Unknown = 0,
		Invalid,
		UnsupportedVersion
	}

	[Native]
	public enum BTCardNetwork : nint
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
		UKMaestro
	}

	[Native]
	public enum BTHTTPErrorCode : nint
	{
		Unknown = 0,
		ResponseContentTypeNotAcceptable,
		ClientError,
		ServerError,
		MissingBaseURL,
		RateLimitError
	}

	[Native]
	public enum BTLogLevel : nuint
	{
		None = 0,
		Critical = 1,
		Error = 2,
		Warning = 3,
		Info = 4,
		Debug = 5
	}

	[Native]
	public enum BTTokenizationServiceError : nint
	{
		Unknown = 0,
		TypeNotRegistered
	}

	[Native]
	public enum BTVenmoDriverErrorType : nint
	{
		Unknown = 0,
		Disabled,
		AppNotAvailable,
		BundleDisplayNameMissing,
		AppSwitchFailed,
		InvalidReturnURL,
		Integration,
		InvalidRequestURL
	}
}
