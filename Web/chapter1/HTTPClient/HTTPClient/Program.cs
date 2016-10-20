using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HTTPClient
{
    class Program
    {
        public static string address_web { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要分析的地址：");
            address_web = Console.ReadLine();
            TestGetFromWebServer().Wait();

            Console.ReadKey(true);
        }
        static HttpClient getHttpClient(string address)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(address);
            
            return client;
        }

        static string Parsing(string input)
        {
            int input_length = input.Length;
            string output = input.Substring(10, input_length - 12);
            if (output.StartsWith("//"))
            {
                if (address_web.StartsWith("https"))
                {
                    output = "https:" + output;
                }
                else
                {
                    output = "http" + output;
                }
            }
            Console.WriteLine(output);


            return output;
        }
        static async Task TestGetFromWebServer()
        {
            string address = address_web;
            var client = getHttpClient(address);
            string result = await client.GetStringAsync("/");
            string pattern = @"(<img src=)(.*?)[\s>]";
            Regex r = new Regex(pattern);
            MatchCollection mc;
            List<string> ls = new List<string>();
            mc = r.Matches(result);
            for (int i = 0; i < mc.Count; i++)
            {
                string result_img = mc[i].Value;
                string parsing = Parsing(result_img);
                //Console.WriteLine(parsing);
                ls.Add(parsing);
                //ls.Add(result);
            }
            string curr_dir = System.Environment.CurrentDirectory;
            WebClient client_dl = new WebClient();
            Console.WriteLine("当前地址："+curr_dir);
            int count = 0;
            try
            {
                foreach (var item in ls)
                {
                    
                        client_dl.DownloadFile(item, count.ToString() + ".png");
                        count++;
                        Console.WriteLine("已保存文件：" + count.ToString() + ".png");
                    
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
