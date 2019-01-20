using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            int serverPort = 5000;
            UdpClient client = null;

            client = new UdpClient(serverPort);
            IPEndPoint m_ipEndPoint = new IPEndPoint(IPAddress.Any,0);
            
            while(true)
            {
                try
                {
                    byte[] buffer = client.Receive(ref m_ipEndPoint);
                    String revcMsg = Encoding.ASCII.GetString(buffer,0,buffer.Length);
                    Console.WriteLine(revcMsg);
                }
                catch(SocketException e)
                {
                    Console.WriteLine(e.ErrorCode + " "+e.Message);
                }
            }
        }
    }
}
