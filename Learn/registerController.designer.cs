// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Learn
{
    [Register ("registerController")]
    partial class registerController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch accepted { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ageTxt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField emailTxt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField firstTxt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField lastTxt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField pwdText { get; set; }

        [Action ("UIButton14918_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton14918_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton16004_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton16004_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (accepted != null) {
                accepted.Dispose ();
                accepted = null;
            }

            if (ageTxt != null) {
                ageTxt.Dispose ();
                ageTxt = null;
            }

            if (emailTxt != null) {
                emailTxt.Dispose ();
                emailTxt = null;
            }

            if (firstTxt != null) {
                firstTxt.Dispose ();
                firstTxt = null;
            }

            if (lastTxt != null) {
                lastTxt.Dispose ();
                lastTxt = null;
            }

            if (pwdText != null) {
                pwdText.Dispose ();
                pwdText = null;
            }
        }
    }
}