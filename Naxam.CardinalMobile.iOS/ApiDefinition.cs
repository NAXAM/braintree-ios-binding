using System;
using Foundation;
using ObjCRuntime;

namespace CardinalMobile
{
    ///**
    // * The Warning class represents a warning that is produced by the 3DS SDK while performing security checks during initialization.
    // */
    //@interface Warning : NSObject
    [BaseType(typeof(NSObject))]
    interface Warning
    {
        //@property (nonatomic, strong) NSString* warningID;
        [Export("warningID", ArgumentSemantic.Strong)]
        string WarningId { get; set; }

        //@property (nonatomic, strong) NSString* message;
        [Export("message", ArgumentSemantic.Strong)]
        string Message { get; set; }

        //@property (nonatomic, assign) Severity severity;
        [Export("severity", ArgumentSemantic.Strong)]
        Severity Severity { get; set; }
    }

    // interface UiCustomization : NSObject
    [BaseType(typeof(NSObject))]
    interface UiCustomization
    {
        // - (void)setButtonCustomization:(ButtonCustomization *)buttonCustomization
        //                      buttonType:(ButtonType)buttonType;
        [Export("setButtonCustomization:buttonType:")]
        void SetButtonCustomization(ButtonCustomization buttonCustomization, ButtonType buttonType);

        // - (void)setButtonCustomization:(ButtonCustomization *)buttonCustomization
        //                buttonTypeString:(NSString *)buttonType;
        [Export("setButtonCustomization:buttonTypeString:")]
        void SetButtonCustomization(ButtonCustomization buttonCustomization, string buttonType);

        // - (void)setToolbarCustomization:(ToolbarCustomization *)toolbarCustomization;
        [Export("setToolbarCustomization:")]
        void SetToolbarCustomization(ToolbarCustomization toolbarCustomization);

        // - (void)setLabelCustomization:(LabelCustomization *)labelCustomization;
        [Export("setLabelCustomization:")]
        void SetLabelCustomization(LabelCustomization labelCustomization);

        // - (void)setTextBoxCustomization:(TextBoxCustomization *)textBoxCustomization;
        [Export("setTextBoxCustomization")]
        void SetTextBoxCustomization(TextBoxCustomization textBoxCustomization);

        // - (ButtonCustomization *)getButtonCustomization:(ButtonType)buttonType;
        [Export("getButtonCustomization:")]
        ButtonCustomization GetButtonCustomization(ButtonType buttonType);

        // - (ButtonCustomization *)getButtonCustomizationFromString:(NSString *)buttonType;
        [Export("getButtonCustomizationFromString")]
        ButtonCustomization GetButtonCustomizationFromString();

        // - (ToolbarCustomization *)getToolbarCustomization;
        [Export("getToolbarCustomization")]
        ToolbarCustomization GetToolbarCustomization();

        // - (LabelCustomization *)getLabelCustomization;
        [Export("getLabelCustomization")]
        LabelCustomization GetLabelCustomization();

        // - (TextBoxCustomization *)getTextBoxCustomization;
        [Export("getTextBoxCustomization")]
        TextBoxCustomization GetTextBoxCustomization();
    }

    partial interface IChallengeStatusReceiver { }

    // protocol Transaction <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface Transaction
    {
        // - (nonnull AuthenticationRequestParameters*) getAuthenticationRequestParameters;
        [Export("getAuthenticationRequestParameters")]
        AuthenticationRequestParameters GetAuthenticationRequestParameters();

        // - (BOOL) doChallengeWithChallengeParameters: (ChallengeParameters *_Nonnull) challengeParameters
        //                     challengeStatusReceiver: (id<ChallengeStatusReceiver>_Nonnull) challengeStatusReceiver
        //                                     timeOut: (int) timeOut
        //                                       error: (NSError *_Nullable*_Nullable)error __attribute__((swift_error(nonnull_error))) NS_SWIFT_NAME(doChallenge(_:challengeStatusReceiver:timeOut:));
        [Export("doChallengeWithChallengeParameters:challengeStatusReceiver:timeOut:error:")]
        bool DoChallengeWithChallengeParameters(ChallengeParameters challengeParameters, IChallengeStatusReceiver challengeStatusReceiver, int timeOut, NSError error);

        // - (ProgressDialog *_Nonnull) getProgressView;
        [Export("getProgressView")]
        ProgressDialog GetProgressView();

        // - (void) close;
        [Export("close")]
        void Close();
    }

    // interface ToolbarCustomization : Customization
    [BaseType(typeof(Customization))]
    interface ToolbarCustomization
    {
        // @property (nonatomic, strong) NSString* backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        string BackgroundColor { get; set; }

        // @property (nonatomic, strong) NSString* headerText;
        [Export("headerText", ArgumentSemantic.Strong)]
        string HeaderText { get; set; }

        // @property (nonatomic, strong) NSString* buttonText;
        [Export("buttonText", ArgumentSemantic.Strong)]
        string ButtonText { get; set; }
    }

    // protocol ThreeDS2Service
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ThreeDS2Service
    {
        // - (BOOL) initializeWithConfig: (nonnull ConfigParameters *) configParameters
        //                        locale: (nullable NSString *) locale
        //               uiCustomization: (nullable UiCustomization *) uiCustomization
        //                         error: (NSError **)error __attribute__((swift_error(nonnull_error))) NS_SWIFT_NAME(initialize(_:locale:uiCustomization:));
        [Export("initializeWithConfig:locale:uiCustomization:error:")]
        IntPtr Constructor(ConfigParameters configParameters, string locale, UiCustomization uiCustomization, NSError error);

        // - (BOOL) initializeWithConfig: (nonnull ConfigParameters *) configParameters
        //                         error: (NSError **)error __attribute__((swift_error(nonnull_error))) NS_SWIFT_NAME(initialize(_:));
        [Export("initializeWithConfig:error:")]
        IntPtr Constructor(ConfigParameters configParameters, NSError error);

        // - (BOOL) initializeWithConfig: (nonnull ConfigParameters *) configParameters
        //                        locale: (nullable NSString *) locale
        //                         error: (NSError **)error __attribute__((swift_error(nonnull_error))) NS_SWIFT_NAME(initialize(_:locale:));
        [Export("initializeWithConfig:locale:error:")]
        IntPtr Constructor(ConfigParameters configParameters, string locale, NSError error);

        // - (BOOL) initializeWithConfig: (nonnull ConfigParameters *) configParameters
        //               uiCustomization: (nullable UiCustomization *) uiCustomization
        //                         error: (NSError **)error __attribute__((swift_error(nonnull_error)))
        // NS_SWIFT_NAME(initialize(_:uiCustomization:));
        [Export("initializeWithConfig:uiCustomization:error:")]
        IntPtr Constructor(ConfigParameters configParameters, UiCustomization uiCustomization, NSError error);

        // - (CardinalTransaction *) createTransactionWithDirectoryServerId: (NSString *) directoryServerId
        //                                             messageVersion: (NSString *) messageVersion
        //                                                      error: (NSError **)error __attribute__((swift_error(nonnull_error))) NS_SWIFT_NAME(createTransaction(_:messageVersion:));
        [Export("createTransactionWithDirectoryServerId:messageVersion:error:")]
        CardinalTransaction CreateTransactionWithDirectoryServerId(string directoryServerId, string messageVersion, NSError error);

        // - (CardinalTransaction *) createTransactionWithDirectoryServerId: (NSString *) directoryServerId
        //                                                      error: (NSError **)error __attribute__((swift_error(nonnull_error)))
        // NS_SWIFT_NAME(createTransaction(_:));
        [Export("createTransactionWithDirectoryServerId:error:")]
        CardinalTransaction CreateTransactionWithDirectoryServerId(string directoryServerId, NSError error);

        // - (BOOL) cleanup:(NSError **)error __attribute__((swift_error(nonnull_error)))
        // NS_SWIFT_NAME(cleanup());
        [Export("cleanup:")]
        string Cleanup(NSError error);

        // - (NSString *) getSDKVersion:(NSError **)error __attribute__((swift_error(nonnull_error)))
        // NS_SWIFT_NAME(getSDKVersion());
        [Export("getSDKVersion:")]
        string GetSDKVersion(NSError error);

        // - (NSArray<Warning *> *) getWarnings;
        [Export("getWarnings")]
        Warning[] GetWarnings();
    }

    // interface TextBoxCustomization : Customization
    [BaseType(typeof(Customization))]
    interface TextBoxCustomization
    {
        // @property int borderWidth;
        [Export("borderWidth", ArgumentSemantic.Assign)]
        int BorderWidth { get; set; }

        // @property (nonatomic, strong) NSString* borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        string BorderColor { get; set; }

        // @property int cornerRadius;
        [Export("cornerRadius", ArgumentSemantic.Assign)]
        int ErrorCode { get; set; }
    }

    // interface RuntimeErrorEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface RuntimeErrorEvent
    {
        // @property (nonatomic, strong, nonnull, readonly) NSString* errorCode;
        [Export("errorCode", ArgumentSemantic.Strong)]
        string ErrorCode { get; }

        // @property (nonatomic, strong, nonnull, readonly) NSString* errorMessage;
        [Export("errorMessage", ArgumentSemantic.Strong)]
        string ErrorMessage { get; }

        // - (id _Nonnull ) initWithErrorCode: (nonnull NSString *) errorCode
        //                       errorMessage: (nonnull NSString *) errorMessage;
        [Export("initWithErrorCode:errorMessage:")]
        IntPtr Constructor(string errorCode, string errorMessage);

        // - (nonnull NSString *) getErrorCode;
        [Export("getErrorCode")]
        string GetErrorCode();

        // - (nonnull NSString *) getErrorMessage;
        [Export("getErrorMessage")]
        string GetErrorMessage();

        // + (instancetype _Nonnull )new NS_UNAVAILABLE;
        // - (instancetype _Nonnull )init NS_UNAVAILABLE;
    }

    // interface ProtocolErrorEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface ProtocolErrorEvent
    {
        // - (id _Nonnull ) initWithSDKTransactionID: (nonnull NSString *) sdkTransactionID
        //                              errorMessage: (nonnull ErrorMessage *) errorMessage;
        [Export("initWithSDKTransactionID:errorMessage:")]
        IntPtr Constructor(string sdkTransactionID, ErrorMessage errorMessage);

        // @property (nonatomic, strong, nonnull, readonly) NSString* sdkTransactionID;
        [Export("sdkTransactionID", ArgumentSemantic.Strong)]
        string SdkTransactionID { get; }

        // @property (nonatomic, strong, nonnull, readonly) ErrorMessage* errorMessage;
        [Export("errorMessage", ArgumentSemantic.Strong)]
        ErrorMessage ErrorMessage { get; }

        // - (nonnull ErrorMessage *) getErrorMessage;
        [Export("getErrorMessage")]
        ErrorMessage GetErrorMessage();

        // - (nonnull NSString *) getSDKTransactionID;
        [Export("getSDKTransactionID")]
        string GetSDKTransactionID();

        // + (instancetype _Nonnull )new NS_UNAVAILABLE;
        // - (instancetype _Nonnull )init NS_UNAVAILABLE;
    }

    // interface ProgressDialog : NSObject
    [BaseType(typeof(NSObject))]
    interface ProgressDialog
    {
        // - (void) start;
        [Export("start")]
        string Start();

        // - (void) stop;
        [Export("stop")]
        string Stop();
    }

    // interface LabelCustomization : Customization
    [BaseType(typeof(Customization))]
    interface LabelCustomization
    {
        // @property (nonatomic, strong) NSString* headingTextColor;
        [Export("headingTextColor", ArgumentSemantic.Strong)]
        string HeadingTextColor { get; set; }

        // @property (nonatomic, strong) NSString* headingTextFontName;
        [Export("headingTextFontName", ArgumentSemantic.Strong)]
        string HeadingTextFontName { get; set; }

        // @property int headingTextFontSize;
        [Export("headingTextFontSize", ArgumentSemantic.Assign)]
        int HeadingTextFontSize { get; set; }
    }

    // interface ErrorMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface ErrorMessage
    {
        // @property (nonatomic, strong, readonly) NSString* transactionID;
        [Export("transactionID", ArgumentSemantic.Strong)]
        string TransactionId { get; set; }

        // @property (nonatomic, strong, readonly) NSString* errorCode;
        [Export("errorCode", ArgumentSemantic.Strong)]
        string ErrorCode { get; set; }

        // @property (nonatomic, strong, readonly) NSString* errorDescription;
        [Export("errorDescription", ArgumentSemantic.Strong)]
        string ErrorDescription { get; set; }

        // @property (nonatomic, strong, readonly) NSString* errorDetail;
        [Export("errorDetail", ArgumentSemantic.Strong)]
        string ErrorDetail { get; set; }

        // - (id) initWithTransactionID: (NSString *) transactionID
        //                    errorCode: (NSString *) errorCode
        //             errorDescription: (NSString *) errorDescription
        //                  errorDetail: (NSString *) errorDetail;
        [Export("initWithTransactionID:errorCode:errorDescription:errorDetail:")]
        IntPtr InitWithTransactionID(string transactionId, string errorCode, string errorDescription, string errorDetail);

        // - (NSString *) getTransactionID;
        [Export("getTransactionID")]
        string GetTransactionID();

        // - (NSString *) getErrorCode;
        [Export("getErrorCode")]
        string GetErrorCode();

        // - (NSString *) getErrorDescription;
        [Export("getErrorDescription")]
        string GetErrorDescription();

        // - (NSString *) getErrorDetails;
        [Export("getErrorDetails")]
        string GetErrorDetails();
    }

    // interface Customization : NSObject
    [BaseType(typeof(NSObject))]
    interface Customization
    {
        // @property (nonatomic, strong) NSString* textFontName;
        [Export("textFontName", ArgumentSemantic.Strong)]
        string TextFontName { get; set; }

        // @property (nonatomic, strong) NSString* textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        string TextColor { get; set; }

        // @property int textFontSize;
        [Export("textFontSize", ArgumentSemantic.Strong)]
        int TextFontSize { get; set; }
    }

    // interface ConfigParameters : NSObject
    [BaseType(typeof(NSObject))]
    interface ConfigParameters
    {
        // - (BOOL) addParamToGroup: (NSString *) group
        //            withParamName: (nonnull NSString*) paramName
        //               paramValue: (NSString*) paramValue
        //                    error: (NSError **)error __attribute__((swift_error(nonnull_error)))  NS_SWIFT_NAME(addParam(_:name:value:));
        [Export("addParamToGroup:withParamName:paramValue:error:")]
        bool AddParamToGroup(string group, string paramName, string paramValue, NSError error);

        // - (BOOL) addParamToGroup: (NSString *) group
        //            withParamName: (nonnull NSString*) paramName
        //                    error: (NSError **)error __attribute__((swift_error(nonnull_error)))  NS_SWIFT_NAME(addParam(_:name:));
        [Export("addParamToGroup:withParamName:error:")]
        bool AddParamToGroup(string group, string paramName, NSError error);

        // - (BOOL) addParamWithParamName: (nonnull NSString*) paramName
        //                     paramValue: (nonnull NSString*) paramValue
        //                          error: (NSError **)error __attribute__((swift_error(nonnull_error)))  NS_SWIFT_NAME(addParam(_:value:));
        [Export("addParamWithParamName:paramValue:error:")]
        bool AddParamWithParamName(string paramName, string paramValue, NSError error);

        // - (BOOL) addParamWithParamName: (nonnull NSString*) paramName
        //                          error: (NSError **)error __attribute__((swift_error(nonnull_error)))  NS_SWIFT_NAME(addParam(_:));
        [Export("addParamWithParamName:withParamName:paramValue:error:")]
        bool AddParamWithParamName(string paramName, NSError error);

        // - (nullable NSString *) getParamValueFromGroup: (NSString*) group
        //                                  withParamName: (nonnull NSString*) paramName
        //                                          error: (NSError **)error __attribute__((swift_error(nonnull_error)))  NS_SWIFT_NAME(getParam(_:name:));
        [Export("getParamValueFromGroup:withParamName:error:")]
        bool GetParamValueFromGroup(string group, string paramName, NSError error);

        // - (nullable NSString *) getParamValueWithParamName: (nonnull NSString*) paramName
        //                                              error: (NSError **)error __attribute__((swift_error(nonnull_error)))  NS_SWIFT_NAME(getParam(_:));
        [Export("getParamValueWithParamName:error:")]
        bool GetParamValueWithParamName(string paramName, NSError error);

        // - (nullable NSString *) removeParamFromGroup: (NSString*) group
        //                                withParamName: (nonnull NSString*) paramName
        //                                        error: (NSError **)error __attribute__((swift_error(nonnull_error))) NS_SWIFT_NAME(removeParam(_:name:));
        [Export("removeParamFromGroup:withParamName:error:")]
        bool RemoveParamFromGroup(string group, string paramName, NSError error);

        // - (nullable NSString *) removeParamWithParamName: (nonnull NSString*) paramName
        //                                            error: (NSError **)error __attribute__((swift_error(nonnull_error)))  NS_SWIFT_NAME(removeParam(_:));
        [Export("removeParamWithParamName:error:")]
        bool RemoveParamWithParamName(string paramName, NSError error);
    }

    // interface CompletionEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface CompletionEvent
    {
        // - (id _Nonnull ) initWithSDKTransactionID: (nonnull NSString *) sdkTransactionID
        //                         transactionStatus: (nonnull NSString *) transactionStatus;
        [Export("initWithSDKTransactionID:transactionStatus:")]
        IntPtr Constructor(string sdkTransactionID, string transactionStatus);

        // @property (nonatomic, strong, nonnull, readonly) NSString* sdkTransactionID;
        [Export("sdkTransactionID", ArgumentSemantic.Strong)]
        string SdkTransactionID { get; }

        // @property (nonatomic, strong, nonnull, readonly) NSString* transactionStatus;
        [Export("transactionStatus", ArgumentSemantic.Strong)]
        string TransactionStatus { get; }

        // - (nonnull NSString *) getSDKTransactionID;
        [Export("getSDKTransactionID")]
        string GetSDKTransactionID();

        // - (nonnull NSString *) getTransactionStatus;
        [Export("getTransactionStatus")]
        string GetTransactionStatus();

        // + (instancetype _Nonnull )new NS_UNAVAILABLE;
        // - (instancetype _Nonnull )init NS_UNAVAILABLE;
    }

    // protocol ChallengeStatusReceiver
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ChallengeStatusReceiver
    {
        // - (void) completed: (CompletionEvent *) completionEvent;
        [Export("completed:")]
        void Completed(CompletionEvent completionEvent);

        // - (void) cancelled;
        [Export("cancelled")]
        void Cancelled();

        // - (void) timedout;
        [Export("timedout")]
        void Timedout();

        // - (void) protocolError: (ProtocolErrorEvent *) protocolErrorEvent;
        [Export("protocolError:")]
        void ProtocolError(ProtocolErrorEvent protocolErrorEvent);

        // - (void) runtimeError: (RuntimeErrorEvent *) runtimeErrorEvent;
        [Export("runtimeError:")]
        void RuntimeError(RuntimeErrorEvent runtimeErrorEvent);
    }

    // interface ChallengeParameters : NSObject
    [BaseType(typeof(NSObject))]
    interface ChallengeParameters
    {
        // @property (nonatomic, strong) NSString* threeDSServerTransactionID;
        [Export("threeDSServerTransactionID", ArgumentSemantic.Strong)]
        string ThreeDSServerTransactionID { get; set; }

        // @property (nonatomic, strong) NSString* acsTransactionID;
        [Export("acsTransactionID", ArgumentSemantic.Strong)]
        string AcsTransactionID { get; set; }

        // @property (nonatomic, strong) NSString* acsRefNumber;
        [Export("acsRefNumber", ArgumentSemantic.Strong)]
        string AcsRefNumber { get; set; }

        // @property (nonatomic, strong) NSString* acsSignedContent;
        [Export("acsSignedContent", ArgumentSemantic.Strong)]
        string AcsSignedContent { get; set; }

        // @property (nonatomic, strong) NSString* threeDSRequestorAppURL;
        [Export("threeDSRequestorAppURL", ArgumentSemantic.Strong)]
        string ThreeDSRequestorAppURL { get; set; }

        // - (NSString *) get3DSServerTransactionID;
        [Export("get3DSServerTransactionID", ArgumentSemantic.Strong)]
        string Get3DSServerTransactionID();

        // - (NSString *) getAcsTransactionID;
        [Export("getAcsTransactionID")]
        string GetAcsTransactionID();

        // - (NSString *) getAcsRefNumber;
        [Export("getAcsRefNumber")]
        string GetAcsRefNumber { get; set; }

        // - (NSString *) getAcsSignedContent;
        [Export("getAcsSignedContent")]
        string GetAcsSignedContent();

        // - (NSString *) getThreeDSRequestorAppURL;
        [Export("getThreeDSRequestorAppURL")]
        string GetThreeDSRequestorAppURL();
    }

    // interface CardinalTransaction : NSObject<Transaction>
    [BaseType(typeof(NSObject))]
    interface CardinalTransaction : Transaction
    {
        // + (instancetype)new NS_UNAVAILABLE;
        // - (instancetype)init NS_UNAVAILABLE;
    }

    // interface CardinalThreeDS2ServiceImpl : NSObject<ThreeDS2Service>
    [BaseType(typeof(NSObject))]
    interface CardinalThreeDS2ServiceImpl : ThreeDS2Service
    {

    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CardinalValidationDelegate
    {
        // - (void)cardinalSession:(CardinalSession *)session
        // stepUpDidValidateWithResponse:(CardinalResponse *)validateResponse
        //             serverJWT:(NSString *)serverJWT NS_SWIFT_NAME(cardinalSession(cardinalSession:stepUpValidated:serverJWT:));
        [Abstract, Export("cardinalSession:stepUpDidValidateWithResponse:serverJWT:")]
        void CardinalSession(CardinalSession session, CardinalResponse validateResponse, string serverJWT);
    }
    // interface CardinalSessionConfiguration : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface CardinalSessionConfiguration : INSCopying
    {
        // @property (nonatomic, assign) CardinalSessionEnvironment deploymentEnvironment;
        [Export("deploymentEnvironment", ArgumentSemantic.Assign)]
        CardinalSessionEnvironment DeploymentEnvironment { get; set; }

        // @property (nonatomic, assign) NSUInteger timeout DEPRECATED_ATTRIBUTE;
        [Export("timeout", ArgumentSemantic.Assign)]
        [Deprecated(PlatformName.iOS, PlatformArchitecture.All, "")]
        uint Timeout { get; set; }

        // @property (nonatomic, assign) NSUInteger requestTimeout;
        [Export("requestTimeout", ArgumentSemantic.Assign)]
        uint RequestTimeout { get; set; }

        // @property (nonatomic, assign) NSUInteger challengeTimeout;
        [Export("challengeTimeout", ArgumentSemantic.Assign)]
        uint ChallengeTimeout { get; set; }

        // @property (nonatomic, copy, nullable) NSURL *proxyServerURL;
        [Export("proxyServerURL", ArgumentSemantic.Copy), NullAllowed]
        [return: NullAllowed]
        NSUrl ProxyServerURL { get; set; }

        // @property (nonatomic, assign) CardinalSessionUIType uiType;
        [Export("uiType", ArgumentSemantic.Assign)]
        CardinalSessionUIType UIType { get; set; }

        // @property (nonatomic) BOOL enableQuickAuth;
        [Export("enableQuickAuth", ArgumentSemantic.Assign)]
        bool EnableQuickAuth { get; set; }

        // @property (nonatomic, copy) CardinalSessionRenderTypeArray *renderType;
        [Export("renderType", ArgumentSemantic.Copy)]
        string[] RenderType { get; set; }

        // @property (nonatomic, strong) UiCustomization *uiCustomization;
        [Export("uiCustomization", ArgumentSemantic.Strong)]
        UiCustomization UiCustomization { get; set; }

        // @property (nonatomic, strong) UiCustomization *darkModeUiCustomization;
        [Export("darkModeUiCustomization", ArgumentSemantic.Strong)]
        UiCustomization DarkModeUiCustomization { get; set; }

        // @property (nonatomic) BOOL enableDFSync;
        [Export("enableDFSync", ArgumentSemantic.Assign)]
        bool EnableDFSync { get; set; }

        // @property (nonatomic, copy, nullable) NSString *threeDSRequestorAppURL;
        [Export("threeDSRequestorAppURL", ArgumentSemantic.Copy), NullAllowed]
        [return: NullAllowed]
        string ThreeDSRequestorAppURL { get; set; }
    }

    [Static]
    interface CardinalSessionTypeConstants
    {
        // extern CardinalSessionRenderType const *CardinalSessionRenderTypeOTP;
        [Field("CardinalSessionRenderTypeOTP", "__Internal")]
        NSString OTP { get; }

        // extern CardinalSessionRenderType const *CardinalSessionRenderTypeSingleSelect;
        [Field("CardinalSessionRenderTypeSingleSelect", "__Internal")]
        NSString SingleSelect { get; }

        // extern CardinalSessionRenderType const *CardinalSessionRenderTypeMultiSelect;
        [Field("CardinalSessionRenderTypeMultiSelect", "__Internal")]
        NSString MultiSelect { get; }

        // extern CardinalSessionRenderType const *CardinalSessionRenderTypeOOB;
        [Field("CardinalSessionRenderTypeOOB", "__Internal")]
        NSString OOB { get; }

        // extern CardinalSessionRenderType const *CardinalSessionRenderTypeHTML;
        [Field("CardinalSessionRenderTypeHTML", "__Internal")]
        NSString HTML { get; }
    }

    [Static]
    interface CardinalSessionEnvironmentConstants
    {
        // extern const CardinalSessionEnvironment CardinalSessionEnvironmentDEFAULT;
        [Field("CardinalSessionEnvironmentDEFAULT", "__Internal")]
        CardinalSessionEnvironment DEFAULT { get; }
    }

    [Static]
    interface CardinalSessionTimeoutConstants
    {

        // extern NSUInteger const CardinalSessionTimeoutStandard;
        [Field("CardinalSessionTimeoutStandard", "__Internal")]
        nuint Standard { get; }

        // extern NSUInteger const CardinalSessionTimeoutDEFAULT;
        [Field("CardinalSessionTimeoutDEFAULT", "__Internal")]
        nuint DEFAULT { get; }
    }

    // interface CardinalSessionConfig : CardinalSessionConfiguration
    [BaseType(typeof(CardinalSessionConfiguration))]
    interface CardinalSessionConfig { }

    // typedef void (^CardinalSessionSetupDidCompleteHandler)(NSString *consumerSessionId);
    delegate void CardinalSessionSetupDidCompleteHandler(string consumerSessionId);

    // /*!
    //  * Code block to be invoked on the main thread if Cardinal Setup fails.
    //  * If no error occurs this code block will not be invoked.
    //  *
    //  * @param validateResponse This parameter will populated with data to indicate what problem occurred during Setup.
    //  */
    // typedef void (^CardinalSessionSetupDidValidateHandler)(CardinalResponse *validateResponse);
    delegate void CardinalSessionSetupDidValidateHandler(CardinalResponse validateResponse);

    // /*!
    //  * Code block to be invoked on the main thread upon successful completion of the Process Bin step.
    //  * If an error occurs this code block will not be invoked.
    //  */
    // typedef void (^CardinalSessionProcessBinDidCompleteHandler)(void);
    delegate void CardinalSessionProcessBinDidCompleteHandler();

    partial interface ICardinalValidationDelegate { }

    // /*!
    //  * @interface CardinalSession
    //  * @brief CardinalSession Class for configuring, setting up and providing information for a given session of transaction.
    //  */
    // @interface CardinalSession : NSObject
    [BaseType(typeof(NSObject))]
    interface CardinalSession
    {
        // - (void)configure:(CardinalSessionConfiguration*)sessionConfig;
        [Export("configure:")]
        void Configure(CardinalSessionConfiguration sessionConfig);

        // - (void)setupWithJWT:(NSString*)jwtString
        //          didComplete:(CardinalSessionSetupDidCompleteHandler)didCompleteHandler
        //          didValidate:(CardinalSessionSetupDidValidateHandler)didValidateHandler NS_SWIFT_NAME(setup(jwtString:completed:validated:));
        [Export("setupWithJWT:didComplete:didValidate:")]
        void SetupWithJWT(string jwtString, CardinalSessionSetupDidCompleteHandler didCompleteHandler, CardinalSessionSetupDidValidateHandler didValidateHandler);

        // - (void)setupWithJWT:(NSString*)jwtString
        //        accountNumber:(NSString*)accountNumber
        //          didComplete:(CardinalSessionSetupDidCompleteHandler)didCompleteHandler
        //          didValidate:(CardinalSessionSetupDidValidateHandler)didValidateHandler NS_SWIFT_NAME(setup(jwtString:account:completed:validated:));
        [Export("setupWithJWT:accountNumber:didComplete:didValidate:")]
        void SetupWithJWT(string jwtString, string accountNumber, CardinalSessionSetupDidCompleteHandler didCompleteHandler, CardinalSessionSetupDidValidateHandler didValidateHandler);

        // - (void)processBin:(NSString*)accountNumber
        //        didComplete:(nullable CardinalSessionProcessBinDidCompleteHandler)didCompleteHandler NS_SWIFT_NAME(processBin(_:completed:));
        [Export("processBin:didComplete:")]
        void ProcessBin(string accountNumber, CardinalSessionProcessBinDidCompleteHandler didCompleteHandler);

        // - (void)continueWithTransactionId:(nonnull NSString *)transactionId
        //                           payload:(nonnull NSString *)payload
        //                            acsUrl:(nonnull NSString *)acsUrl
        //                 directoryServerID:(CCADirectoryServerID) directoryServerID
        //               didValidateDelegate:(nonnull id<CardinalValidationDelegate>)validationDelegate NS_SWIFT_NAME(continueWith(transactionId:payload:acsUrl:directoryServerID:validationDelegate:)) __deprecated;
        [Export("continueWithTransactionId:payload:acsUrl:directoryServerID:didValidateDelegate:")]
        void ContinueWithTransactionId(string transactionId, string payload, string acsUrl, CCADirectoryServerID directoryServerID, ICardinalValidationDelegate validationDelegate);

        // - (void)continueWithTransactionId:(nonnull NSString *)transactionId
        //                           payload:(nonnull NSString *)payload
        //                 directoryServerID:(CCADirectoryServerID) directoryServerID
        //               didValidateDelegate:(nonnull id<CardinalValidationDelegate>)validationDelegate NS_SWIFT_NAME(continueWith(transactionId:payload:directoryServerID:validationDelegate:)) __deprecated;
        [Export("continueWithTransactionId:payload:directoryServerID:didValidateDelegate:")]
        void ContinueWithTransactionId(string transactionId, string payload, CCADirectoryServerID directoryServerID, ICardinalValidationDelegate validationDelegate);

        // - (void)continueWithTransactionId:(nonnull NSString *)transactionId
        //                           payload:(nonnull NSString *)payload
        //               didValidateDelegate:(nonnull id<CardinalValidationDelegate>)validationDelegate NS_SWIFT_NAME(continueWith(transactionId:payload:validationDelegate:));
        [Export("continueWithTransactionId:payload:didValidateDelegate:")]
        void continueWithTransactionId(string transactionId, string payload, ICardinalValidationDelegate validationDelegate);

        // - (NSArray<Warning *> *)getWarnings;
        [Export("getWarnings")]
        Warning[] GetWarnings();

        // + (NSString *)getSDKBuildNumber;
        [Export("getSDKBuildNumber"), Static]
        string GetSDKBuildNumber();

        // + (NSString *)getSDKBuildVersion;
        [Export("getSDKBuildVersion"), Static]
        string GetSDKBuildVersion();
    }

    // interface CardinalPaymentExtendedData : NSObject
    [BaseType(typeof(NSObject))]
    interface CardinalPaymentExtendedData
    {
        // @property (nonatomic, readonly) NSString *enrolled;
        [Export("enrolled")]
        string Enrolled { get; }

        // @property (nonatomic, readonly) NSString *paResStatus;
        [Export("paResStatus")]
        string PaResStatus { get; }

        // @property (nonatomic, readonly) NSString *signatureVerification;
        [Export("signatureVerification")]
        string SignatureVerification { get; }

        // @property (nonatomic, readonly) NSString *cavv;
        [Export("cavv")]
        string Cavv { get; }

        // @property (nonatomic, readonly) NSString *eciFlag;
        [Export("eciFlag")]
        string EciFlag { get; }

        // @property (nonatomic, readonly) NSString *xid;
        [Export("xid")]
        string Xid { get; }

        // + (instancetype)new NS_UNAVAILABLE;
        // - (instancetype)init NS_UNAVAILABLE;
    }

    // @interface CardinalPayment : NSObject
    [BaseType(typeof(NSObject))]
    interface CardinalPayment
    {
        // @property (nonatomic, readonly) NSString *type;
        [Export("type")]
        string Type { get; }

        // @property (nonatomic, readonly) NSString *processorTransactionId;
        [Export("processorTransactionId")]
        string ProcessorTransactionId { get; }

        // @property (nullable, nonatomic, readonly) CardinalPaymentExtendedData *extendedData;
        [Export("extendedData"), NullAllowed]
        [return: NullAllowed]
        CardinalPaymentExtendedData ExtendedData { get; }

        // + (instancetype)new NS_UNAVAILABLE;
        // - (instancetype)init NS_UNAVAILABLE;
    }

    // @interface CardinalResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface CardinalResponse
    {
        // @property (nonatomic, readonly) BOOL isValidated;
        [Export("isValidated")]
        bool IsValidated { get; }

        // @property (nullable, nonatomic, readonly) CardinalPayment *payment;
        [Export("payment"), NullAllowed]
        [return: NullAllowed]
        CardinalPayment Payment { get; }

        // @property (nonatomic, readonly) CardinalResponseActionCode actionCode;
        [Export("actionCode")]
        CardinalResponseActionCode ActionCode { get; }

        // @property (nonatomic, readonly) NSInteger errorNumber;
        [Export("errorNumber")]
        long ErrorNumber { get; }

        // @property (nonatomic, readonly) NSString *errorDescription;
        [Export("errorDescription")]
        string ErrorDescription { get; }

        // + (instancetype)new NS_UNAVAILABLE;
        // - (instancetype)init NS_UNAVAILABLE;
    }

    [BaseType(typeof(Customization))]
    interface ButtonCustomization
    {
        // @property (nonatomic, strong) NSString* backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        string BackgroundColor { get; set; }

        // @property int cornerRadius;
        [Export("cornerRadius", ArgumentSemantic.Assign)]
        int CornerRadius { get; set; }
    }

    [BaseType(typeof(NSObject))]
    interface AuthenticationRequestParameters
    {
        // - (id _Nonnull ) initWithSDKTransactionId: (NSString *_Nonnull) sdkTransactionId
        //                             deviceData: (NSString *_Nonnull) deviceData
        //                     sdkEphemeralPublicKey: (NSString *_Nonnull) sdkEphemeralPublicKey
        //                                 sdkAppID: (NSString *_Nonnull) sdkAppID
        //                     sdkReferenceNumber: (NSString *_Nonnull) sdkReferenceNumber
        //                         messageVersion: (NSString *_Nonnull) messageVersion;
        [Export("initWithSDKTransactionId:deviceData:sdkEphermeralPublicKey:sdkAppID:sdkReferenceNumber:messageVersion:")]
        IntPtr Constructor(string sdkTransactionId, string deviceData, string sdkEphemeralPublicKey, string sdkAppID, string sdkReferenceNumber, string messageVersion);

        // @property (nonnull, nonatomic, strong, readonly) NSString* sdkTransactionID;
        [Export("sdkTransactionID", ArgumentSemantic.Strong)]
        [return: NullAllowed]
        string SdkTransactionID { get; }

        // @property (nullable, nonatomic, strong, readonly) NSString* deviceData;
        [Export("deviceData", ArgumentSemantic.Strong)]
        [return: NullAllowed]
        string DeviceData { get; }

        // @property (nonnull, nonatomic, strong, readonly) NSString* sdkEphemeralPublicKey;
        [Export("sdkEphemeralPublicKey", ArgumentSemantic.Strong)]
        string SdkEphemeralPublicKey { get; }

        // @property (nonnull, nonatomic, strong, readonly) NSString* sdkAppID;
        [Export("sdkAppID", ArgumentSemantic.Strong)]
        string SdkAppID { get; }

        // @property (nonnull, nonatomic, strong, readonly) NSString* sdkReferenceNumber;
        [Export("sdkReferenceNumber", ArgumentSemantic.Strong)]
        string SdkReferenceNumber { get; }

        // @property (nonnull, nonatomic, strong, readonly) NSString* messageVersion;
        [Export("messageVersion", ArgumentSemantic.Strong)]
        string MessageVersion { get; }

        // - (NSString *_Nullable) getDeviceData;
        [Export("getDeviceData")]
        [return: NullAllowed]
        string GetDeviceData();

        // - (NSString *_Nonnull) getSDKTransactionID;
        [Export("getSDKTransactionID")]
        string GetSDKTransactionID();

        // - (NSString *_Nonnull) getSDKAppID;
        [Export("getSDKAppID")]
        string GetSDKAppID();

        // - (NSString *_Nonnull) getSDKReferenceNumber;
        [Export("getSDKReferenceNumber")]
        string GetSDKReferenceNumber();

        // - (NSString *_Nonnull) getSDKEphemeralPublicKey;
        [Export("getSDKEphemeralPublicKey")]
        string GetSDKEphemeralPublicKey();

        // - (NSString *_Nonnull) getMessageVersion;
        [Export("getMessageVersion")]
        string GetMessageVersion();

        // + (instancetype _Nonnull )new NS_UNAVAILABLE;
        // - (instancetype _Nonnull )init NS_UNAVAILABLE;
    }
}