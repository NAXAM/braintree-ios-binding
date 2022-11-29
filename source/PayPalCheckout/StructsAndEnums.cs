using ObjCRuntime;

namespace PayPalCheckout
{
	[Native]
	public enum PPCApprovalOrderIntent : long
	{
		None = 0,
		Capture = 1,
		Authorize = 2,
		Order = 3
	}

	[Native]
	public enum PPCChannel : long
	{
		Native = 0,
		MobileWeb = 1,
		DesktopWeb = 2
	}

	[Native]
	public enum PPCCurrencyCode : long
	{
		Aud = 0,
		Brl = 1,
		Cad = 2,
		Cny = 3,
		Czk = 4,
		Dkk = 5,
		Eur = 6,
		Hkd = 7,
		Huf = 8,
		Inr = 9,
		Ils = 10,
		Jpy = 11,
		Myr = 12,
		Mxn = 13,
		Twd = 14,
		Nzd = 15,
		Nok = 16,
		Php = 17,
		Pln = 18,
		Gbp = 19,
		Rub = 20,
		Sgd = 21,
		Sek = 22,
		Chf = 23,
		Thb = 24,
		Usd = 25
	}

	[Native]
	public enum PPCEnvironment : long
	{
		Live = 0,
		Sandbox = 1,
		Stage = 2
	}

	[Native]
	public enum PPCOrderApplicationContextShippingPreference : long
	{
		None = 0,
		GetFromFile = 1,
		NoShipping = 2,
		SetProvidedAddress = 3
	}

	[Native]
	public enum PPCOrderApplicationContextUserAction : long
	{
		None = 0,
		Continue = 1,
		PayNow = 2
	}

	[Native]
	public enum PPCOrderApplicationContextPayerSelected : long
	{
		None = 0,
		Paypal = 1,
		PaypalCredit = 2,
		PaypalPayLater = 3,
		FlexPay = 4
	}

	[Native]
	public enum PPCOrderApplicationContextPayeePreferred : long
	{
		None = 0,
		Unrestricted = 1,
		ImmediatePaymentRequired = 2
	}

	[Native]
	public enum PPCOrderApplicationContextStandardEntryClassCode : long
	{
		None = 0,
		Tel = 1,
		Web = 2,
		Ccd = 3,
		Ppd = 4
	}

	[Native]
	public enum PPCOrderApplicationContextPaymentInitiator : long
	{
		Customer = 0,
		Merchant = 1
	}

	[Native]
	public enum PPCOrderApplicationContextPaymentType : long
	{
		OneTime = 0,
		Recurring = 1,
		Unscheduled = 2
	}

	[Native]
	public enum PPCOrderApplicationContextUsage : long
	{
		None = 0,
		First = 1,
		Subsequent = 2,
		Derived = 3
	}

	[Native]
	public enum PPCOrderApplicationContextNetwork : long
	{
		Visa = 0,
		Mastercard = 1,
		Discover = 2,
		Amex = 3,
		Solo = 4,
		Jcb = 5,
		Star = 6,
		Delta = 7,
		SwitchCard = 8,
		Maestro = 9,
		CbNationale = 10,
		Configoga = 11,
		Confidis = 12,
		Electron = 13,
		Cetelem = 14,
		ChinaUnionPay = 15
	}

	[Native]
	public enum PPCOrderIntent : long
	{
		Capture = 0,
		Authorize = 1
	}

	[Native]
	public enum PPCOrderPayerPhoneType : long
	{
		None = 0,
		Fax = 1,
		Home = 2,
		Mobile = 3,
		Other = 4,
		Pager = 5
	}

	[Native]
	public enum PPCOrderPayerTaxIdType : long
	{
		Individual = 0,
		Buisness = 1
	}

	[Native]
	public enum PPCPayPalButtonColor : long
	{
		Gold = 0,
		White = 1,
		Black = 2,
		Silver = 3,
		Blue = 4
	}

	[Native]
	public enum PPCPayPalButtonLabel : long
	{
		None = -1,
		Checkout = 0,
		BuyNow = 1,
		PayWith = 2
	}

	[Native]
	public enum PPCPayPalCreditButtonColor : long
	{
		White = 1,
		Black = 2,
		DarkBlue = 5
	}

	[Native]
	public enum PPCPayPalPayLaterButtonColor : long
	{
		Gold = 0,
		White = 1,
		Black = 2,
		Silver = 3,
		Blue = 4
	}

	[Native]
	public enum PPCPaymentButtonColor : long
	{
		Gold = 0,
		White = 1,
		Black = 2,
		Silver = 3,
		Blue = 4,
		DarkBlue = 5
	}

	[Native]
	public enum PPCPaymentButtonEdges : long
	{
		HardEdges = 0,
		SoftEdges = 1,
		Rounded = 2
	}

	[Native]
	public enum PPCPaymentButtonEligibilityStatus : long
	{
		Loading = 0,
		Eligible = 1,
		Ineligible = 2,
		Error = 3
	}

	[Native]
	public enum PPCPaymentButtonFundingSource : long
	{
		PayPal = 0,
		PayLater = 1,
		Credit = 2
	}

	[Native]
	public enum PPCPaymentButtonLabel : long
	{
		Checkout = 0,
		BuyNow = 1,
		PayWith = 2,
		PayLater = 3
	}

	[Native]
	public enum PPCPaymentButtonSize : long
	{
		Mini = 0,
		Collapsed = 1,
		Expanded = 2,
		Full = 3
	}

	[Native]
	public enum PPCOrderProcessingInstruction : long
	{
		None = 0,
		OrderSavedExplicitly = 1,
		OrderSavedOnBuyerApproval = 2,
		OrderCompleteOnPaymentApproval = 3,
		NoInstruction = 4
	}

	[Native]
	public enum PPCPurchaseUnitDisbursementMode : long
	{
		None = 0,
		Instant = 1,
		Delayed = 2
	}

	[Native]
	public enum PPCPurchaseUnitCategory : long
	{
		None = 0,
		DigitalGoods = 1,
		PhysicalGoods = 2
	}

	[Native]
	public enum PPCShippingChangeState : long
	{
		Processing = 0,
		Approved = 1,
		Error = 2,
		Undetermined = 3
	}

	[Native]
	public enum PPCShippingChangeType : long
	{
		Address = 0,
		Method = 1
	}

	[Native]
	public enum PPCShippingType : long
	{
		Shipping = 0,
		Pickup = 1,
		None = 2
	}

	[Native]
	public enum PPCUserAction : long
	{
		Default = 0,
		Continue = 1,
		PayNow = 2
	}
}
