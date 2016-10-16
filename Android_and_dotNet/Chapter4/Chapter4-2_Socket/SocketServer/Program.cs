using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using MyNetworkLibrary;
using System.Threading;
namespace SocketServer
{
    class Program
    {
        private const int BufferSize = 1024;
        static void Main(string[] args)
        {
            byte[] data = new byte[BufferSize];
            IPAddress localAddress = AddressHelper.GetLocalHostIPv4Addresses().First();
            int LocalPort = AddressHelper.GetOneAvaliablePortInLocalHost();
            IPEndPoint ipep = new IPEndPoint(localAddress, LocalPort);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            using (server)
            {
                server.Bind(ipep);
                server.Listen(10);
                while (true)
                {
                    Console.WriteLine("主机 {0} 正在监听端口 {1} ，等待客户端连接……", localAddress, ipep.Port);
                    Socket client = server.Accept();
                    IPEndPoint clientep =
                           (IPEndPoint)client.RemoteEndPoint;

                    Console.WriteLine("已接收客户端连接，客户端IP地址：{0} 开放端口：{1}",
                            clientep.Address, clientep.Port);
                    int recv = client.Receive(data);
                    Console.WriteLine(Encoding.UTF8.GetString(data, 0, recv));
                    Console.WriteLine("客户端 {0} 断开连接\n", clientep.Address);
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
            }
        }
    }
}
