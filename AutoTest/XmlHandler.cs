using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Net.Sockets;

namespace AutoTest
{
    internal class XmlHandler
    {
        XmlDocument doors = new XmlDocument();

        /* Метод забирает из файла XML список доступных дверей */
        public List<string> GetPoinst(string document)
        {
            List<string> points = new List<string>();
            try
            {
                doors.Load($"{Directory.GetCurrentDirectory()}\\{document}");

                foreach (XmlElement xnode in doors.DocumentElement)
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        points.Add(childnode.InnerText);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Error: {e}");
            }
            catch (XmlException e)
            {
                Console.WriteLine($"Error: {e}");
            }
            finally
            {
                Console.WriteLine("Нужно добавить файл doors.xml");
            }
            return points;
        }
    }
}
