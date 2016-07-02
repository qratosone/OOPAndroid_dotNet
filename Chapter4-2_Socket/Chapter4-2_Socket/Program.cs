using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using MyNetworkLibrary;
namespace Chapter4_2_Socket
{
    class Program
    {
        private const int BufferSize = 1024;
        static void Main(string[] args)
        {
            IPEndPoint iep = null;
            while (true)
            {
                iep = AddressHelper.GetRemoteMachineIPEndPoint();
                if (iep!=null)
                {
                    break;
                }
            }
            byte[] data = new byte[BufferSize];
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(iep);
                IPAddress localAddress = AddressHelper.GetLocalHostIPv4Addresses().First();
                string Message = "客户端PC向服务器发送信息";
                server.Send(Encoding.UTF8.GetBytes(Message));
                server.Shutdown(SocketShutdown.Both);
            }
            catch (SocketException e)
            {

                Console.WriteLine("无法连接远程主机 {0} ,原因：{1}，NativeErrorCode：{2},SocketErrorCode:{3}", iep.Address, e.Message, e.NativeErrorCode, e.SocketErrorCode);
            }
            finally
            {
                server.Close();
            }
            Console.WriteLine("消息发送完毕，断开与服务端的连接。");
            Console.WriteLine("敲任意键退出...");
            Console.ReadKey();
        }
    }
}
