﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Lab05
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton callButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField phoneNumberText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton translateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton verifyButton { get; set; }

        [Action ("VerifyButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void VerifyButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (callButton != null) {
                callButton.Dispose ();
                callButton = null;
            }

            if (phoneNumberText != null) {
                phoneNumberText.Dispose ();
                phoneNumberText = null;
            }

            if (translateButton != null) {
                translateButton.Dispose ();
                translateButton = null;
            }

            if (verifyButton != null) {
                verifyButton.Dispose ();
                verifyButton = null;
            }
        }
    }
}