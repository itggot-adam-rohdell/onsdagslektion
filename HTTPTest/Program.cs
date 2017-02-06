using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

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
                result = await client.GetStringAsync("http://ur.se");
            }
            
        }
    }
}
