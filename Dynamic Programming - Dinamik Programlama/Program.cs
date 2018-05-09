using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming___Dinamik_Programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dynamic Programming - Dinamik Programlama

            //dynamic a = 5;
            //Console.WriteLine(a);
            //a = "AA";
            //Console.WriteLine(a);

            //dynamic insan = new ExpandoObject();
            //insan.Ad = "Selçuk";
            //insan.Soyad = "Akarın";
            //Console.WriteLine(insan.Ad+" "+insan.Soyad);

            //dynamic kisi = new ExpandoObject();
            //kisi.Ad = "Selçuk";
            //kisi.Soyad = "Akarın";
            //kisi.AdGoster = new Action(() =>
            //  {
            //      Console.WriteLine("Ad : " + kisi.Ad);
            //  });
            //kisi.TekrarEt = new Func<string, string>(gelen =>
            //  {
            //      return gelen;
            //  });

            ////Çalıştırma işlemleri
            //kisi.AdGoster();

            //dynamic sonuc = kisi.TekrarEt("Çoklu Tekrar");
            //Console.WriteLine("Gelen cevap : "+sonuc);

            foreach (dynamic user in GetList())
            {
                Console.WriteLine("{0} {1}",user.Ad,user.Soyad);
            }

            Console.ReadKey();
        }

        private static IEnumerable<dynamic> GetList()
        {
            var users = new List<User> {
            new User() { ID = 3, FirstName = "Selçuk", LastName = "Akarın" },
            new User() { ID = 4, FirstName = "Mike", LastName = "Tyson" }
            };
            return from k in users
                   select new { Ad = k.FirstName, Soyad = k.LastName };
        }
    }
    class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
