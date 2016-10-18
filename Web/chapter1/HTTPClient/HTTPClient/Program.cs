using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace HTTPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestGetFromWebServer().Wait();
            WebClient client = new WebClient();
            client.DownloadFile("https://ss0.bdstatic.com/5aV1bjqh_Q23odCf/static/superman/img/logo/bd_logo1_31bdc765.png", @"D:\01.png");
            Console.ReadKey(true);
        }
        static HttpClient getHttpClient(string address)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(address);
            
            return client;
        }
        static async Task TestGetFromWebServer()
        {
            string address = "https://ss0.bdstatic.com/";
            var client = getHttpClient(address);
            string result = await client.GetStringAsync("/5aV1bjqh_Q23odCf/static/superman/img/logo/bd_logo1_31bdc765.png");
            Console.WriteLine(result);
        }
    }
}
