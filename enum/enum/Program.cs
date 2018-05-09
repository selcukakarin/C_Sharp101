using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Yetki.Admin);

            var id = (int)Yetki.Admin;
            Console.WriteLine(id);

            Console.ReadKey();
        }

        enum Yetki
        {
            Normal = 3,
            Moderator = 4,
            Editor = 6,
            Admin = 7,
            SuperAdmin = 9
        }

        enum OnayDurum
        {
            OnayBekliyor = 1,
            Onaylandi = 2,
            Reddedildi = 3
        }

        public enum DayOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
    }
}

