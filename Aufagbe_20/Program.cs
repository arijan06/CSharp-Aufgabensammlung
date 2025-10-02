using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

//namespace Aufagbe_20
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
//            WebResponse response = request.GetResponse();
//            Stream responseStream = response.GetResponseStream();
//            string jsonData = new StreamReader(responseStream).ReadToEnd();
//            JArray array = JArray.Parse(jsonData);

//            Console.WriteLine("Wilst du einen Witz hören:");
//            string eingabe = Console.ReadLine();
//            if (eingabe.ToLower() == "ja")
//            {
//                foreach (var item in array)
//                {
//                    string setup = item["text"].ToString();
//                    Console.WriteLine(setup);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Schade, vielleicht ein anderes Mal!");
//            }
//            response.Close();
//            Console.WriteLine("Drücke eine beliebige Taste zum Beenden...");
//            Console.ReadKey();
//        }
//    }
//}
using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Aufgabe_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Willst du einen Witz hören? (j/n): ");
                string antwort = Console.ReadLine().Trim().ToLower();

                if (antwort == "n" || antwort == "nein")
                {
                    Console.WriteLine("Okay, vielleicht ein anderes Mal!");
                    break;
                }

                if (antwort == "j" || antwort == "ja")
                {
                    try
                    {
                        WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                        WebResponse response = request.GetResponse();
                        Stream responseStream = response.GetResponseStream();
                        string jsonData = new StreamReader(responseStream).ReadToEnd();

                        JArray array = JArray.Parse(jsonData);

                        foreach (var item in array)
                        {
                            string text = item["text"]?.ToString();
                            Console.WriteLine();
                            Console.WriteLine(text);
                            Console.WriteLine();
                        }

                        response.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Fehler beim Laden des Witzes: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Bitte nur 'j' oder 'n' eingeben!");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Drücke eine beliebige Taste zum Schließen...");
            Console.ReadKey();
        }
    }
}