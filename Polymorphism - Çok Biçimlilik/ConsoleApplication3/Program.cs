using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism - Çok biçimlilik

            Basket basket = new Basket();

            Bread ekmek = new Bread(BreadType.Bugday);
            ekmek.ProductName = BreadType.Bugday.ToString();
            ekmek.ProductCode = "BRD-22222";

            Tekstil tekstil = new Tekstil();
            tekstil.Marka = TekstilMarka.Beymen;
            tekstil.ProductName = "Özel dikim";
            tekstil.Price = 250.5;
            tekstil.ProductCode = "TKT-55555";

            basket.Add(ekmek);
            basket.Add(tekstil);

            Console.WriteLine("ToplamFiyat (KDV Hariç) : " + basket.TotalPrice());
            Console.WriteLine("ToplamFiyat (KDV Dahil) : " + basket.TotalPriceWithKDV());
            Console.WriteLine("Sipariş KDV Toplamı : " + (basket.TotalPriceWithKDV()-basket.TotalPrice()));
            Console.WriteLine("****************************");

            foreach (var prd in basket.GetProducts())
            {
                Console.WriteLine(prd.ProductCode+" / "+prd.ProductName+" / "+prd.Price);
            }

            Console.ReadKey();


        }
    }
}
