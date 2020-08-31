using System;
using BraintreeCore;
using BraintreeDropIn;
using CoreGraphics;
using UIKit;

namespace DropinQs
{
    public partial class ViewController : UIViewController
    {
        public UIButton Button { get; private set; }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Button = new UIButton(new CGRect(0, 64, 320, 44)) { };
            Button.SetTitle("Do BrainTree", UIControlState.Normal);
            Button.SetTitleColor(UIColor.Purple, UIControlState.Normal);
            View.AddSubview(Button);

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += delegate
            {
                //throw new NotImplementedException("Plz enter your API key.");
                ShowBraintreeDropIn("sandbox_9dbg82cq_dcpspy2brwdjr3qn");
            };

            //BraintreeDemoMerchantAPI
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.     
        }

        private void ShowBraintreeDropIn(string clientTokenOrTokenizationKey)
        {
            var request = new BTDropInRequest
            {
                Amount = "10.0",
                ThreeDSecureVerification = true
            };
            var dropIn = new BTDropInController(clientTokenOrTokenizationKey, request, HandleBTDropInControllerHandler);
            PresentViewController(dropIn, false, null);
        }

        void HandleBTDropInControllerHandler(BTDropInController controller, BTDropInResult result, Foundation.NSError error)
		{
            if (error != null)
            {
                System.Diagnostics.Debug.WriteLine("ERROR");
            }
            else if (result != null && result.Cancelled == true)
            {
                System.Diagnostics.Debug.WriteLine("CANCELLED");
            }
            else
            {
                Button.SetTitle(result.PaymentDescription, UIControlState.Normal);

                var selectedPaymentOptionType = result.PaymentOptionType;
                var selectedPaymentMethod = result.PaymentMethod;
                var selectedPaymentMethodIcon = result.PaymentIcon;
                var selectedPaymentMethodDescription = result.PaymentDescription;
            }
            controller.DismissViewController(true, null);
        }

    }
}
