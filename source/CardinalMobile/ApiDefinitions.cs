using System;
using Foundation;
using ObjCRuntime;

namespace CardinalMobile
{
	// @interface AuthenticationRequestParameters : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface AuthenticationRequestParameters
	{
		// -(id _Nonnull)initWithSDKTransactionId:(NSString * _Nonnull)sdkTransactionId deviceData:(NSString * _Nonnull)deviceData sdkEphemeralPublicKey:(NSString * _Nonnull)sdkEphemeralPublicKey sdkAppID:(NSString * _Nonnull)sdkAppID sdkReferenceNumber:(NSString * _Nonnull)sdkReferenceNumber messageVersion:(NSString * _Nonnull)messageVersion;
		[Export("initWithSDKTransactionId:deviceData:sdkEphemeralPublicKey:sdkAppID:sdkReferenceNumber:messageVersion:")]
		IntPtr Constructor(string sdkTransactionId, string deviceData, string sdkEphemeralPublicKey, string sdkAppID, string sdkReferenceNumber, string messageVersion);

		// @property (readonly, nonatomic, strong) NSString * _Nonnull sdkTransactionID;
		[Export("sdkTransactionID", ArgumentSemantic.Strong)]
		string SdkTransactionID { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable deviceData;
		[NullAllowed, Export("deviceData", ArgumentSemantic.Strong)]
		string DeviceData { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull sdkEphemeralPublicKey;
		[Export("sdkEphemeralPublicKey", ArgumentSemantic.Strong)]
		string SdkEphemeralPublicKey { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull sdkAppID;
		[Export("sdkAppID", ArgumentSemantic.Strong)]
		string SdkAppID { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull sdkReferenceNumber;
		[Export("sdkReferenceNumber", ArgumentSemantic.Strong)]
		string SdkReferenceNumber { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull messageVersion;
		[Export("messageVersion", ArgumentSemantic.Strong)]
		string MessageVersion { get; }

		// -(NSString * _Nonnull)getSDKTransactionID;
		[Export("getSDKTransactionID")]
		string SDKTransactionID { get; }

		// -(NSString * _Nonnull)getSDKAppID;
		[Export("getSDKAppID")]
		string SDKAppID { get; }

		// -(NSString * _Nonnull)getSDKReferenceNumber;
		[Export("getSDKReferenceNumber")]
		string SDKReferenceNumber { get; }

		// -(NSString * _Nonnull)getSDKEphemeralPublicKey;
		[Export("getSDKEphemeralPublicKey")]
		string SDKEphemeralPublicKey { get; }
	}

	// @interface Customization : NSObject
	[BaseType(typeof(NSObject))]
	interface Customization
	{
		// @property (nonatomic, strong) NSString * textFontName;
		[Export("textFontName", ArgumentSemantic.Strong)]
		string TextFontName { get; set; }

		// @property (nonatomic, strong) NSString * textColor;
		[Export("textColor", ArgumentSemantic.Strong)]
		string TextColor { get; set; }

		// @property int textFontSize;
		[Export("textFontSize")]
		int TextFontSize { get; set; }
	}

	// @interface ButtonCustomization : Customization
	[BaseType(typeof(Customization))]
	interface ButtonCustomization
	{
		// @property (nonatomic, strong) NSString * backgroundColor;
		[Export("backgroundColor", ArgumentSemantic.Strong)]
		string BackgroundColor { get; set; }

		// @property int cornerRadius;
		[Export("cornerRadius")]
		int CornerRadius { get; set; }
	}

	// @interface CardinalPaymentExtendedData : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface CardinalPaymentExtendedData
	{
		// @property (readonly, nonatomic) NSString * _Nonnull enrolled;
		[Export("enrolled")]
		string Enrolled { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull paResStatus;
		[Export("paResStatus")]
		string PaResStatus { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull signatureVerification;
		[Export("signatureVerification")]
		string SignatureVerification { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull cavv;
		[Export("cavv")]
		string Cavv { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull eciFlag;
		[Export("eciFlag")]
		string EciFlag { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull xid;
		[Export("xid")]
		string Xid { get; }
	}

	// @interface CardinalPayment : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface CardinalPayment
	{
		// @property (readonly, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull processorTransactionId;
		[Export("processorTransactionId")]
		string ProcessorTransactionId { get; }

		// @property (readonly, nonatomic) CardinalPaymentExtendedData * _Nullable extendedData;
		[NullAllowed, Export("extendedData")]
		CardinalPaymentExtendedData ExtendedData { get; }
	}

	// @interface CardinalResponse : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface CardinalResponse
	{
		// @property (readonly, nonatomic) BOOL isValidated;
		[Export("isValidated")]
		bool IsValidated { get; }

		// @property (readonly, nonatomic) CardinalPayment * _Nullable payment;
		[NullAllowed, Export("payment")]
		CardinalPayment Payment { get; }

		// @property (readonly, nonatomic) CardinalResponseActionCode actionCode;
		[Export("actionCode")]
		CardinalResponseActionCode ActionCode { get; }

		// @property (readonly, nonatomic) NSInteger errorNumber;
		[Export("errorNumber")]
		nint ErrorNumber { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull errorDescription;
		[Export("errorDescription")]
		string ErrorDescription { get; }
	}

	// @interface Warning : NSObject
	[BaseType(typeof(NSObject))]
	interface Warning
	{
		// @property (nonatomic, strong) NSString * warningID;
		[Export("warningID", ArgumentSemantic.Strong)]
		string WarningID { get; set; }

		// @property (nonatomic, strong) NSString * message;
		[Export("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (assign, nonatomic) Severity severity;
		[Export("severity", ArgumentSemantic.Assign)]
		Severity Severity { get; set; }
	}

	// typedef void (^CardinalSessionSetupDidCompleteHandler)(NSString * _Nonnull);
	delegate void CardinalSessionSetupDidCompleteHandler(string arg0);

	// typedef void (^CardinalSessionSetupDidValidateHandler)(CardinalResponse * _Nonnull);
	delegate void CardinalSessionSetupDidValidateHandler(CardinalResponse arg0);

	// typedef void (^CardinalSessionProcessBinDidCompleteHandler)();
	delegate void CardinalSessionProcessBinDidCompleteHandler();

	partial interface ICardinalValidationDelegate { }

	// @interface CardinalSession : NSObject
	[BaseType(typeof(NSObject))]
	interface CardinalSession
	{
		// -(void)configure:(CardinalSessionConfiguration * _Nonnull)sessionConfig;
		[Export("configure:")]
		void Configure(CardinalSessionConfiguration sessionConfig);

		// -(void)setupWithJWT:(NSString * _Nonnull)jwtString didComplete:(CardinalSessionSetupDidCompleteHandler _Nonnull)didCompleteHandler didValidate:(CardinalSessionSetupDidValidateHandler _Nonnull)didValidateHandler __attribute__((swift_name("setup(jwtString:completed:validated:)")));
		[Export("setupWithJWT:didComplete:didValidate:")]
		void SetupWithJWT(string jwtString, CardinalSessionSetupDidCompleteHandler didCompleteHandler, CardinalSessionSetupDidValidateHandler didValidateHandler);

		// -(void)setupWithJWT:(NSString * _Nonnull)jwtString accountNumber:(NSString * _Nonnull)accountNumber didComplete:(CardinalSessionSetupDidCompleteHandler _Nonnull)didCompleteHandler didValidate:(CardinalSessionSetupDidValidateHandler _Nonnull)didValidateHandler __attribute__((swift_name("setup(jwtString:account:completed:validated:)"))) __attribute__((deprecated("")));
		[Export("setupWithJWT:accountNumber:didComplete:didValidate:")]
		void SetupWithJWT(string jwtString, string accountNumber, CardinalSessionSetupDidCompleteHandler didCompleteHandler, CardinalSessionSetupDidValidateHandler didValidateHandler);

		// -(void)processBin:(NSString * _Nonnull)accountNumber didComplete:(CardinalSessionProcessBinDidCompleteHandler _Nullable)didCompleteHandler __attribute__((swift_name("processBin(_:completed:)"))) __attribute__((deprecated("")));
		[Export("processBin:didComplete:")]
		void ProcessBin(string accountNumber, [NullAllowed] CardinalSessionProcessBinDidCompleteHandler didCompleteHandler);

		// -(void)continueWithTransactionId:(NSString * _Nonnull)transactionId payload:(NSString * _Nonnull)payload didValidateDelegate:(id<CardinalValidationDelegate> _Nonnull)validationDelegate __attribute__((swift_name("continueWith(transactionId:payload:validationDelegate:)")));
		[Export("continueWithTransactionId:payload:didValidateDelegate:")]
		void ContinueWithTransactionId(string transactionId, string payload, ICardinalValidationDelegate validationDelegate);

		// -(NSArray<Warning *> * _Nonnull)getWarnings;
		[Export("getWarnings")]
		Warning[] Warnings { get; }

		// +(NSString * _Nonnull)getSDKBuildNumber;
		[Static]
		[Export("getSDKBuildNumber")]
		string SDKBuildNumber { get; }

		// +(NSString * _Nonnull)getSDKBuildVersion;
		[Static]
		[Export("getSDKBuildVersion")]
		string SDKBuildVersion { get; }
	}

	// @interface ToolbarCustomization : Customization
	[BaseType(typeof(Customization))]
	interface ToolbarCustomization
	{
		// @property (nonatomic, strong) NSString * backgroundColor;
		[Export("backgroundColor", ArgumentSemantic.Strong)]
		string BackgroundColor { get; set; }

		// @property (nonatomic, strong) NSString * headerText;
		[Export("headerText", ArgumentSemantic.Strong)]
		string HeaderText { get; set; }

		// @property (nonatomic, strong) NSString * buttonText;
		[Export("buttonText", ArgumentSemantic.Strong)]
		string ButtonText { get; set; }
	}

	// @interface LabelCustomization : Customization
	[BaseType(typeof(Customization))]
	interface LabelCustomization
	{
		// @property (nonatomic, strong) NSString * headingTextColor;
		[Export("headingTextColor", ArgumentSemantic.Strong)]
		string HeadingTextColor { get; set; }

		// @property (nonatomic, strong) NSString * headingTextFontName;
		[Export("headingTextFontName", ArgumentSemantic.Strong)]
		string HeadingTextFontName { get; set; }

		// @property int headingTextFontSize;
		[Export("headingTextFontSize")]
		int HeadingTextFontSize { get; set; }
	}

	// @interface TextBoxCustomization : Customization
	[BaseType(typeof(Customization))]
	interface TextBoxCustomization
	{
		// @property int borderWidth;
		[Export("borderWidth")]
		int BorderWidth { get; set; }

		// @property (nonatomic, strong) NSString * borderColor;
		[Export("borderColor", ArgumentSemantic.Strong)]
		string BorderColor { get; set; }

		// @property int cornerRadius;
		[Export("cornerRadius")]
		int CornerRadius { get; set; }
	}

	// @interface UiCustomization : NSObject
	[BaseType(typeof(NSObject))]
	interface UiCustomization
	{
		// -(void)setButtonCustomization:(ButtonCustomization *)buttonCustomization buttonType:(ButtonType)buttonType;
		[Export("setButtonCustomization:buttonType:")]
		void SetButtonCustomization(ButtonCustomization buttonCustomization, ButtonType buttonType);

		// -(void)setButtonCustomization:(ButtonCustomization *)buttonCustomization buttonTypeString:(NSString *)buttonType;
		[Export("setButtonCustomization:buttonTypeString:")]
		void SetButtonCustomization(ButtonCustomization buttonCustomization, string buttonType);

		// -(void)setToolbarCustomization:(ToolbarCustomization *)toolbarCustomization;
		[Export("setToolbarCustomization:")]
		void SetToolbarCustomization(ToolbarCustomization toolbarCustomization);

		// -(void)setLabelCustomization:(LabelCustomization *)labelCustomization;
		[Export("setLabelCustomization:")]
		void SetLabelCustomization(LabelCustomization labelCustomization);

		// -(void)setTextBoxCustomization:(TextBoxCustomization *)textBoxCustomization;
		[Export("setTextBoxCustomization:")]
		void SetTextBoxCustomization(TextBoxCustomization textBoxCustomization);

		// -(ButtonCustomization *)getButtonCustomization:(ButtonType)buttonType;
		[Export("getButtonCustomization:")]
		ButtonCustomization GetButtonCustomization(ButtonType buttonType);

		// -(ButtonCustomization *)getButtonCustomizationFromString:(NSString *)buttonType;
		[Export("getButtonCustomizationFromString:")]
		ButtonCustomization GetButtonCustomizationFromString(string buttonType);

		// -(ToolbarCustomization *)getToolbarCustomization;
		[Export("getToolbarCustomization")]
		ToolbarCustomization ToolbarCustomization { get; }

		// -(LabelCustomization *)getLabelCustomization;
		[Export("getLabelCustomization")]
		LabelCustomization LabelCustomization { get; }

		// -(TextBoxCustomization *)getTextBoxCustomization;
		[Export("getTextBoxCustomization")]
		TextBoxCustomization TextBoxCustomization { get; }
	}

	[Static]
	partial interface CardinalSessionRenderTypeConstants
	{
		// extern const CardinalSessionRenderType * _Nonnull CardinalSessionRenderTypeOTP;
		[Field("CardinalSessionRenderTypeOTP", "__Internal")]
		NSString OTP { get; }

		// extern const CardinalSessionRenderType * _Nonnull CardinalSessionRenderTypeSingleSelect;
		[Field("CardinalSessionRenderTypeSingleSelect", "__Internal")]
		NSString SingleSelect { get; }

		// extern const CardinalSessionRenderType * _Nonnull CardinalSessionRenderTypeMultiSelect;
		[Field("CardinalSessionRenderTypeMultiSelect", "__Internal")]
		NSString MultiSelect { get; }

		// extern const CardinalSessionRenderType * _Nonnull CardinalSessionRenderTypeOOB;
		[Field("CardinalSessionRenderTypeOOB", "__Internal")]
		NSString OOB { get; }

		// extern const CardinalSessionRenderType * _Nonnull CardinalSessionRenderTypeHTML;
		[Field("CardinalSessionRenderTypeHTML", "__Internal")]
		NSString HTML { get; }
	}

	[Static]
	partial interface CardinalSessionEnvironmentConstants
	{
		// extern const CardinalSessionEnvironment CardinalSessionEnvironmentDEFAULT;
		[Field("CardinalSessionEnvironmentDEFAULT", "__Internal")]
		CardinalSessionEnvironment CardinalSessionEnvironmentDEFAULT { get; }

	}

	[Static]
	partial interface CardinalSessionTimeouConstants
	{
		// extern const NSUInteger CardinalSessionTimeoutStandard;
		[Field("CardinalSessionTimeoutStandard", "__Internal")]
		nuint Standard { get; }

		// extern const NSUInteger CardinalSessionTimeoutShort;
		[Field("CardinalSessionTimeoutShort", "__Internal")]
		nuint Short { get; }

		// extern const NSUInteger CardinalSessionTimeoutDEFAULT;
		[Field("CardinalSessionTimeoutDEFAULT", "__Internal")]
		nuint DEFAULT { get; }
	}

	// @interface CardinalSessionConfiguration : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface CardinalSessionConfiguration : INSCopying
	{
		// @property (assign, nonatomic) CardinalSessionEnvironment deploymentEnvironment;
		[Export("deploymentEnvironment", ArgumentSemantic.Assign)]
		CardinalSessionEnvironment DeploymentEnvironment { get; set; }

		// @property (assign, nonatomic) NSUInteger requestTimeout;
		[Export("requestTimeout")]
		nuint RequestTimeout { get; set; }

		// @property (assign, nonatomic) NSUInteger challengeTimeout;
		[Export("challengeTimeout")]
		nuint ChallengeTimeout { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable proxyServerURL;
		[NullAllowed, Export("proxyServerURL", ArgumentSemantic.Copy)]
		NSUrl ProxyServerURL { get; set; }

		// @property (assign, nonatomic) CardinalSessionUIType uiType;
		[Export("uiType", ArgumentSemantic.Assign)]
		CardinalSessionUIType UiType { get; set; }

		// @property (nonatomic) BOOL enableQuickAuth __attribute__((deprecated("")));
		[Export("enableQuickAuth")]
		bool EnableQuickAuth { get; set; }

		// @property (copy, nonatomic) CardinalSessionRenderTypeArray * _Nonnull renderType;
		[Export("renderType", ArgumentSemantic.Copy)]
		string[] RenderType { get; set; }

		// @property (nonatomic, strong) UiCustomization * _Nonnull uiCustomization;
		[Export("uiCustomization", ArgumentSemantic.Strong)]
		UiCustomization UiCustomization { get; set; }

		// @property (nonatomic, strong) UiCustomization * _Nonnull darkModeUiCustomization;
		[Export("darkModeUiCustomization", ArgumentSemantic.Strong)]
		UiCustomization DarkModeUiCustomization { get; set; }

		// @property (nonatomic) BOOL enableDFSync;
		[Export("enableDFSync")]
		bool EnableDFSync { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable threeDSRequestorAppURL;
		[NullAllowed, Export("threeDSRequestorAppURL")]
		string ThreeDSRequestorAppURL { get; set; }

		// @property (nonatomic) BOOL collectLogs;
		[Export("collectLogs")]
		bool CollectLogs { get; set; }
	}

	// @protocol CardinalValidationDelegate
	[Protocol, Model]
	interface CardinalValidationDelegate
	{
		// @required -(void)cardinalSession:(CardinalSession *)session stepUpDidValidateWithResponse:(CardinalResponse *)validateResponse serverJWT:(NSString *)serverJWT __attribute__((swift_name("cardinalSession(cardinalSession:stepUpValidated:serverJWT:)")));
		[Abstract]
		[Export("cardinalSession:stepUpDidValidateWithResponse:serverJWT:")]
		void StepUpDidValidateWithResponse(CardinalSession session, CardinalResponse validateResponse, string serverJWT);
	}

	// @interface ConfigParameters : NSObject
	[BaseType(typeof(NSObject))]
	interface ConfigParameters
	{
		// -(BOOL)addParamToGroup:(NSString * _Nonnull)group withParamName:(NSString * _Nonnull)paramName paramValue:(NSString * _Nonnull)paramValue error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("addParam(_:name:value:)")));
		[Export("addParamToGroup:withParamName:paramValue:error:")]
		bool AddParamToGroup(string group, string paramName, string paramValue, [NullAllowed] out NSError error);

		// -(BOOL)addParamToGroup:(NSString * _Nonnull)group withParamName:(NSString * _Nonnull)paramName error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("addParam(_:name:)")));
		[Export("addParamToGroup:withParamName:error:")]
		bool AddParamToGroup(string group, string paramName, [NullAllowed] out NSError error);

		// -(BOOL)addParamWithParamName:(NSString * _Nonnull)paramName paramValue:(NSString * _Nonnull)paramValue error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("addParam(_:value:)")));
		[Export("addParamWithParamName:paramValue:error:")]
		bool AddParamWithParamName(string paramName, string paramValue, [NullAllowed] out NSError error);

		// -(BOOL)addParamWithParamName:(NSString * _Nonnull)paramName error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("addParam(_:)")));
		[Export("addParamWithParamName:error:")]
		bool AddParamWithParamName(string paramName, [NullAllowed] out NSError error);

		// -(NSString * _Nullable)getParamValueFromGroup:(NSString * _Nonnull)group withParamName:(NSString * _Nonnull)paramName error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("getParam(_:name:)")));
		[Export("getParamValueFromGroup:withParamName:error:")]
		[return: NullAllowed]
		string GetParamValueFromGroup(string group, string paramName, [NullAllowed] out NSError error);

		// -(NSString * _Nullable)getParamValueWithParamName:(NSString * _Nonnull)paramName error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("getParam(_:)")));
		[Export("getParamValueWithParamName:error:")]
		[return: NullAllowed]
		string GetParamValueWithParamName(string paramName, [NullAllowed] out NSError error);

		// -(NSString * _Nullable)removeParamFromGroup:(NSString * _Nonnull)group withParamName:(NSString * _Nonnull)paramName error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("removeParam(_:name:)")));
		[Export("removeParamFromGroup:withParamName:error:")]
		[return: NullAllowed]
		string RemoveParamFromGroup(string group, string paramName, [NullAllowed] out NSError error);

		// -(NSString * _Nullable)removeParamWithParamName:(NSString * _Nonnull)paramName error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("removeParam(_:)")));
		[Export("removeParamWithParamName:error:")]
		[return: NullAllowed]
		string RemoveParamWithParamName(string paramName, [NullAllowed] out NSError error);
	}

	// @interface ProgressDialog : NSObject
	[BaseType(typeof(NSObject))]
	interface ProgressDialog
	{
		// -(void)start;
		[Export("start")]
		void Start();

		// -(void)stop;
		[Export("stop")]
		void Stop();
	}

	// @interface CompletionEvent : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface CompletionEvent
	{
		// -(id _Nonnull)initWithSDKTransactionID:(NSString * _Nonnull)sdkTransactionID transactionStatus:(NSString * _Nonnull)transactionStatus;
		[Export("initWithSDKTransactionID:transactionStatus:")]
		IntPtr Constructor(string sdkTransactionID, string transactionStatus);

		// @property (readonly, nonatomic, strong) NSString * _Nonnull sdkTransactionID;
		[Export("sdkTransactionID", ArgumentSemantic.Strong)]
		string SdkTransactionID { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull transactionStatus;
		[Export("transactionStatus", ArgumentSemantic.Strong)]
		string TransactionStatus { get; }
	}

	// @interface RuntimeErrorEvent : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface RuntimeErrorEvent
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull errorCode;
		[Export("errorCode", ArgumentSemantic.Strong)]
		string ErrorCode { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull errorMessage;
		[Export("errorMessage", ArgumentSemantic.Strong)]
		string ErrorMessage { get; }

		// -(id _Nonnull)initWithErrorCode:(NSString * _Nonnull)errorCode errorMessage:(NSString * _Nonnull)errorMessage;
		[Export("initWithErrorCode:errorMessage:")]
		IntPtr Constructor(string errorCode, string errorMessage);
	}

	// @interface ErrorMessage : NSObject
	[BaseType(typeof(NSObject))]
	interface ErrorMessage
	{
		// @property (readonly, nonatomic, strong) NSString * transactionID;
		[Export("transactionID", ArgumentSemantic.Strong)]
		string TransactionID { get; }

		// @property (readonly, nonatomic, strong) NSString * errorCode;
		[Export("errorCode", ArgumentSemantic.Strong)]
		string ErrorCode { get; }

		// @property (readonly, nonatomic, strong) NSString * errorDescription;
		[Export("errorDescription", ArgumentSemantic.Strong)]
		string ErrorDescription { get; }

		// @property (readonly, nonatomic, strong) NSString * errorDetail;
		[Export("errorDetail", ArgumentSemantic.Strong)]
		string ErrorDetail { get; }

		// -(id)initWithTransactionID:(NSString *)transactionID errorCode:(NSString *)errorCode errorDescription:(NSString *)errorDescription errorDetail:(NSString *)errorDetail;
		[Export("initWithTransactionID:errorCode:errorDescription:errorDetail:")]
		IntPtr Constructor(string transactionID, string errorCode, string errorDescription, string errorDetail);
	}

	// @interface ProtocolErrorEvent : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ProtocolErrorEvent
	{
		// -(id _Nonnull)initWithSDKTransactionID:(NSString * _Nonnull)sdkTransactionID errorMessage:(ErrorMessage * _Nonnull)errorMessage;
		[Export("initWithSDKTransactionID:errorMessage:")]
		IntPtr Constructor(string sdkTransactionID, ErrorMessage errorMessage);

		// @property (readonly, nonatomic, strong) NSString * _Nonnull sdkTransactionID;
		[Export("sdkTransactionID", ArgumentSemantic.Strong)]
		string SdkTransactionID { get; }

		// @property (readonly, nonatomic, strong) ErrorMessage * _Nonnull errorMessage;
		[Export("errorMessage", ArgumentSemantic.Strong)]
		ErrorMessage ErrorMessage { get; }
	}

	// @protocol ChallengeStatusReceiver
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/
	partial interface IChallengeStatusReceiver { }

    [Protocol]
	[BaseType (typeof(NSObject))]
	interface ChallengeStatusReceiver
	{
		// @required -(void)completed:(CompletionEvent *)completionEvent;
		[Abstract]
		[Export ("completed:")]
		void Completed (CompletionEvent completionEvent);

		// @required -(void)cancelled;
		[Abstract]
		[Export ("cancelled")]
		void Cancelled ();

		// @required -(void)timedout;
		[Abstract]
		[Export ("timedout")]
		void Timedout ();

		// @required -(void)protocolError:(ProtocolErrorEvent *)protocolErrorEvent;
		[Abstract]
		[Export ("protocolError:")]
		void ProtocolError (ProtocolErrorEvent protocolErrorEvent);

		// @required -(void)runtimeError:(RuntimeErrorEvent *)runtimeErrorEvent;
		[Abstract]
		[Export ("runtimeError:")]
		void RuntimeError (RuntimeErrorEvent runtimeErrorEvent);
	}

	// @interface ChallengeParameters : NSObject
	[BaseType (typeof(NSObject))]
	interface ChallengeParameters
	{
		// @property (nonatomic, strong) NSString * threeDSServerTransactionID;
		[Export ("threeDSServerTransactionID", ArgumentSemantic.Strong)]
		string ThreeDSServerTransactionID { get; set; }

		// @property (nonatomic, strong) NSString * acsTransactionID;
		[Export ("acsTransactionID", ArgumentSemantic.Strong)]
		string AcsTransactionID { get; set; }

		// @property (nonatomic, strong) NSString * acsRefNumber;
		[Export ("acsRefNumber", ArgumentSemantic.Strong)]
		string AcsRefNumber { get; set; }

		// @property (nonatomic, strong) NSString * acsSignedContent;
		[Export ("acsSignedContent", ArgumentSemantic.Strong)]
		string AcsSignedContent { get; set; }

		// @property (nonatomic, strong) NSString * threeDSRequestorAppURL;
		[Export ("threeDSRequestorAppURL", ArgumentSemantic.Strong)]
		string ThreeDSRequestorAppURL { get; set; }
	}

	// @protocol Transaction <NSObject>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface Transaction
	{
		// @required -(AuthenticationRequestParameters * _Nonnull)getAuthenticationRequestParameters;
		[Abstract]
		[Export ("getAuthenticationRequestParameters")]
		AuthenticationRequestParameters AuthenticationRequestParameters { get; }

		// @required -(BOOL)doChallengeWithChallengeParameters:(ChallengeParameters * _Nonnull)challengeParameters challengeStatusReceiver:(id<ChallengeStatusReceiver> _Nonnull)challengeStatusReceiver timeOut:(int)timeOut error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("doChallenge(_:challengeStatusReceiver:timeOut:)")));
		[Abstract]
		[Export ("doChallengeWithChallengeParameters:challengeStatusReceiver:timeOut:error:")]
		bool DoChallengeWithChallengeParameters (ChallengeParameters challengeParameters, IChallengeStatusReceiver challengeStatusReceiver, int timeOut, [NullAllowed] out NSError error);

		// @required -(ProgressDialog * _Nonnull)getProgressView;
		[Abstract]
		[Export ("getProgressView")]
		ProgressDialog ProgressView { get; }

		// @required -(void)close;
		[Abstract]
		[Export ("close")]
		void Close ();
	}

	// @interface CardinalTransaction : NSObject <Transaction>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface CardinalTransaction : Transaction
	{
	}

	// @protocol ThreeDS2Service
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
	*/
	[Protocol]
	[BaseType (typeof(NSObject))]
	interface ThreeDS2Service
	{
		// @required -(BOOL)initializeWithConfig:(ConfigParameters * _Nonnull)configParameters locale:(NSString * _Nullable)locale uiCustomization:(UiCustomization * _Nullable)uiCustomization error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("initialize(_:locale:uiCustomization:)")));
		[Abstract]
		[Export ("initializeWithConfig:locale:uiCustomization:error:")]
		bool InitializeWithConfig (ConfigParameters configParameters, [NullAllowed] string locale, [NullAllowed] UiCustomization uiCustomization, [NullAllowed] out NSError error);

		// @required -(BOOL)initializeWithConfig:(ConfigParameters * _Nonnull)configParameters error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("initialize(_:)")));
		[Abstract]
		[Export ("initializeWithConfig:error:")]
		bool InitializeWithConfig (ConfigParameters configParameters, [NullAllowed] out NSError error);

		// @required -(BOOL)initializeWithConfig:(ConfigParameters * _Nonnull)configParameters locale:(NSString * _Nullable)locale error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("initialize(_:locale:)")));
		[Abstract]
		[Export ("initializeWithConfig:locale:error:")]
		bool InitializeWithConfig (ConfigParameters configParameters, [NullAllowed] string locale, [NullAllowed] out NSError error);

		// @required -(BOOL)initializeWithConfig:(ConfigParameters * _Nonnull)configParameters uiCustomization:(UiCustomization * _Nullable)uiCustomization error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("initialize(_:uiCustomization:)")));
		[Abstract]
		[Export ("initializeWithConfig:uiCustomization:error:")]
		bool InitializeWithConfig (ConfigParameters configParameters, [NullAllowed] UiCustomization uiCustomization, [NullAllowed] out NSError error);

		// @required -(CardinalTransaction * _Nonnull)createTransactionWithDirectoryServerId:(NSString * _Nonnull)directoryServerId messageVersion:(NSString * _Nonnull)messageVersion error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("createTransaction(_:messageVersion:)")));
		[Abstract]
		[Export ("createTransactionWithDirectoryServerId:messageVersion:error:")]
		CardinalTransaction CreateTransactionWithDirectoryServerId (string directoryServerId, string messageVersion, [NullAllowed] out NSError error);

		// @required -(CardinalTransaction * _Nonnull)createTransactionWithDirectoryServerId:(NSString * _Nonnull)directoryServerId error:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("createTransaction(_:)")));
		[Abstract]
		[Export ("createTransactionWithDirectoryServerId:error:")]
		CardinalTransaction CreateTransactionWithDirectoryServerId (string directoryServerId, [NullAllowed] out NSError error);

		// @required -(BOOL)cleanup:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("cleanup()")));
		[Abstract]
		[Export ("cleanup:")]
		bool Cleanup ([NullAllowed] out NSError error);

		// @required -(NSString * _Nonnull)getSDKVersion:(NSError * _Nullable * _Nullable)error __attribute__((swift_error("nonnull_error"))) __attribute__((swift_name("getSDKVersion()")));
		[Abstract]
		[Export ("getSDKVersion:")]
		string GetSDKVersion ([NullAllowed] out NSError error);

		// @required -(NSArray<Warning *> * _Nonnull)getWarnings;
		[Abstract]
		[Export ("getWarnings")]
		Warning[] Warnings { get; }
	}

	// @interface CardinalThreeDS2ServiceImpl : NSObject <ThreeDS2Service>
	[BaseType (typeof(NSObject))]
	interface CardinalThreeDS2ServiceImpl : ThreeDS2Service
	{
	}
}
