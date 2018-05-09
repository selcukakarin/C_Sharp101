using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            //Virtual - Override

            Calisan isci = new Calisan();
            isci.Ad = "Selçuk";
            isci.Soyad = "akarın";
            Console.WriteLine(isci.ToString());
            Console.WriteLine("Maas : "+isci.MaasHesapla());

            Muhendis muhendis = new Muhendis();
            muhendis.Ad = "Dennis";
            muhendis.Soyad = "Ritchie";
            Console.WriteLine(muhendis.ToString());
            Console.WriteLine("Maas : "+muhendis.MaasHesapla());

            Console.ReadKey();
        }
    }
}
