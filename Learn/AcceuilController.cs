using Foundation;
using System;
using System.IO;
using UIKit;

namespace Learn
{
    public partial class AcceuilController : UIViewController
    {
        public AcceuilController (IntPtr handle) : base (handle)
        {
        }

        public void alertView(string Title, string Message)
        {
            UIAlertView alert = new UIAlertView
            {
                Title = Title,
                Message = Message
            };
            alert.AddButton("Ok");
            alert.Show();
        }

        public void ShowLogin()
        {
            UIStoryboard storyboard = this.Storyboard;
            ViewController viewController = (ViewController)
            storyboard.InstantiateViewController("ViewController");
            this.PresentViewController(viewController, true, null);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
           
        }

        partial void UIButton22653_TouchUpInside(UIButton sender)
        {
        }
    }
}