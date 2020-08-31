using System;
using ObjCRuntime;

namespace BraintreeCore
{
    [Native]
    public enum BTPayPalIDTokenError : long {
        Unknown = 0,
        Invalid,
        UnlinkedAccount,
    }

    [Native]
    public enum BTPayPalIDTokenEnvironment : long {
        /// Staging
        Stage = 0,

        /// Sandbox
        Sand = 1,

        /// Production
        Prod = 2
    }

    [Native]
    public enum BTAPIClientHTTPType : long {
        Gateway = 0,
        BraintreeAPI,
        GraphQLAPI,
    }

    [Native]
    public enum BTAPIClientAuthorizationType : long {
        TokenizationKey = 0,
        ClientToken,
        PayPalIDToken,
    }

    [Native]
    public enum BTPayPalUATError : long {
        Unknown = 0,
        Invalid,
        UnlinkedAccount,
    }

    [Native]
    public enum BTClientMetadataSourceType : long
    {
        Unknown = 0,
        PayPalApp,
        PayPalBrowser,
        VenmoApp,
        Form
    }

    [Native]
    public enum BTClientMetadataIntegrationType : long
    {
        Custom,
        DropIn,
        DropIn2,
        Unknown
    }

    [Native]
    public enum BTJSONErrorCode : long
    {
        ValueUnknown = 0,
        ValueInvalid = 1,
        AccessInvalid = 2
    }

    [Native]
    public enum BTAPIClientErrorType : long
    {
        Unknown = 0,
        ConfigurationUnavailable,
        NotAuthorized
    }

    [Native]
    public enum BTAppSwitchTarget : long
    {
        Unknown = 0,
        NativeApp,
        WebBrowser
    }

    [Native]
    public enum BTClientTokenError : long
    {
        Unknown = 0,
        Invalid,
        UnsupportedVersion
    }

    [Native]
    public enum BTCardNetwork : long
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
        UKMaestro
    }

    [Native]
    public enum BTHTTPErrorCode : long
    {
        Unknown = 0,
        ResponseContentTypeNotAcceptable,
        ClientError,
        ServerError,
        MissingBaseURL,
        RateLimitError
    }

    [Native]
    public enum BTLogLevel : ulong
    {
        None = 0,
        Critical = 1,
        Error = 2,
        Warning = 3,
        Info = 4,
        Debug = 5
    }

    [Native]
    public enum BTTokenizationServiceError : long
    {
        Unknown = 0,
        TypeNotRegistered
    }
}
