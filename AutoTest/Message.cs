using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AutoTest
{
    internal class Message
    {
        /// <summary>
        /// Класс генерирует строку для отправки программе Evidence-Supervisor
        /// Пример строки:
        /// "22 августа 2022 г. 11:41:44 Разрешено Родители 6_62_24 КПП_2_Выезд_2 U2037693 Фамилия Имя Отчество "
        /// "22 августа 2022 г. 11:41:44 Запрещено Ученики 24 КПП_2_Выезд_2 U1996882 Фамилия Имя Отчество "
        /// </summary> 

        public Message(string document) {

            points = xmlHandler.GetPoinst(document);

        }

        Random random = new Random();
        XmlHandler xmlHandler = new XmlHandler();
        List<string> points = new List<string>();

        /* Метод формирует id пользователя */
        private string IdUser()
        {
            return $"U{random.Next(1, 10000000)}";
        }

        /* Метод генерирует строку с группами сопровождающих
         * пример: "66_44" */
        private string Group(int count)
        {
            string group = "";
            for(int i = 0; i < count; i++)
            {
                group += $"{random.Next(1, 100).ToString()}_";
            }

            return group.TrimEnd('_');
        }

        /* Метод преобразует из строки в в массив строк 
         * пример: "66_44" -> ["66", "44"] */
        private List<string> GroupList(string group)
        {
            List<string> gr = new List<string>();

            foreach(string s in group.Split('_'))
            {
                gr.Add(s);
            }

            return gr;
        }

        /* Метод формирует строку из сопровождающих и учащихся */
        private List<string> VisitorList(int count, string point)
        {
            List<string> visitors = new List<string>();
            string group = Group(count);
            List<string> groupList = GroupList(group);

            for(int i = 0; i < count; i++)
            {
                visitors.Add($"22 августа 2022 г. 11:41:44 Запрещено Ученики {groupList[i]} {point} {IdUser()} Фамилия Имя Отчество ");
            }
            visitors.Add($"22 августа 2022 г. 11:41:44 Разрешено Родители {group} {point} {IdUser()} Фамилия Имя Отчество ");
            return visitors;
        }

        /* Метод добавляет в массив message сформированные сроки для отправки */
        private void AddToMessage(List<string> message, List<string> toMessage)
        {
            foreach(string mes in message)
            {
                toMessage.Add(mes);
            }
        }

        public List<string> StringBuilder(int count)
        {
            List<string> message = new List<string>();

            if (points.Count <= 0)
            {
                Console.WriteLine("Нет списка КПП.\nНажмите любую клавишу на клавиатуре.");
                Console.ReadKey();
                Environment.Exit(-1);
            }
            else
            {
                foreach (string point in points)
                {
                    AddToMessage(VisitorList(count, point), message);
                }
            }

            return message;
        }
    }
}
