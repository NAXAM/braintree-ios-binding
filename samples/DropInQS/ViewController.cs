using Foundation;
using System;
using UIKit;
using BraintreeDropIn;

namespace DropInQS2
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
			var x = KountDataCollector.KDataCollector.SharedCollector;
			var xx = new BraintreePayPal.BTPayPalVaultRequest();
			var xxx = new BraintreeThreeDSecure.BTThreeDSecureRequest();

			var z = new BraintreeDataCollector.BTDataCollector();
			var zz = new BraintreeApplePay.BTApplePayCardNonce();
			var zzz = new BraintreeCard.BTCardNonce();
			var zzzz = new BraintreeCore.BTPaymentMethodNonce();
			var zzzzz = new BraintreePayPal.BTPayPalAccountNonce();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			btnShowDropIn.TouchUpInside += BtnShowDropIn_TouchUpInside;
		}

		private void BtnShowDropIn_TouchUpInside(object sender, EventArgs e)
		{
			ShowDropIn("sandbox_tmxhyf7d_dcpspy2brwdjr3qn");
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		private void ShowDropIn(string clientTokenOrTokenizationKey)
		{
			var request = new BTDropInRequest();

			var dropIn = new BTDropInController(authorization: clientTokenOrTokenizationKey, request: request, handler: HandleDropInResult);

			PresentViewController(dropIn!, animated: true, completionHandler: null);
		}

		private void HandleDropInResult(BTDropInController controller, BTDropInResult result, NSError error)
		{
			if (error != null)
			{
				System.Diagnostics.Debug.WriteLine(error);

			}
			else if (result?.Canceled == true)
			{
				System.Diagnostics.Debug.WriteLine("Cancel");

			}
			else if (result != null)
			{
				// Use the BTDropInResult properties to update your UI
				// result.paymentMethodType
				// result.paymentMethod
				// result.paymentIcon
				// result.paymentDescription
			}

			controller.DismissViewController(animated: true, completionHandler: null);
		}
	}
}

