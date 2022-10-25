using System;

namespace DropInQs;
using BraintreeDropIn;

public class ViewController : UIViewController
{
	public override void ViewDidLoad()
	{
		View!.AddSubview(new UILabel(View!.Frame)
		{
			BackgroundColor = UIColor.SystemBackground,
			TextAlignment = UITextAlignment.Center,
			Text = "Hello, iOS!",
			AutoresizingMask = UIViewAutoresizing.All,
		});
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

