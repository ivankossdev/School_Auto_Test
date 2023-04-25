using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Net.Sockets;
using System.Xml.Linq;

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

            return points;
        }

        public void AddElement(string document)
        {
            doors.Load($"{Directory.GetCurrentDirectory()}\\{document}");
            XmlElement root = doors.DocumentElement;

            XmlElement point = doors.CreateElement("door");
            XmlAttribute nameAttr = doors.CreateAttribute("name");

            XmlText nameText = doors.CreateTextNode("point_5");

            nameAttr.AppendChild(nameText);

            point.Attributes.Append(nameAttr);
            doors.AppendChild(point);
            doors.Save(document);
        }
    }
}
