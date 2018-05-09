using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace non_generic_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NonGeneric

            // Farklı türlerdeki verilerin birarada saklanabildiği koleksiyon türleridir.
            // İçerisindeki verinin kullanılabilmesi için boxing/unboxing işlemine tabi tutulması gerekir.
            // System.Collections namespace'inde yer alırlar.

            // İçerikler: ArrayList, HashTable, SortedList

            ArrayList Sehirler = new ArrayList();
            Sehirler.Add("İstanbul");
            Sehirler.Add("Ankara");
            Sehirler.Add("İzmir");
            Sehirler.Add("Antalya");
            Sehirler.Add("Adana");

            //foreach (var sehir in Sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            //Console.WriteLine("Count : "+Sehirler.Count);
            //Console.WriteLine("Capacity : " + Sehirler.Capacity);
            //Sehirler.Capacity = 100;
            //Sehirler.Contains("İzmir");
            //Console.WriteLine("Capacity : " + Sehirler.Capacity);

            //Sehirler.Add(true);
            //Sehirler.Add(3);
            //Sehirler.Add(new Program());

            //Array array = Array.CreateInstance(typeof(int), 10);

            //object[] sehirX = Sehirler.ToArray();
            //foreach (var seh in sehirX)
            //{
            //    Console.WriteLine(seh);
            //}

            //ArrayList liste = new ArrayList();
            //liste.Add("İstanbul");
            //liste.Add(4.3M);
            //liste.Add(false);
            //liste.Add(new Program());
            //liste.Add("Mersin");
            //liste.Add("Ankara");

            //for (int i = 0; i < liste.Count; i++)
            //{
            //    Console.WriteLine(liste[i]);
            //}

            //Console.WriteLine(liste[1]);
            //Console.WriteLine(liste[1].GetType());
            //Console.WriteLine(Convert.ToDecimal(liste[1]) * Convert.ToDecimal(liste[1]));

            #endregion

            #region HashTable Example

            Hashtable Siniflar = new Hashtable();
            Siniflar.Add("007", "Yazılım ve Veri tabanı uzmanlığı");
            Siniflar.Add("008", "At");
            Siniflar.Add("005", "Dem");
            Siniflar.Add("001", "Çay");
            Siniflar.Add("006", "olsa da içsek");
            Siniflar.Add("003", "Çay");
            Siniflar.Add("004", "olsa da içsek");

            foreach (DictionaryEntry sinif in Siniflar)
            {
                Console.WriteLine(sinif.Key);
            }

            #endregion

            Console.ReadKey();
        }
    }
}


