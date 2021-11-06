using lab3_tp6_json.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace lab3_tp6_json {
    class Program {
        private static string _path = Directory.GetCurrentDirectory();
        static void Main(string[] args) {
            Gestor gestor = new Gestor();
            List<Author> authors = gestor.getAllEscritores();
            serializeJSON(authors);
            deserializeJSONFromUrl();
        }

        static void serializeJSON(List<Author> items) {
            string json = JsonConvert.SerializeObject(items.ToArray(), Formatting.Indented);
            File.WriteAllText(_path+"/escritores.json", json);
            Console.WriteLine("Json creado en " + Directory.GetCurrentDirectory());
        }

        static void deserializeJSONFromUrl() {
            var url = "https://randomuser.me/api/?results=10";

            WebClient wc = new WebClient();
            string usuariosFuente = wc.DownloadString(url);

            var apiResponse = JsonConvert.DeserializeObject<Api>(usuariosFuente);
            var users = apiResponse.results;

            foreach (User user in users) {
                Console.WriteLine("First name: " + user.Name.First);
                Console.WriteLine("Last name: " + user.Name.Last);
                Console.WriteLine("Username: " + user.Login.Username);
                Console.WriteLine("Password: " + user.Login.Password);
                Console.WriteLine("-----------------------------\n\n");
            }
        }
    }
}
