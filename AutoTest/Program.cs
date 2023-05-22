using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //XmlHandler handler = new XmlHandler();
            //handler.AddElement("doors.xml", "1234");

            CreateAndSendMessage();
        }

        /* Метод забирает IpV4 адареса локального хоста */
        static void GetIpv4Address()
        {
            string host = Dns.GetHostName();
            Console.WriteLine($"Имя компьютера: {host}");
            IPAddress[] addresses = Dns.GetHostAddresses(host);
            foreach (IPAddress address in addresses)
            {
                Console.WriteLine($"Адрес: {address.MapToIPv4()} ");
            }
            Console.ReadKey();
        }

        /* Метод создает и отправляет строку */
        static void CreateAndSendMessage()
        {
            Message message = new Message("doors.xml");

            string ip = "192.168.0.204";

            string sleep = "1000";

            for ( ; ; )
            {
                foreach (string s in message.StringBuilder(4))
                {
                    SendToSupervisor(10500, ip.Trim(), s);
                }
                Thread.Sleep(int.Parse(sleep));
            }
        }

        /* Метод отправляет строку:  
         * "22 августа 2022 г. 11:41:44 Разрешено Родители 6_62_24 КПП_2_Выезд_2 U2037693 Фамилия Имя Отчество "
         * Программе Supervisor */
        public static void SendToSupervisor(int port, string server, string message,bool commandLine=true)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);

                byte[] data = Encoding.UTF8.GetBytes(message);

                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);
                if (commandLine ) {
                    Console.WriteLine($"Sent: {message}");
                }
               
                Thread.Sleep(100);

                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine($"SocketException: {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }

    }
}
