using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Message message = new Message();

            Console.Write("IP: ");
            string ip = Console.ReadLine();

            while (true)
            {
                foreach (string s in message.StringBuilder())
                {
                    send(10500, ip.Trim(), s);
                }
                Thread.Sleep(5000);
            }
           
        }

        static void send(int port, string server, string message)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);

                byte[] data = Encoding.UTF8.GetBytes(message);


                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", message);

                Console.WriteLine(response.ToString());

                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

           
        }
    }
}
