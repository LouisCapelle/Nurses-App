using Foundation;
using System;
using UIKit;
using CoreGraphics;
using System.IO;

namespace Learn
{
    public partial class newsTab : UIViewController
    {

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Firstname.value = "Louis";
            hiLabel.Text = "Hi, " + Firstname.value;
            scrollNews.ContentSize = new CGSize(View.Frame.Width - 10, View.Frame.Height + 1000);


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

        partial void Disconnect_TouchUpInside(UIButton sender)
        {
            try
            {
                var json = "";
                var line = string.Format("{0}", json);
                var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var filename = Path.Combine(documents, "informations.json");
                File.WriteAllText(filename, line);
                alertView("Success", "You have been disconnected");
                ShowLogin();
            }
            catch (Exception ex)
            {
                alertView("Error", ex.ToString());
            }
        }
         
        public newsTab (IntPtr handle) : base (handle)
        {
        }




    }
}