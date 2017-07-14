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

namespace BraintreeDataCollector
{
    [Preserve(AllMembers = true)]
    public static class BraintreeDataCollectorLinker
    {
        public static void Init()
        {
            new BTDataCollector();
        }
    }

    partial class BTDataCollector
    {
        static BTDataCollector()
        {
            global::ApiDefinition.Messaging.void_objc_msgSend(class_ptr, Selector.GetHandle("load"));
        }
    }
}

namespace ApiDefinition {
    partial class Messaging {
		[DllImport(LIBOBJC_DYLIB, EntryPoint = "objc_msgSend")]
		public extern static void void_objc_msgSend(IntPtr receiver, IntPtr selector);
    }
}