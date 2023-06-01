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

        public static void GetIpv4Address()
        {

            /// <summary>
            /// Метод забирает IpV4 адареса локального хоста
            /// </summary> 
           
            string host = Dns.GetHostName();
            Console.WriteLine($"Имя компьютера: {host}");
            IPAddress[] addresses = Dns.GetHostAddresses(host);
            foreach (IPAddress address in addresses)
            {
                Console.WriteLine($"Адрес: {address.MapToIPv4()} ");
            }
            Console.ReadKey();
        }

        static void CreateAndSendMessage()
        {
            /// <summary> 
            /// Метод создает и отправляет строку
            /// </summary> 

            MessageGenerate message = new MessageGenerate("doors.xml");
            XmlHandler getIp= new XmlHandler();
            string ip = string.Empty;

            List<string> ipAddr = getIp.GetElemets("doors.xml", "ip");
            if (ipAddr.Count > 0)
            {
                ip = ipAddr[0];
            }

            string sleep = "5000";

            for ( ; ; )
            {
                foreach (string s in message.AllKppMessage(4))
                {
                    SendToSupervisor(10500, ip, s);
                }
                Thread.Sleep(int.Parse(sleep));
            }
        }


        public static string SendToSupervisor(int port, string server, string message, bool commandLine=true)
        {
            /// <summary> 
            /// Метод отправляет строку:  
            /// "22 августа 2022 г. 11:41:44 Разрешено Родители 6_62_24 КПП_2_Выезд_2 U2037693 Фамилия Имя Отчество "
            /// Программе Supervisor 
            /// </summary> 

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
               
                Thread.Sleep(50);

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

            return message;
        }
    }
}
