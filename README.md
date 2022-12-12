# BrainTree for Xamarin.iOS

A Xamarin.Android binding library for [Braintree DropIn iOS](https://cocoapods.org/pods/BraintreeDropIn) library.

> The library used to be under the name of `Naxam.BraintreeDropIn.iOS`. Naxam is no longer in business for years hence I remove the trademark from the name and hope it more neutral for the community to contribute.

## Installation

```
Install-Package BraintreeDropIn.iOS
```

## Usage

This project is to provide C# libraries for corresponding libraries in Swift/Objective, however, the APIs are very similar.

Here are snippets which could be found in [ViewController](./samples/DropInQs/ViewController.cs) in the demo project.
### Action
```c#
private void ShowDropIn(string clientTokenOrTokenizationKey)
{
    var request = new BTDropInRequest();

    var dropIn = new BTDropInController(authorization: clientTokenOrTokenizationKey, request: request, handler: HandleDropInResult);

    PresentViewController(dropIn!, animated: true, completionHandler: null);
}
```

Plz follow official guide from Braintree [here](https://developer.paypal.com/braintree/docs/start/hello-client/ios/v5) for further details.

## Run on your machine

- Generate project files
```
sh build.sh --target=binderate
```
- Pack nuget packages
```
sh build.sh --target=nuget --base-path=$PWD
```

## Maintainer
This project is maintained by [tuyen-vuduc](https://github.com/tuyen-vuduc) in his spare time and/or when requested.<br>

If you find this project is useful, please give it a star, become a sponsor of the project and/or buy him a coffee.

[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/tuyen.vuduc)

## License

Braintree native libraries and its dependencies are licensed under their original owners' licenses. Please check out their main website for further information.

Braintree binding libraries for iOS is released under the MIT license. See [LICENSE](./LICENSE) for details.