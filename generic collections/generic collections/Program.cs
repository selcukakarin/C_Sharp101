using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic

            // System.Collections.Generic namespace'i içerisinde yer alır.
            // Veriler object türünde değil, belirtilen türde alınırlar
            // Boxing, unboxing işlemine gerek olmadığını gösterir.
            //Oluşturma sırasında veri tipini belirtmek zorundadır.
            // Arraylist gibi NonGeneric yapılara göre daha performanslı çalışır.

            // İçerikler; List, Stack, Queue, LinkedList, Dictionary, ShortedDictionary, SortedSet, HashSet

            #region List Example
            //List<string> Diller = new List<string>();
            //Diller.Add("C");
            //Diller.Add("C++");
            //Diller.Add("C#");

            //foreach (var dil in Diller)
            //{
            //    Console.WriteLine(dil);
            //}

            //Console.WriteLine(Diller[Diller.Count - 1]);
            //Diller.RemoveRange(1, 2);

            //foreach(var li in Diller)
            //{
            //    Console.WriteLine(li);
            //}
            //List<Program> list = new List<Program>();
            //list.Add(new Program());

            #endregion

            #region Dictionary Example

            Dictionary<int, string> Kullanicilar = new Dictionary<int, string>();
            Kullanicilar.Add(2, "Ali");
            Kullanicilar.Add(4, "Veli");

            //foreach (KeyValuePair<int,string> kullanici in Kullanicilar)
            //{
            //    Console.WriteLine(kullanici.Value);
            //    KeyValuePair<int, string> gelkullanici = kullanici;
            //}

            //KeyValuePair<int, string> kull = Kullanicilar.First();
            //Console.WriteLine(kull.Key + " - " + kull.Value);

            //string str = Kullanicilar.Values.First();
            //Console.WriteLine(str) ;

            Dictionary<int, string> Diller = new Dictionary<int, string>()
            {
                {1,"C" },
                {2,"C++" },
                {3,"C#" }
            };

            List<string> dilListesi = Diller.Values.ToList();

            foreach (var dil in dilListesi)
            {
                Console.WriteLine(dil);
            }

            #endregion

            Console.ReadKey();

            #endregion
        }
    }
}

