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
        /// ['22', 'августа', '2022', 'г.', '11:41:44', 'Запрещено', 'Ученики', '60', 'КПП_1_Въезд_1', 'U122', 'Фамилия', 'Имя', 'Отчество', '']
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


        /* Метод формирует строку */
        public string[] StringBuilder()
        {
            string group = Group(2);

            string student1 = group.Split('_')[0].ToString();
            string student2 = group.Split('_')[1].ToString();

            string[] sendUsers =
            {
                $"22 августа 2022 г. 11:41:44 Запрещено Ученики {student1} {points.point_1} {IdUser()} Фамилия Имя Отчество ",
                $"22 августа 2022 г. 11:41:44 Запрещено Ученики {student2} {points.point_1} {IdUser()} Фамилия Имя Отчество ",
                $"22 августа 2022 г. 11:41:44 Разрешено Родители {group} {points.point_1} {IdUser()} Фамилия Имя Отчество ",

                $"22 августа 2022 г. 11:41:44 Запрещено Ученики {student1} {points.point_2} {IdUser()} Фамилия Имя Отчество ",
                $"22 августа 2022 г. 11:41:44 Запрещено Ученики {student2} {points.point_2} {IdUser()} Фамилия Имя Отчество ",
                $"22 августа 2022 г. 11:41:44 Разрешено Родители {group} {points.point_2} {IdUser()} Фамилия Имя Отчество ",

                $"22 августа 2022 г. 11:41:44 Запрещено Ученики {student1} {points.point_3} {IdUser()} Фамилия Имя Отчество ",
                $"22 августа 2022 г. 11:41:44 Запрещено Ученики {student2} {points.point_3} {IdUser()} Фамилия Имя Отчество ",
                $"22 августа 2022 г. 11:41:44 Разрешено Родители {group} {points.point_3} {IdUser()} Фамилия Имя Отчество ",

                $"22 августа 2022 г. 11:41:44 Запрещено Ученики {student1} {points.point_4} {IdUser()} Фамилия Имя Отчество ",
                $"22 августа 2022 г. 11:41:44 Запрещено Ученики {student2} {points.point_4} {IdUser()} Фамилия Имя Отчество ",
                $"22 августа 2022 г. 11:41:44 Разрешено Родители {group} {points.point_4} {IdUser()} Фамилия Имя Отчество "
            };

            return sendUsers;
        }

        /* Метод формирует id пользователя */
        private string IdUser()
        {
            return $"U{random.Next(1, 1000)}";
        }

        private string Group(int count)
        {
            string group = null;
            for(int i = 0; i < count; i++)
            {
                group += $"{random.Next(1, 100).ToString()}_";
            }

            return group.TrimEnd('_');
        }
    }
}
