using Foundation;
using RestSharp;
using SimpleJson;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System;
using UIKit;

namespace Learn
{
    public partial class registerController : UIViewController
    {
        public registerController (IntPtr handle) : base (handle)
        {

        }

        public void ShowMe()
        {
            UIStoryboard storyboard = this.Storyboard;
            ViewController viewController = (ViewController)
            storyboard.InstantiateViewController("ViewController");
            this.PresentViewController(viewController, true, null);
        }

        public void postData(bool switchOn, string emailText, string passwordText, string firstname, string lastname, string age)
        {
            if (switchOn)
            {
                try
                {
                    var client = new RestClient("http://127.0.0.1:8000/users/");
                    var request = new RestRequest(Method.POST);
                    string myJson = "{\n\t\"email\": \"" + emailText + "\",\n\t\"password\": \"" + passwordText + "\",\n\t\"firstname\": \"" + lastname + "\",\n\t\"lastname\": \"" + lastname + "\",\n\t\"age\": " + age + ",\n\t\"banned\": 0,\n\t\"role\": \"User\"\n}";
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("undefined", myJson, ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                    alertView("Success", "You have been registered, you can now connect");
                    ShowMe();
                }
                catch
                {
                    alertView("Error", "Error");
                }
            }
            else
            {
                alertView("Error", "You doesn't accepted the conditions of uses");
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var g = new UITapGestureRecognizer(() => View.EndEditing(true));
            g.CancelsTouchesInView = false; //for iOS5

            View.AddGestureRecognizer(g);

            accepted.SetState(false, animated:false);
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

        partial void UIButton14918_TouchUpInside(UIButton sender)
        {
            ShowMe();
        }

        partial void UIButton16004_TouchUpInside(UIButton sender)
        {
            bool accepting;
            if (accepted.On)
            {
                accepting = true;
            }
            else
            {
                accepting = false;
            }

            postData(accepting,emailTxt.Text,pwdText.Text,firstTxt.Text,lastTxt.Text,ageTxt.Text);
        }
    }
}