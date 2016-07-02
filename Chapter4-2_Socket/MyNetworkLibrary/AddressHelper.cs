using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace MyNetworkLibrary
{
    public class AddressHelper
    {
        public static IPAddress[] GetLocalHostIPv4Addresses()
        {
            String LocalhostName = Dns.GetHostName(); //先获取本机名称
            IPHostEntry host = Dns.GetHostEntry(LocalhostName);
            List<IPAddress> addresses = new List<IPAddress>();
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily==AddressFamily.InterNetwork)
                {
                    addresses.Add(ip);
                }
            }
            return addresses.ToArray();
        }
        public static IPEndPoint GetRemoteMachineIPEndPoint()
        {
            IPEndPoint iep = null;
            try
            {
                Console.Write("Input the remote server IP: ");
                IPAddress address = IPAddress.Parse(Console.ReadLine());
                Console.Write("Input the port number: ");
                int port = Convert.ToInt32(Console.ReadLine());
                if (port>65536||port<1024)
                {
                    throw new Exception("Error Invalid port number!");
                }
                iep = new IPEndPoint(address, port);
            }
            catch (ArgumentNullException)
            {

                Console.WriteLine("Invalid input!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return iep;
        }
        public static int GetOneAvaliablePortInLocalHost() {
            Mutex mtx = new Mutex(false, "MyNetworkLibrary.AddressHelper.GetOneAvailablePort");
            try
            {
                mtx.WaitOne();
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
                using (Socket tempSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    tempSocket.Bind(ep);
                    IPEndPoint ipep = tempSocket.LocalEndPoint as IPEndPoint;
                    return ipep.Port;
                }
            }
            finally
            {
                mtx.ReleaseMutex();
            }
        }

    }
}
