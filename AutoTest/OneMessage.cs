using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoTest
{
    public class OneMessage : MessageGenerate
    {
        string group  = string.Empty;
        public OneMessage(string document) : base(document)
        {
            group = Group(1);
        }

        public string SendChildren(string point)
        {
            return $"22 августа 2022 г. 11:41:44 Запрещено Ученики {group} {point} {IdUser()} ";
        }

        public string SendParent(string point)
        {
            return $"22 августа 2022 г. 11:41:44 Разрешено Родители {group} {point} {IdUser()} ";
        }
    }
}
