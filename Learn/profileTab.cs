using Foundation;
using System;
using UIKit;

namespace Learn
{
    public partial class profileTab : UIViewController
    {
        public profileTab(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            scrollView.ContentSize = new CoreGraphics.CGSize(View.Frame.Width - 10, View.Frame.Height + 80);
        }
    }
}