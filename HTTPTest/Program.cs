using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using HtmlAgilityPack;
using System.Net;

namespace HTTPTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDataAsync();
            Console.ReadKey();
        }

        static async void GetDataAsync()
        {
            string result;
            using (var client = new HttpClient())
            {
                result = await client.GetStringAsync("http://www.klart.se/");
            }
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(result);
            var weather = doc.GetElementbyId("mini-top-list").InnerText;
            


            Console.WriteLine(weather);
        }

        static async void GetDataAsync(string city)
        {

        }
    }
}
