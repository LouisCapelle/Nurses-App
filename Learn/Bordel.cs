//c'est censé etre le truc qui permet de reconnecter un utilisateur au démarrage

/*try
                {
                    var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    var filename = Path.Combine(documents, "informations.json");
                    var text = File.ReadAllText(filename);

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

                    alertView("content of get:", content);

                    Email.value = (string)jObject2["email"];
                    Password.value = (string)jObject2["password"];
                    Firstname.value = (string)jObject2["firstname"];
                    Lastname.value = (string)jObject2["lastname"];
                    Age.value = (int)jObject2["age"];
                    Banned.value = (int)jObject2["banned"];
                    Role.value = (string)jObject2["role"];

                    if (groscaca.password == Password.value)
                    {

                    }
                    else
                    {
                        alertView("PUTAIN", "CA N'A AUCUN PUTAIN DE SENS");
                    }
                }
                catch(Exception ex)
                {
                    alertView("Bienvenue", "Bienvenue, c'est votre première connexion");
                    alertView("", ex.ToString());
                }*/