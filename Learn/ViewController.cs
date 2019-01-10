using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;
using System.Net.Http;
using UIKit;
using System.IO;
using Foundation;
using CoreGraphics;

namespace Learn
{
    public partial class ViewController : UIViewController
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
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

        public void clearText()
        {
            textUser.Text = "";
            txtPwd.Text = "";
        }

        public void getData(string userTextbox, string passwordTextbox){

            if (userTextbox == "")
            {
                alertView("Error", "You didn't entered an adress mail.");
            }
            else
            {
                var client = new RestClient("http://127.0.0.1:8000/users");
                var request = new RestRequest("/" + userTextbox, Method.GET);
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                var content = response.Content;
                if (content == "")
                {
                    alertView("Error", "You entered a wrong adress mail");
                    clearText();

                }
                else
                {
                    try
                    {
                        JObject jObject = JObject.Parse(content);

                        Email.value = (string)jObject["email"];
                        Password.value = (string)jObject["password"];
                        Firstname.value = (string)jObject["firstname"];
                        Lastname.value = (string)jObject["lastname"];
                        Age.value = (int)jObject["age"];
                        Banned.value = (int)jObject["banned"];
                        Role.value = (string)jObject["role"];

                        if (passwordTextbox == Password.value)
                        {
                            userSaving caca = new userSaving
                            {
                                email = Email.value,
                                password = Password.value

                            };
                            string json = JsonConvert.SerializeObject(caca);
                            saveCredentials(json);
                            alertView("Success", "Good credentials");
                            ShowAcceuil();
                        }
                        else
                        {
                            alertView("Error", "You entered a wrong password");
                        }

                    }
                    catch (Exception ex)
                    {
                        var error = ex.ToString();
                        alertView("Error", error);
                        Console.WriteLine(content);
                        alertView("Content", content);
                        alertView("Response", response.ToString());
                    }
                }
            }

        }

        public void retrieveData()
        {
            try
            {
                var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var filename = Path.Combine(documents, "informations.json");
                var text = File.ReadAllText(filename);

                savedTxt.value = text;

                JObject jObject = JObject.Parse(text);

                userSaving groscaca = new userSaving
                {
                    email = (string)jObject["email"],
                    password = (string)jObject["password"]
                };

                var client = new RestClient("http://127.0.0.1:8000/users");
                var request = new RestRequest("/" + groscaca.email, Method.GET);
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                var content = response.Content;

                JObject jObject2 = JObject.Parse(content);

                Email.value = (string)jObject2["email"];
                Password.value = (string)jObject2["password"];
                Firstname.value = (string)jObject2["firstname"];
                Lastname.value = (string)jObject2["lastname"];
                Age.value = (int)jObject2["age"];
                Banned.value = (int)jObject2["banned"];
                Role.value = (string)jObject2["role"];

                if (groscaca.password == Password.value)
                {
                    ShowAcceuil();
                }
                else
                {
                    alertView("PUTAIN", "CA N'A AUCUN PUTAIN DE SENS");
                }
            }
            catch (Exception ex)
            {
                if (savedTxt.value == "")
                {
                    Console.WriteLine("First connexion");
                }
                else
                {
                    alertView("", ex.ToString());
                }
            }
        }

        public void ShowAcceuil()
        {
            UIStoryboard storyboard = this.Storyboard;
            tabController viewController = (tabController)
            storyboard.InstantiateViewController("tabController");
            this.PresentViewController(viewController, true, null);
        }

        partial void UIButton24532_TouchUpInside(UIButton sender)
        {
            ShowAcceuil();
        }

        public class userSaving
        {
            public string email;
            public string password;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var g = new UITapGestureRecognizer(() => View.EndEditing(true));
            g.CancelsTouchesInView = false; //for iOS5
            View.AddGestureRecognizer(g);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            var line = string.Format("{0}", "");
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename = Path.Combine(documents, "informations.json");
            File.WriteAllText(filename, line);
            retrieveData();
        }

        public void ShowRegister()
        {
            UIStoryboard storyboard = this.Storyboard;
            registerController viewController = (registerController)
            storyboard.InstantiateViewController("registerController");
            this.PresentViewController(viewController, true, null);
        }

        public void saveCredentials(string json)
        {
            var line = string.Format("{0}", json);
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename = Path.Combine(documents, "informations.json");
            File.WriteAllText(filename, line);

        }

        partial void UIButton589_TouchUpInside(UIButton sender)
        {
            getData(textUser.Text, txtPwd.Text);
        }

        partial void UIButton13100_TouchUpInside(UIButton sender)
        {
            ShowRegister();
        }
    }
}

