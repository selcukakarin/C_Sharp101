using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_gelişmiş_1
{
    class Program
    {
        static void Main(string[] args)
        {

            YetkiAta(7, Yetki.Moderator);


            Console.ReadKey();
        }
        public static void YetkiAta(int kullaniciID, Yetki yetki)
        {
            Console.WriteLine("ID : " + kullaniciID);
            Console.WriteLine("Yetki : " + yetki);
            Console.WriteLine("Yetki Numarası : " + (int)yetki);
        }

    }
    enum Yetki
    {
        Normal = 1,
        Moderator = 10,
        Admin = 100
    }
}

