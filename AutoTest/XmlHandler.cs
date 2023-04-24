using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace AutoTest
{
    internal class XmlHandler
    {
        XmlDocument doors = new XmlDocument();
        public List<string> ReadDocument(string document)
        {
            doors.Load($"{Directory.GetCurrentDirectory()}\\{document}");

            List<string> points = new List<string>();

            foreach (XmlElement xnode in doors.DocumentElement)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    
                    points.Add(childnode.InnerText);
                }
            }

            return points;
        }
    }
}
