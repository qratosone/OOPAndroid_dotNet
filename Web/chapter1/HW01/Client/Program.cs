using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string address;
            Console.WriteLine("请输入连接地址：");
            address = Console.ReadLine();
            Console.WriteLine("请输入数字A：");
            int num_a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入数字B：");
            int num_b = int.Parse(Console.ReadLine());
            var data = new Binary()
            {
                num_A = num_a,
                num_B = num_b,
            };
            Post(data, address).Wait();
            
            Console.WriteLine("\n演示结束，敲任意键退出……");

            Console.ReadKey(true);
        }
        static HttpClient getHttpClient(string address)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(address); //建立连接
            client.DefaultRequestHeaders.Add("Accept", "application/json"); //接收类型为json
            return client;
        }
        static async Task Post(Binary data,string address)
        {
            

            try
            {
                var client = getHttpClient(address);
                var response = await client.PostAsJsonAsync("api/Home", data); //作为json发送
                response.EnsureSuccessStatusCode();//确保成功
                
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
