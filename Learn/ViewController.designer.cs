// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Learn
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton getButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textUser { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPwd { get; set; }

        [Action ("UIButton13100_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton13100_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton24532_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton24532_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton589_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton589_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (getButton != null) {
                getButton.Dispose ();
                getButton = null;
            }

            if (textUser != null) {
                textUser.Dispose ();
                textUser = null;
            }

            if (txtPwd != null) {
                txtPwd.Dispose ();
                txtPwd = null;
            }
        }
    }
}