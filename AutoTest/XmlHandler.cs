using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Net.Sockets;
using System.Xml.Linq;
using System.Reflection;

namespace AutoTest
{
    public class XmlHandler
    {
        XmlDocument door = new XmlDocument();

        /* Метод забирает из файла XML список доступных дверей */
        public List<string> GetPoinst(string document)
        {
            List<string> points = new List<string>();
            try
            {
                door.Load($"{Directory.GetCurrentDirectory()}\\{document}");

                foreach (XmlElement xnode in door.DocumentElement)
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

        public List<string> GetElemets(string document, string node)
        {
            List<string> elements = new List<string>();

            try
            {
                door.Load($"{Directory.GetCurrentDirectory()}\\{document}");
                XmlNodeList elemList = door.GetElementsByTagName(node);

                for (int i = 0; i < elemList.Count; i++)
                {
                    elements.Add(elemList[i].InnerText.ToString().Trim());
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

            return elements;
        }

        public void AddElement(string document, string nameNode)
        {
            door.Load($"{Directory.GetCurrentDirectory()}\\{document}");

            /* Создаем узел door */
            XmlElement doorElement = door.CreateElement("door");
            XmlAttribute doorAttr = door.CreateAttribute("name");
            XmlText doorText = door.CreateTextNode("point_5");
            doorAttr.AppendChild(doorText);

            /* Создаем узел name */
            XmlElement nameElement = door.CreateElement("name");
            XmlText nameText = door.CreateTextNode(nameNode);
            nameElement.AppendChild(nameText);

            doorElement.Attributes.Append(doorAttr);
            doorElement.AppendChild(nameElement);

            XmlElement root = door.DocumentElement;
            root.AppendChild(doorElement);

            door.Save(document);
        }
    }
}
