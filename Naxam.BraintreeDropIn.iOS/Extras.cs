﻿using System;
using Foundation;

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
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace BraintreeDropIn
{
    [Preserve(AllMembers = true)]
    public partial class BTDropInController
    {
        static BTDropInController()
        {
            BraintreeApplePay.BraintreeApplePayLinker.Init();
            BraintreeCard.BraintreeCardLinker.Init();
            BraintreeUnionPay.BraintreeUnionPayLinker.Init();

            new BraintreePaymentFlow.BTIdealResult();
            new BraintreeCard.BTCard();
        }
    }
}
