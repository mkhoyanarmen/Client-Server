using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Client_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IPAddress ipAddr = new IPAddress(new byte[] { 127, 0, 0, 1 });
            Console.WriteLine(ipAddr.ToString());

            ipAddr = IPAddress.Parse("127.0.0.1");
            Console.WriteLine(ipAddr.ToString());

            //IPAddress.TryParse("127.0d.0s.1f", out IPAddress iP);
            //Console.WriteLine(iP.ToString());//error, null(?) from c#8.0

            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Loopback, 8000);
            Console.WriteLine(iPEnd.ToString());

            Console.WriteLine(iPEnd.Address + ":" + iPEnd.Port + " //" + iPEnd.AddressFamily);*/

            //Console.WriteLine(Dns.GetHostName()); //PC Name

            IPEndPoint iPEnd = new IPEndPoint(Dns.GetHostByName(Dns.GetHostName()).AddressList[0], 8888);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(iPEnd);
            socket.Listen(1000);
            Console.WriteLine("Servery sksec ashxatel...");
            string message;
            var tcpClient = socket.Accept();
            Console.WriteLine("Miacvel e " + tcpClient.RemoteEndPoint + " clienty");
            while (true)
            {
                try
                {
                    byte[] data1 = new byte[1024];
                    int bytes = tcpClient.Receive(data1);
                    message = Encoding.UTF8.GetString(data1, 0, bytes);
                    Console.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + "." + DateTime.Now.Second);
                    Console.WriteLine(message);
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    message = Console.ReadLine();
                    tcpClient.Send(Encoding.ASCII.GetBytes(message));
                    Console.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + "." + DateTime.Now.Second);
                    Console.WriteLine(message);
                    Console.WriteLine();
                }
            }
        }
    }
}