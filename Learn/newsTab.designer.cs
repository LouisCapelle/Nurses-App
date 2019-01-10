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
    [Register ("newsTab")]
    partial class newsTab
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton disconnect { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel hiLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scrollNews { get; set; }

        [Action ("Disconnect_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Disconnect_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (disconnect != null) {
                disconnect.Dispose ();
                disconnect = null;
            }

            if (hiLabel != null) {
                hiLabel.Dispose ();
                hiLabel = null;
            }

            if (scrollNews != null) {
                scrollNews.Dispose ();
                scrollNews = null;
            }
        }
    }
}