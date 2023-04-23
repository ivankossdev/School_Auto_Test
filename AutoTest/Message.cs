using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest
{
    internal class Message
    {
        /// <summary>
        /// Класс генерирует строку для отправки программе Evidence-Supervisor
        /// Пример строки:
        /// 22 августа 2022 г. 11:41:44 Разрешено Родители 6_62_24 КПП_2_Выезд_2 U2037693 Фамилия Имя Отчество
        /// 22 августа 2022 г. 11:41:44 Запрещено Ученики 24 КПП_2_Выезд_2 U1996882 Фамилия Имя Отчество
        /// </summary> 

        public Message() {
            points.point_1 = "КПП_1_Въезд_1";
            points.point_2 = "КПП_1_Въезд_2";
            points.point_3 = "КПП_2_Выезд_1";
            points.point_4 = "КПП_2_Выезд_2";
        }

        private struct Points
        {
            public string point_1;
            public string point_2;
            public string point_3;
            public string point_4;
        }

        Random random = new Random();
        Points points = new Points();


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
                visitors.Add($"22 августа 2022 г. 11:41:44 Запрещено Ученики {groupList[i]} {point} {IdUser()} Фамилия Имя Отчество");
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

        public List<string> StringBulder(int count)
        {
            List<string> message = new List<string>();

            AddToMessage(VisitorList(count, points.point_1), message);
            AddToMessage(VisitorList(count, points.point_2), message);
            AddToMessage(VisitorList(count, points.point_3), message);
            AddToMessage(VisitorList(count, points.point_4), message);

            return message;
        }
    }
}
