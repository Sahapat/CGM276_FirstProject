using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            String server = "54.169.188.111";
            int serverPort = 5000;
            String msg = "Sahapat tong-on ___ 5901292";
            byte[] sentPackage = Encoding.ASCII.GetBytes(msg);
            UdpClient client = new UdpClient();

            try
            {
                client.Send(sentPackage,sentPackage.Length,server,serverPort);
            }
            catch(SocketException e)
            {
                Console.WriteLine(e.ErrorCode + " " + e.Message);
            }
        }
    }
}
