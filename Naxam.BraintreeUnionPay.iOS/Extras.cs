using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace BraintreeUnionPay
{
    [Preserve(AllMembers = true)]
    public static class BraintreeUnionPayLinker
    {
        /// <summary>
        /// PayPalUtils and PayPalDataCollector are in use internally by BrainTreePayPal.
        /// BUT from public APIs, Xamarin.iOS couldn't know that.
        /// This code is to tell Xamarin.iOS that we need those both frameworks.
        /// </summary>
        public static void Init() {
			new BraintreeCard.BTCard();
        }
    }
}
