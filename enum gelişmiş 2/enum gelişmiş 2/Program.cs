using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_gelişmiş_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum Kullanımı
            Ayakkabi ayak = new Ayakkabi();
            ayak.Brand = AyakkabiMarka.Nike;
            ayak.SearchByBrand(AyakkabiMarka.Nixe);

            Console.WriteLine("No : " + (int)AyakkabiMarka.Adidas);
            Console.WriteLine("Marka : " + ayak.Brand);
            Console.WriteLine("No : " + (int)ayak.Brand);


            Console.ReadKey();
        }

    }
    enum AyakkabiMarka
    {
        Adidas = 12,
        Nike = 48,
        Nixe = 50,
        Badidas = 100,
    }

    class Ayakkabi
    {
        public AyakkabiMarka Brand { get; set; }
        public void SearchByBrand(AyakkabiMarka brand)
        {
            if (Brand == brand)
            {
                Console.WriteLine("Buldum");
            }
            else
            {
                Console.WriteLine("Bulamadım");
            }
        }
    }
}

