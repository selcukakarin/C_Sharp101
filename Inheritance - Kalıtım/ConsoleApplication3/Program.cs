using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program //Kalıtım - inheritance
    {
        static void Main(string[] args)
        {
            ikiBoyut iki = new ikiBoyut();
            iki.Genislik = 10;
            iki.Yukseklik = 20;
            iki.Goster();

            Console.WriteLine("*****************");

            Ucgen uc = new Ucgen();
            uc.Genislik = 30;
            uc.Yukseklik = 10;
            uc.Stil = "Üçgen";
            uc.StilGoster();
            uc.Goster();
            Console.WriteLine("Alan : " + uc.AlanHesapla());


            Console.ReadKey();
        }
    }
}
