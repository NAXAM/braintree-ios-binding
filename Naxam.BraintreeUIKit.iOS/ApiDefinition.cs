﻿﻿﻿using System;
using BraintreeUIKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace BraintreeUIKit
{
    partial interface IBTUIKExpiryInputViewDelegate {}

	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern double BraintreeUIKitVersionNumber;
	//	[Field ("BraintreeUIKitVersionNumber", "__Internal")]
	//	double BraintreeUIKitVersionNumber { get; }

	//	// extern const unsigned char [] BraintreeUIKitVersionString;
	//	[Field ("BraintreeUIKitVersionString", "__Internal")]
	//	byte[] BraintreeUIKitVersionString { get; }
	//}

	// @interface BTUIKTextField : UITextField
	[BaseType (typeof(UITextField))]
	interface BTUIKTextField
	{
		[Wrap ("WeakEditDelegate")]
		BTUIKTextFieldEditDelegate EditDelegate { get; set; }

		// @property (nonatomic, weak) id<BTUIKTextFieldEditDelegate> editDelegate;
		[NullAllowed, Export ("editDelegate", ArgumentSemantic.Weak)]
		NSObject WeakEditDelegate { get; set; }

		// @property (nonatomic) BOOL hideCaret;
		[Export ("hideCaret")]
		bool HideCaret { get; set; }
	}

	// @protocol BTUIKTextFieldEditDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTUIKTextFieldEditDelegate
	{
		// @optional -(void)textFieldWillDeleteBackward:(BTUIKTextField *)textField;
		[Export ("textFieldWillDeleteBackward:")]
		void TextFieldWillDeleteBackward (BTUIKTextField textField);

		// @optional -(void)textFieldDidDeleteBackward:(BTUIKTextField *)textField originalText:(NSString *)originalText;
		[Export ("textFieldDidDeleteBackward:originalText:")]
		void TextFieldDidDeleteBackward (BTUIKTextField textField, string originalText);

		// @optional -(void)textField:(BTUIKTextField *)textField willInsertText:(NSString *)text;
		[Export ("textField:willInsertText:")]
		void TextFieldWillInsertText (BTUIKTextField textField, string text);

		// @optional -(void)textField:(BTUIKTextField *)textField didInsertText:(NSString *)text;
		[Export ("textField:didInsertText:")]
		void TextFieldDidInsertText (BTUIKTextField textField, string text);
	}

	// @interface BTUIKFormField : UIView <UITextFieldDelegate, UIKeyInput>
	[BaseType (typeof(UIView))]
	interface BTUIKFormField : IUITextFieldDelegate, IUIKeyInput
	{
		[Wrap ("WeakDelegate")]
		BTUIKFormFieldDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BTUIKFormFieldDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL vibrateOnInvalidInput;
		[Export ("vibrateOnInvalidInput")]
		bool VibrateOnInvalidInput { get; set; }

		// @property (readonly, assign, nonatomic) BOOL valid;
		[Export ("valid")]
		bool Valid { get; }

		// @property (readonly, assign, nonatomic) BOOL entryComplete;
		[Export ("entryComplete")]
		bool EntryComplete { get; }

		// @property (assign, nonatomic) BOOL displayAsValid;
		[Export ("displayAsValid")]
		bool DisplayAsValid { get; set; }

		// @property (assign, nonatomic) BOOL bottomBorder;
		[Export ("bottomBorder")]
		bool BottomBorder { get; set; }

		// @property (assign, nonatomic) BOOL topBorder;
		[Export ("topBorder")]
		bool TopBorder { get; set; }

		// @property (assign, nonatomic) BOOL interFieldBorder;
		[Export ("interFieldBorder")]
		bool InterFieldBorder { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL backspace;
		[Export ("backspace")]
		bool Backspace { get; set; }

		// @property (copy, nonatomic) NSString * text;
		[Export ("text")]
		string Text { get; set; }

		// @property (nonatomic, strong) BTUIKTextField * textField;
		[Export ("textField", ArgumentSemantic.Strong)]
		BTUIKTextField TextField { get; set; }

		// @property (nonatomic, strong) UILabel * formLabel;
		[Export ("formLabel", ArgumentSemantic.Strong)]
		UILabel FormLabel { get; set; }

		// @property (nonatomic, strong) UIView * accessoryView;
		[Export ("accessoryView", ArgumentSemantic.Strong)]
		UIView AccessoryView { get; set; }

		// -(void)updateAppearance;
		[Export ("updateAppearance")]
		void UpdateAppearance ();

		// -(void)updateConstraints __attribute__((objc_requires_super));
		[Export ("updateConstraints")]
		//TODO [RequiresSuper]
		void UpdateConstraints ();

		// -(void)setAccessoryViewHidden:(BOOL)hidden animated:(BOOL)animated;
		[Export ("setAccessoryViewHidden:animated:")]
		void SetAccessoryViewHidden (bool hidden, bool animated);

		// -(void)resetFormField;
		[Export ("resetFormField")]
		void ResetFormField ();
	}

	// @protocol BTUIKFormFieldDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTUIKFormFieldDelegate
	{
		// @required -(void)formFieldDidChange:(BTUIKFormField *)formField;
		[Abstract]
		[Export ("formFieldDidChange:")]
		void FormFieldDidChange (BTUIKFormField formField);

		// @optional -(BOOL)formFieldShouldReturn:(BTUIKFormField *)formField;
		[Export ("formFieldShouldReturn:")]
		bool FormFieldShouldReturn (BTUIKFormField formField);

		// @optional -(void)formFieldDidBeginEditing:(BTUIKFormField *)formField;
		[Export ("formFieldDidBeginEditing:")]
		void FormFieldDidBeginEditing (BTUIKFormField formField);

		// @optional -(void)formFieldDidEndEditing:(BTUIKFormField *)formField;
		[Export ("formFieldDidEndEditing:")]
		void FormFieldDidEndEditing (BTUIKFormField formField);
	}

	// @interface BTUIKExpiryInputView : UIView <UITextFieldDelegate, UICollectionViewDataSource, UICollectionViewDelegateFlowLayout>
	[BaseType (typeof(UIView))]
	interface BTUIKExpiryInputView : IUITextFieldDelegate, IUICollectionViewDataSource, IUICollectionViewDelegateFlowLayout
	{
		// @property (nonatomic) NSInteger selectedYear;
		[Export ("selectedYear")]
		nint SelectedYear { get; set; }

		// @property (nonatomic) NSInteger selectedMonth;
		[Export ("selectedMonth")]
		nint SelectedMonth { get; set; }

		[Wrap ("WeakDelegate")]
		BTUIKExpiryInputViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BTUIKExpiryInputViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @protocol BTUIKExpiryInputViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTUIKExpiryInputViewDelegate
	{
		// @required -(void)expiryInputViewDidChange:(BTUIKExpiryInputView *)expiryInputView;
		[Abstract]
		[Export ("expiryInputViewDidChange:")]
		void ExpiryInputViewDidChange (BTUIKExpiryInputView expiryInputView);
	}

	// @interface BTUIKLocalizedString : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUIKLocalizedString
	{
		// +(NSString *)insertIntoLocalizedString:(NSString *)string replacement:(NSString *)replacement;
		[Static]
		[Export ("insertIntoLocalizedString:replacement:")]
		string InsertIntoLocalizedString (string @string, string replacement);

		// +(NSString *)insertIntoLocalizedString:(NSString *)string replacement:(NSString *)replacement token:(NSString *)token;
		[Static]
		[Export ("insertIntoLocalizedString:replacement:token:")]
		string InsertIntoLocalizedString (string @string, string replacement, string token);

		// +(NSString *)CARD_DETAILS_LABEL;
		[Static]
		[Export ("CARD_DETAILS_LABEL")]
		string CARD_DETAILS_LABEL { get; }

		// +(NSString *)ENTER_CARD_DETAILS_HELP_LABEL;
		[Static]
		[Export ("ENTER_CARD_DETAILS_HELP_LABEL")]
		string ENTER_CARD_DETAILS_HELP_LABEL { get; }

		// +(NSString *)VALID_CARD_ERROR_LABEL;
		[Static]
		[Export ("VALID_CARD_ERROR_LABEL")]
		string VALID_CARD_ERROR_LABEL { get; }

		// +(NSString *)CARD_REQUIRED;
		[Static]
		[Export ("CARD_REQUIRED")]
		string CARD_REQUIRED { get; }

		// +(NSString *)CARD_INVALID;
		[Static]
		[Export ("CARD_INVALID")]
		string CARD_INVALID { get; }

		// +(NSString *)EXPIRATION_REQUIRED;
		[Static]
		[Export ("EXPIRATION_REQUIRED")]
		string EXPIRATION_REQUIRED { get; }

		// +(NSString *)EXPIRATION_INVALID;
		[Static]
		[Export ("EXPIRATION_INVALID")]
		string EXPIRATION_INVALID { get; }

		// +(NSString *)CVV_REQUIRED;
		[Static]
		[Export ("CVV_REQUIRED")]
		string CVV_REQUIRED { get; }

		// +(NSString *)CVV_INVALID;
		[Static]
		[Export ("CVV_INVALID")]
		string CVV_INVALID { get; }

		// +(NSString *)POSTAL_CODE_HELP_LABEL;
		[Static]
		[Export ("POSTAL_CODE_HELP_LABEL")]
		string POSTAL_CODE_HELP_LABEL { get; }

		// +(NSString *)POSTAL_CODE_REQUIRED;
		[Static]
		[Export ("POSTAL_CODE_REQUIRED")]
		string POSTAL_CODE_REQUIRED { get; }

		// +(NSString *)POSTAL_CODE_INVALID;
		[Static]
		[Export ("POSTAL_CODE_INVALID")]
		string POSTAL_CODE_INVALID { get; }

		// +(NSString *)COUNTRY_CODE_REQUIRED;
		[Static]
		[Export ("COUNTRY_CODE_REQUIRED")]
		string COUNTRY_CODE_REQUIRED { get; }

		// +(NSString *)COUNTRY_CODE_INVALID;
		[Static]
		[Export ("COUNTRY_CODE_INVALID")]
		string COUNTRY_CODE_INVALID { get; }

		// +(NSString *)MOBILE_NUMBER_REQUIRED;
		[Static]
		[Export ("MOBILE_NUMBER_REQUIRED")]
		string MOBILE_NUMBER_REQUIRED { get; }

		// +(NSString *)MOBILE_NUMBER_INVALID;
		[Static]
		[Export ("MOBILE_NUMBER_INVALID")]
		string MOBILE_NUMBER_INVALID { get; }

		// +(NSString *)ENROLLMENT_WITH_SMS_HELP_LABEL;
		[Static]
		[Export ("ENROLLMENT_WITH_SMS_HELP_LABEL")]
		string ENROLLMENT_WITH_SMS_HELP_LABEL { get; }

		// +(NSString *)SMS_CODE_REQUIRED;
		[Static]
		[Export ("SMS_CODE_REQUIRED")]
		string SMS_CODE_REQUIRED { get; }

		// +(NSString *)SMS_CODE_INVALID;
		[Static]
		[Export ("SMS_CODE_INVALID")]
		string SMS_CODE_INVALID { get; }

		// +(NSString *)CANCEL_ACTION;
		[Static]
		[Export ("CANCEL_ACTION")]
		string CANCEL_ACTION { get; }

		// +(NSString *)RETRY_ACTION;
		[Static]
		[Export ("RETRY_ACTION")]
		string RETRY_ACTION { get; }

		// +(NSString *)CONTINUE_ACTION;
		[Static]
		[Export ("CONTINUE_ACTION")]
		string CONTINUE_ACTION { get; }

		// +(NSString *)ADD_CARD_ACTION;
		[Static]
		[Export ("ADD_CARD_ACTION")]
		string ADD_CARD_ACTION { get; }

		// +(NSString *)DONE_ACTION;
		[Static]
		[Export ("DONE_ACTION")]
		string DONE_ACTION { get; }

		// +(NSString *)EDIT_ACTION;
		[Static]
		[Export ("EDIT_ACTION")]
		string EDIT_ACTION { get; }

		// +(NSString *)NEXT_ACTION;
		[Static]
		[Export ("NEXT_ACTION")]
		string NEXT_ACTION { get; }

		// +(NSString *)TOP_LEVEL_ERROR_ALERT_VIEW_OK_BUTTON_TEXT;
		[Static]
		[Export ("TOP_LEVEL_ERROR_ALERT_VIEW_OK_BUTTON_TEXT")]
		string TOP_LEVEL_ERROR_ALERT_VIEW_OK_BUTTON_TEXT { get; }

		// +(NSString *)SCAN_CARD_IO_ACTION;
		[Static]
		[Export ("SCAN_CARD_IO_ACTION")]
		string SCAN_CARD_IO_ACTION { get; }

		// +(NSString *)EDIT_PAYMENT_METHOD;
		[Static]
		[Export ("EDIT_PAYMENT_METHOD")]
		string EDIT_PAYMENT_METHOD { get; }

		// +(NSString *)THERE_WAS_AN_ERROR;
		[Static]
		[Export ("THERE_WAS_AN_ERROR")]
		string THERE_WAS_AN_ERROR { get; }

		// +(NSString *)REVIEW_AND_TRY_AGAIN;
		[Static]
		[Export ("REVIEW_AND_TRY_AGAIN")]
		string REVIEW_AND_TRY_AGAIN { get; }

		// +(NSString *)INVALID_LABEL;
		[Static]
		[Export ("INVALID_LABEL")]
		string INVALID_LABEL { get; }

		// +(NSString *)YEAR_LABEL;
		[Static]
		[Export ("YEAR_LABEL")]
		string YEAR_LABEL { get; }

		// +(NSString *)MONTH_LABEL;
		[Static]
		[Export ("MONTH_LABEL")]
		string MONTH_LABEL { get; }

		// +(NSString *)OTHER_LABEL;
		[Static]
		[Export ("OTHER_LABEL")]
		string OTHER_LABEL { get; }

		// +(NSString *)CREDIT_OR_DEBIT_CARD_LABEL;
		[Static]
		[Export ("CREDIT_OR_DEBIT_CARD_LABEL")]
		string CREDIT_OR_DEBIT_CARD_LABEL { get; }

		// +(NSString *)RECENT_LABEL;
		[Static]
		[Export ("RECENT_LABEL")]
		string RECENT_LABEL { get; }

		// +(NSString *)SELECT_PAYMENT_LABEL;
		[Static]
		[Export ("SELECT_PAYMENT_LABEL")]
		string SELECT_PAYMENT_LABEL { get; }

		// +(NSString *)CONFIRM_ENROLLMENT_LABEL;
		[Static]
		[Export ("CONFIRM_ENROLLMENT_LABEL")]
		string CONFIRM_ENROLLMENT_LABEL { get; }

		// +(NSString *)CONFIRM_ACTION;
		[Static]
		[Export ("CONFIRM_ACTION")]
		string CONFIRM_ACTION { get; }

		// +(NSString *)ENTER_SMS_CODE_SENT_HELP_LABEL;
		[Static]
		[Export ("ENTER_SMS_CODE_SENT_HELP_LABEL")]
		string ENTER_SMS_CODE_SENT_HELP_LABEL { get; }

		// +(NSString *)SMS_CODE_LABEL;
		[Static]
		[Export ("SMS_CODE_LABEL")]
		string SMS_CODE_LABEL { get; }

		// +(NSString *)CARD_TYPE_GENERIC_CARD;
		[Static]
		[Export ("CARD_TYPE_GENERIC_CARD")]
		string CARD_TYPE_GENERIC_CARD { get; }

		// +(NSString *)MOBILE_COUNTRY_CODE_LABEL;
		[Static]
		[Export ("MOBILE_COUNTRY_CODE_LABEL")]
		string MOBILE_COUNTRY_CODE_LABEL { get; }

		// +(NSString *)SECURITY_CODE_LABEL;
		[Static]
		[Export ("SECURITY_CODE_LABEL")]
		string SECURITY_CODE_LABEL { get; }

		// +(NSString *)CVV_FIELD_PLACEHOLDER;
		[Static]
		[Export ("CVV_FIELD_PLACEHOLDER")]
		string CVV_FIELD_PLACEHOLDER { get; }

		// +(NSString *)CVC_FIELD_PLACEHOLDER;
		[Static]
		[Export ("CVC_FIELD_PLACEHOLDER")]
		string CVC_FIELD_PLACEHOLDER { get; }

		// +(NSString *)CID_FIELD_PLACEHOLDER;
		[Static]
		[Export ("CID_FIELD_PLACEHOLDER")]
		string CID_FIELD_PLACEHOLDER { get; }

		// +(NSString *)CVN_FIELD_PLACEHOLDER;
		[Static]
		[Export ("CVN_FIELD_PLACEHOLDER")]
		string CVN_FIELD_PLACEHOLDER { get; }

		// +(NSString *)POSTAL_CODE_PLACEHOLDER;
		[Static]
		[Export ("POSTAL_CODE_PLACEHOLDER")]
		string POSTAL_CODE_PLACEHOLDER { get; }

		// +(NSString *)MOBILE_NUMBER_LABEL;
		[Static]
		[Export ("MOBILE_NUMBER_LABEL")]
		string MOBILE_NUMBER_LABEL { get; }

		// +(NSString *)EXPIRATION_DATE_LABEL;
		[Static]
		[Export ("EXPIRATION_DATE_LABEL")]
		string EXPIRATION_DATE_LABEL { get; }

		// +(NSString *)CARD_NUMBER_PLACEHOLDER;
		[Static]
		[Export ("CARD_NUMBER_PLACEHOLDER")]
		string CARD_NUMBER_PLACEHOLDER { get; }

		// +(NSString *)EXPIRY_PLACEHOLDER_FOUR_DIGIT_YEAR;
		[Static]
		[Export ("EXPIRY_PLACEHOLDER_FOUR_DIGIT_YEAR")]
		string EXPIRY_PLACEHOLDER_FOUR_DIGIT_YEAR { get; }

		// +(NSString *)EXPIRY_PLACEHOLDER_TWO_DIGIT_YEAR;
		[Static]
		[Export ("EXPIRY_PLACEHOLDER_TWO_DIGIT_YEAR")]
		string EXPIRY_PLACEHOLDER_TWO_DIGIT_YEAR { get; }

		// +(NSString *)PAYPAL;
		[Static]
		[Export ("PAYPAL")]
		string PAYPAL { get; }

		// +(NSString *)CARD_TYPE_AMERICAN_EXPRESS;
		[Static]
		[Export ("CARD_TYPE_AMERICAN_EXPRESS")]
		string CARD_TYPE_AMERICAN_EXPRESS { get; }

		// +(NSString *)CARD_TYPE_DISCOVER;
		[Static]
		[Export ("CARD_TYPE_DISCOVER")]
		string CARD_TYPE_DISCOVER { get; }

		// +(NSString *)CARD_TYPE_DINERS_CLUB;
		[Static]
		[Export ("CARD_TYPE_DINERS_CLUB")]
		string CARD_TYPE_DINERS_CLUB { get; }

		// +(NSString *)CARD_TYPE_MASTER_CARD;
		[Static]
		[Export ("CARD_TYPE_MASTER_CARD")]
		string CARD_TYPE_MASTER_CARD { get; }

		// +(NSString *)CARD_TYPE_VISA;
		[Static]
		[Export ("CARD_TYPE_VISA")]
		string CARD_TYPE_VISA { get; }

		// +(NSString *)CARD_TYPE_JCB;
		[Static]
		[Export ("CARD_TYPE_JCB")]
		string CARD_TYPE_JCB { get; }

		// +(NSString *)CARD_TYPE_MAESTRO;
		[Static]
		[Export ("CARD_TYPE_MAESTRO")]
		string CARD_TYPE_MAESTRO { get; }

		// +(NSString *)CARD_TYPE_UNION_PAY;
		[Static]
		[Export ("CARD_TYPE_UNION_PAY")]
		string CARD_TYPE_UNION_PAY { get; }

		// +(NSString *)BRANDING_COINBASE;
		[Static]
		[Export ("BRANDING_COINBASE")]
		string BRANDING_COINBASE { get; }

		// +(NSString *)BRANDING_VENMO;
		[Static]
		[Export ("BRANDING_VENMO")]
		string BRANDING_VENMO { get; }

		// +(NSString *)BRANDING_APPLE_PAY;
		[Static]
		[Export ("BRANDING_APPLE_PAY")]
		string BRANDING_APPLE_PAY { get; }

		// +(NSString *)USE_DIFFERENT_PHONE_NUMBER_ACTION;
		[Static]
		[Export ("USE_DIFFERENT_PHONE_NUMBER_ACTION")]
		string USE_DIFFERENT_PHONE_NUMBER_ACTION { get; }

		// +(NSString *)CARD_NOT_ACCEPTED_ERROR_LABEL;
		[Static]
		[Export ("CARD_NOT_ACCEPTED_ERROR_LABEL")]
		string CARD_NOT_ACCEPTED_ERROR_LABEL { get; }

		// +(NSString *)DEV_SAMPLE_SMS_CODE_TITLE;
		[Static]
		[Export ("DEV_SAMPLE_SMS_CODE_TITLE")]
		string DEV_SAMPLE_SMS_CODE_TITLE { get; }

		// +(NSString *)DEV_SAMPLE_SMS_CODE_INFO;
		[Static]
		[Export ("DEV_SAMPLE_SMS_CODE_INFO")]
		string DEV_SAMPLE_SMS_CODE_INFO { get; }
	}

	// @interface BTUIKCardType : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUIKCardType
	{
		// +(instancetype)cardTypeForBrand:(NSString *)brand;
		[Static]
		[Export ("cardTypeForBrand:")]
		BTUIKCardType CardTypeForBrand (string brand);

		// +(instancetype)cardTypeForNumber:(NSString *)number;
		[Static]
		[Export ("cardTypeForNumber:")]
		BTUIKCardType CardTypeForNumber (string number);

		// +(NSArray *)possibleCardTypesForNumber:(NSString *)number;
		[Static]
		[Export ("possibleCardTypesForNumber:")]
		NSObject[] PossibleCardTypesForNumber (string number);

		// -(BOOL)validNumber:(NSString *)number;
		[Export ("validNumber:")]
		bool ValidNumber (string number);

		// -(BOOL)completeNumber:(NSString *)number;
		[Export ("completeNumber:")]
		bool CompleteNumber (string number);

		// -(BOOL)validAndNecessarilyCompleteNumber:(NSString *)number;
		[Export ("validAndNecessarilyCompleteNumber:")]
		bool ValidAndNecessarilyCompleteNumber (string number);

		// -(BOOL)validCvv:(NSString *)cvv;
		[Export ("validCvv:")]
		bool ValidCvv (string cvv);

		// -(NSAttributedString *)formatNumber:(NSString *)input;
		[Export ("formatNumber:")]
		NSAttributedString FormatNumber (string input);

		// -(NSAttributedString *)formatNumber:(NSString *)input kerning:(CGFloat)kerning;
		[Export ("formatNumber:kerning:")]
		NSAttributedString FormatNumber (string input, nfloat kerning);

        // +(NSUInteger)maxNumberLength;
        [Static]
        [Export("maxNumberLength")]
        nuint GetMaxNumberLength();

		// @property (readonly, copy, nonatomic) NSString * brand;
		[Export ("brand")]
		string Brand { get; }

		// @property (readonly, nonatomic, strong) NSArray * validNumberPrefixes;
		[Export ("validNumberPrefixes", ArgumentSemantic.Strong)]
		NSObject[] ValidNumberPrefixes { get; }

		// @property (readonly, nonatomic, strong) NSIndexSet * validNumberLengths;
		[Export ("validNumberLengths", ArgumentSemantic.Strong)]
		NSIndexSet ValidNumberLengths { get; }

		// @property (readonly, assign, nonatomic) NSUInteger validCvvLength;
		[Export ("validCvvLength")]
		nuint ValidCvvLength { get; }

		// @property (readonly, nonatomic, strong) NSArray * formatSpaces;
		[Export ("formatSpaces", ArgumentSemantic.Strong)]
		NSObject[] FormatSpaces { get; }

		// @property (readonly, assign, nonatomic) NSUInteger maxNumberLength;
		[Export ("maxNumberLength")]
		nuint MaxNumberLength { get; }

		// @property (readonly, assign, nonatomic) NSString * securityCodeName;
		[Export ("securityCodeName")]
		string SecurityCodeName { get; }
	}

	// @interface BTUIKCardNumberFormField : BTUIKFormField
	[BaseType (typeof(BTUIKFormField))]
	interface BTUIKCardNumberFormField
	{
		// @property (readonly, nonatomic, strong) BTUIKCardType * cardType;
		[Export ("cardType", ArgumentSemantic.Strong)]
		BTUIKCardType CardType { get; }

		// @property (nonatomic, strong) NSString * number;
		[Export ("number", ArgumentSemantic.Strong)]
		string Number { get; set; }

		// @property (nonatomic) BTUIKCardNumberFormFieldState state;
		[Export ("state", ArgumentSemantic.Assign)]
		BTUIKCardNumberFormFieldState State { get; set; }

		[Wrap ("WeakCardNumberDelegate")]
		BTUIKCardNumberFormFieldDelegate CardNumberDelegate { get; set; }

		// @property (nonatomic, weak) id<BTUIKCardNumberFormFieldDelegate> cardNumberDelegate;
		[NullAllowed, Export ("cardNumberDelegate", ArgumentSemantic.Weak)]
		NSObject WeakCardNumberDelegate { get; set; }

		// -(void)showCardHintAccessory;
		[Export ("showCardHintAccessory")]
		void ShowCardHintAccessory ();
	}

	// @protocol BTUIKCardNumberFormFieldDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface BTUIKCardNumberFormFieldDelegate
	{
		// @required -(void)validateButtonPressed:(BTUIKFormField *)formField;
		[Abstract]
		[Export ("validateButtonPressed:")]
		void ValidateButtonPressed (BTUIKFormField formField);
	}

	// @interface BTUIK (UIColor)
	[Category]
	[BaseType (typeof(UIColor))]
	interface UIColor_BTUIK
	{
		// +(instancetype)btuik_colorWithBytesR:(NSInteger)r G:(NSInteger)g B:(NSInteger)b A:(NSInteger)a;
		[Static]
		[Export ("btuik_colorWithBytesR:G:B:A:")]
		UIColor Btuik_colorWithBytesR (nint r, nint g, nint b, nint a);

		// +(instancetype)btuik_colorWithBytesR:(NSInteger)r G:(NSInteger)g B:(NSInteger)b;
		[Static]
		[Export ("btuik_colorWithBytesR:G:B:")]
		UIColor Btuik_colorWithBytesR (nint r, nint g, nint b);

		// +(instancetype)btuik_colorFromHex:(NSString *)hex alpha:(CGFloat)alpha;
		[Static]
		[Export ("btuik_colorFromHex:alpha:")]
		UIColor Btuik_colorFromHex (string hex, nfloat alpha);

		// -(instancetype)btuik_adjustedBrightness:(CGFloat)adjustment;
		[Export ("btuik_adjustedBrightness:")]
		UIColor Btuik_adjustedBrightness (nfloat adjustment);
	}

	// @interface BTUIKViewUtil : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUIKViewUtil
	{
		// +(BTUIKPaymentOptionType)paymentOptionTypeForPaymentInfoType:(NSString *)typeString;
		[Static]
		[Export ("paymentOptionTypeForPaymentInfoType:")]
		BTUIKPaymentOptionType PaymentOptionTypeForPaymentInfoType (string typeString);

		// +(BTUIKPaymentOptionType)paymentMethodTypeForCardType:(BTUIKCardType *)cardType;
		[Static]
		[Export ("paymentMethodTypeForCardType:")]
		BTUIKPaymentOptionType PaymentMethodTypeForCardType (BTUIKCardType cardType);

		// +(BOOL)isPaymentOptionTypeACreditCard:(BTUIKPaymentOptionType)paymentOptionType;
		[Static]
		[Export ("isPaymentOptionTypeACreditCard:")]
		bool IsPaymentOptionTypeACreditCard (BTUIKPaymentOptionType paymentOptionType);

		// +(NSString *)nameForPaymentMethodType:(BTUIKPaymentOptionType)paymentMethodType;
		[Static]
		[Export ("nameForPaymentMethodType:")]
		string NameForPaymentMethodType (BTUIKPaymentOptionType paymentMethodType);

		// +(void)vibrate;
		[Static]
		[Export ("vibrate")]
		void Vibrate ();

		// +(BTUIKVectorArtView *)vectorArtViewForPaymentInfoType:(NSString *)typeString;
		[Static]
		[Export ("vectorArtViewForPaymentInfoType:")]
		BTUIKVectorArtView VectorArtViewForPaymentInfoType (string typeString);

		// +(BTUIKVectorArtView *)vectorArtViewForPaymentOptionType:(BTUIKPaymentOptionType)type;
		[Static]
		[Export ("vectorArtViewForPaymentOptionType:")]
		BTUIKVectorArtView VectorArtViewForPaymentOptionType (BTUIKPaymentOptionType type);

		// +(BTUIKVectorArtView *)vectorArtViewForPaymentOptionType:(BTUIKPaymentOptionType)type size:(BTUIKVectorArtSize)size;
		[Static]
		[Export ("vectorArtViewForPaymentOptionType:size:")]
		BTUIKVectorArtView VectorArtViewForPaymentOptionType (BTUIKPaymentOptionType type, BTUIKVectorArtSize size);

		// +(BTUIKVectorArtView *)vectorArtViewForVisualAssetType:(BTUIKVisualAssetType)type;
		[Static]
		[Export ("vectorArtViewForVisualAssetType:")]
		BTUIKVectorArtView VectorArtViewForVisualAssetType (BTUIKVisualAssetType type);

		// +(BOOL)isLanguageLayoutDirectionRightToLeft;
		[Static]
		[Export ("isLanguageLayoutDirectionRightToLeft")]
		bool IsLanguageLayoutDirectionRightToLeft { get; }

		// +(NSTextAlignment)naturalTextAlignment;
		[Static]
		[Export ("naturalTextAlignment")]
		UITextAlignment NaturalTextAlignment { get; }

		// +(NSTextAlignment)naturalTextAlignmentInverse;
		[Static]
		[Export ("naturalTextAlignmentInverse")]
		UITextAlignment NaturalTextAlignmentInverse { get; }
	}

	// @interface BTUIKVectorArtView : UIView
	[BaseType (typeof(UIView))]
	interface BTUIKVectorArtView
	{
		// -(void)drawArt;
		[Export ("drawArt")]
		void DrawArt ();

		// @property (assign, nonatomic) CGSize artDimensions;
		[Export ("artDimensions", ArgumentSemantic.Assign)]
		CGSize ArtDimensions { get; set; }

		// -(UIImage *)imageOfSize:(CGSize)size;
		[Export ("imageOfSize:")]
		UIImage ImageOfSize (CGSize size);
	}

	// @interface BTUIKUtil : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUIKUtil
	{
		// +(BOOL)luhnValid:(NSString *)cardNumber;
		[Static]
		[Export ("luhnValid:")]
		bool LuhnValid (string cardNumber);

		// +(NSString *)stripNonDigits:(NSString *)input;
		[Static]
		[Export ("stripNonDigits:")]
		string StripNonDigits (string input);

		// +(NSString *)stripNonExpiry:(NSString *)input;
		[Static]
		[Export ("stripNonExpiry:")]
		string StripNonExpiry (string input);
	}

	// @interface BTUIKInputAccessoryToolbar : UIToolbar
	[BaseType (typeof(UIToolbar))]
	interface BTUIKInputAccessoryToolbar
	{
		// -(instancetype)initWithDoneButtonForInput:(id<UITextInput>)input;
		[Export ("initWithDoneButtonForInput:")]
		IntPtr Constructor (IUITextInput input);
	}

	// @interface BTUIKSecurityCodeFormField : BTUIKFormField
	[BaseType (typeof(BTUIKFormField))]
	interface BTUIKSecurityCodeFormField
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable securityCode;
		[NullAllowed, Export ("securityCode")]
		string SecurityCode { get; }
	}

	// @interface BTUIKPostalCodeFormField : BTUIKFormField
	[BaseType (typeof(BTUIKFormField))]
	interface BTUIKPostalCodeFormField
	{
		// @property (readonly, nonatomic, strong) NSString * postalCode;
		[Export ("postalCode", ArgumentSemantic.Strong)]
		string PostalCode { get; }
	}

	// @interface BTUIKMobileCountryCodeFormField : BTUIKFormField
	[BaseType (typeof(BTUIKFormField))]
	interface BTUIKMobileCountryCodeFormField
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable countryCode;
		[NullAllowed, Export ("countryCode")]
		string CountryCode { get; }
	}

	// @interface BTUIKMobileNumberFormField : BTUIKFormField
	[BaseType (typeof(BTUIKFormField))]
	interface BTUIKMobileNumberFormField
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable mobileNumber;
		[NullAllowed, Export ("mobileNumber")]
		string MobileNumber { get; }
	}

	// @interface BTUIKExpiryFormField : BTUIKFormField <BTUIKExpiryInputViewDelegate>
	[BaseType (typeof(BTUIKFormField))]
	interface BTUIKExpiryFormField : IBTUIKExpiryInputViewDelegate
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable expirationMonth;
		[NullAllowed, Export ("expirationMonth", ArgumentSemantic.Strong)]
		string ExpirationMonth { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable expirationYear;
		[NullAllowed, Export ("expirationYear", ArgumentSemantic.Strong)]
		string ExpirationYear { get; }

		// @property (copy, nonatomic) NSString * _Nullable expirationDate;
		[NullAllowed, Export ("expirationDate")]
		string ExpirationDate { get; set; }
	}

	// @interface BTUIKAppearance : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUIKAppearance
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		BTUIKAppearance SharedInstance ();

		// +(void)darkTheme;
		[Static]
		[Export ("darkTheme")]
		void DarkTheme ();

		// +(void)lightTheme;
		[Static]
		[Export ("lightTheme")]
		void LightTheme ();

		// @property (nonatomic, strong) UIColor * overlayColor;
		[Export ("overlayColor", ArgumentSemantic.Strong)]
		UIColor OverlayColor { get; set; }

		// @property (nonatomic, strong) UIColor * tintColor;
		[Export ("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; set; }

		// @property (nonatomic, strong) UIColor * barBackgroundColor;
		[Export ("barBackgroundColor", ArgumentSemantic.Strong)]
		UIColor BarBackgroundColor { get; set; }

		// @property (nonatomic, strong) NSString * fontFamily;
		[Export ("fontFamily", ArgumentSemantic.Strong)]
		string FontFamily { get; set; }

		// @property (nonatomic, strong) NSString * boldFontFamily;
		[Export ("boldFontFamily", ArgumentSemantic.Strong)]
		string BoldFontFamily { get; set; }

		// @property (nonatomic, strong) UIColor * formBackgroundColor;
		[Export ("formBackgroundColor", ArgumentSemantic.Strong)]
		UIColor FormBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * formFieldBackgroundColor;
		[Export ("formFieldBackgroundColor", ArgumentSemantic.Strong)]
		UIColor FormFieldBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * primaryTextColor;
		[Export ("primaryTextColor", ArgumentSemantic.Strong)]
		UIColor PrimaryTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * navigationBarTitleTextColor;
		[Export ("navigationBarTitleTextColor", ArgumentSemantic.Strong)]
		UIColor NavigationBarTitleTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * secondaryTextColor;
		[Export ("secondaryTextColor", ArgumentSemantic.Strong)]
		UIColor SecondaryTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * disabledColor;
		[Export ("disabledColor", ArgumentSemantic.Strong)]
		UIColor DisabledColor { get; set; }

		// @property (nonatomic, strong) UIColor * placeholderTextColor;
		[Export ("placeholderTextColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * lineColor;
		[Export ("lineColor", ArgumentSemantic.Strong)]
		UIColor LineColor { get; set; }

		// @property (nonatomic, strong) UIColor * errorForegroundColor;
		[Export ("errorForegroundColor", ArgumentSemantic.Strong)]
		UIColor ErrorForegroundColor { get; set; }

		// @property (nonatomic) UIBlurEffectStyle blurStyle;
		[Export ("blurStyle", ArgumentSemantic.Assign)]
		UIBlurEffectStyle BlurStyle { get; set; }

		// @property (nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
		[Export ("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
		UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }

		// @property (nonatomic) BOOL useBlurs;
		[Export ("useBlurs")]
		bool UseBlurs { get; set; }

		// @property (nonatomic) UIKeyboardType postalCodeFormFieldKeyboardType;
		[Export ("postalCodeFormFieldKeyboardType", ArgumentSemantic.Assign)]
		UIKeyboardType PostalCodeFormFieldKeyboardType { get; set; }

		// +(void)styleLabelPrimary:(UILabel *)label;
		[Static]
		[Export ("styleLabelPrimary:")]
		void StyleLabelPrimary (UILabel label);

		// +(void)styleLabelBoldPrimary:(UILabel *)label;
		[Static]
		[Export ("styleLabelBoldPrimary:")]
		void StyleLabelBoldPrimary (UILabel label);

		// +(void)styleSmallLabelBoldPrimary:(UILabel *)label;
		[Static]
		[Export ("styleSmallLabelBoldPrimary:")]
		void StyleSmallLabelBoldPrimary (UILabel label);

		// +(void)styleSmallLabelPrimary:(UILabel *)label;
		[Static]
		[Export ("styleSmallLabelPrimary:")]
		void StyleSmallLabelPrimary (UILabel label);

		// +(void)styleLabelSecondary:(UILabel *)label;
		[Static]
		[Export ("styleLabelSecondary:")]
		void StyleLabelSecondary (UILabel label);

		// +(void)styleLargeLabelSecondary:(UILabel *)label;
		[Static]
		[Export ("styleLargeLabelSecondary:")]
		void StyleLargeLabelSecondary (UILabel label);

		// +(void)styleSystemLabelSecondary:(UILabel *)label;
		[Static]
		[Export ("styleSystemLabelSecondary:")]
		void StyleSystemLabelSecondary (UILabel label);

		// +(UILabel *)styledNavigationTitleLabel;
		[Static]
		[Export ("styledNavigationTitleLabel")]
		UILabel StyledNavigationTitleLabel { get; }

		// +(float)horizontalFormContentPadding;
		[Static]
		[Export ("horizontalFormContentPadding")]
		float HorizontalFormContentPadding { get; }

		// +(float)formCellHeight;
		[Static]
		[Export ("formCellHeight")]
		float FormCellHeight { get; }

		// +(float)verticalFormSpace;
		[Static]
		[Export ("verticalFormSpace")]
		float VerticalFormSpace { get; }

		// +(float)verticalFormSpaceTight;
		[Static]
		[Export ("verticalFormSpaceTight")]
		float VerticalFormSpaceTight { get; }

		// +(float)verticalSectionSpace;
		[Static]
		[Export ("verticalSectionSpace")]
		float VerticalSectionSpace { get; }

		// +(float)smallIconWidth;
		[Static]
		[Export ("smallIconWidth")]
		float SmallIconWidth { get; }

		// +(float)smallIconHeight;
		[Static]
		[Export ("smallIconHeight")]
		float SmallIconHeight { get; }

		// +(float)largeIconWidth;
		[Static]
		[Export ("largeIconWidth")]
		float LargeIconWidth { get; }

		// +(float)largeIconHeight;
		[Static]
		[Export ("largeIconHeight")]
		float LargeIconHeight { get; }

		// +(NSDictionary *)metrics;
		[Static]
		[Export ("metrics")]
		NSDictionary Metrics { get; }
	}

	// @interface BTUIKCardListLabel : UILabel
	[BaseType (typeof(UILabel))]
	interface BTUIKCardListLabel
	{
		// @property (copy, nonatomic) NSArray * availablePaymentOptions;
		[Export ("availablePaymentOptions", ArgumentSemantic.Copy)]
		NSObject[] AvailablePaymentOptions { get; set; }

		// -(void)emphasizePaymentOption:(BTUIKPaymentOptionType)paymentOption;
		[Export ("emphasizePaymentOption:")]
		void EmphasizePaymentOption (BTUIKPaymentOptionType paymentOption);
	}

	// @interface BTUIKPaymentOptionCardView : UIView
	[BaseType (typeof(UIView))]
	interface BTUIKPaymentOptionCardView
	{
		// @property (nonatomic) BTUIKPaymentOptionType paymentOptionType;
		[Export ("paymentOptionType", ArgumentSemantic.Assign)]
		BTUIKPaymentOptionType PaymentOptionType { get; set; }

		// @property (nonatomic) float cornerRadius;
		[Export ("cornerRadius")]
		float CornerRadius { get; set; }

		// @property (nonatomic) float innerPadding;
		[Export ("innerPadding")]
		float InnerPadding { get; set; }

		// @property (nonatomic) float borderWidth;
		[Export ("borderWidth")]
		float BorderWidth { get; set; }

		// @property (nonatomic, strong) UIColor * borderColor;
		[Export ("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic) BTUIKVectorArtSize vectorArtSize;
		[Export ("vectorArtSize", ArgumentSemantic.Assign)]
		BTUIKVectorArtSize VectorArtSize { get; set; }

		// -(void)setHighlighted:(BOOL)highlighted;
		[Export ("setHighlighted:")]
		void SetHighlighted (bool highlighted);

		// -(CGSize)getArtDimensions;
		[Export ("getArtDimensions")]
		CGSize ArtDimensions { get; }
	}

	// @interface BTUIKCardExpirationValidator : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUIKCardExpirationValidator
	{
		// +(BOOL)month:(NSUInteger)month year:(NSUInteger)year validForDate:(NSDate *)date;
		[Static]
		[Export ("month:year:validForDate:")]
		bool Month (nuint month, nuint year, NSDate date);
	}

	// @interface BTUIKCardExpiryFormat : NSObject
	[BaseType (typeof(NSObject))]
	interface BTUIKCardExpiryFormat
	{
		// @property (copy, nonatomic) NSString * value;
		[Export ("value")]
		string Value { get; set; }

		// @property (assign, nonatomic) NSUInteger cursorLocation;
		[Export ("cursorLocation")]
		nuint CursorLocation { get; set; }

		// @property (assign, nonatomic) BOOL backspace;
		[Export ("backspace")]
		bool Backspace { get; set; }

		// -(void)formattedValue:(NSString **)value cursorLocation:(NSUInteger *)cursorLocation;
		//TODO NSUInteger *
		[Export ("formattedValue:cursorLocation:")]
		unsafe void FormattedValue (out string value, ref nuint cursorLocation);
	}
}