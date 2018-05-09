using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ (Language integrated query)

            #region Veri

            List<Ogrenci> Ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci {Id=1, Ad="Selçuk",Soyad="Akarın", DogumTarihi=new DateTime(1994,7,17) },
                new Ogrenci {Id=2, Ad="Ali",Soyad="Kemal", DogumTarihi=new DateTime(1992,7,17) },
                new Ogrenci {Id=3, Ad="Mustafa",Soyad="Gürz", DogumTarihi=new DateTime(1991,7,17) },
                new Ogrenci {Id=4, Ad="Tayfun",Soyad="Kemik", DogumTarihi=new DateTime(1990,7,17) },
                new Ogrenci {Id=5, Ad="Yeliz",Soyad="Taşkın", DogumTarihi=new DateTime(1993,7,17) },
                new Ogrenci {Id=6, Ad="Alp",Soyad="Utku", DogumTarihi=new DateTime(1994,7,17) },
                new Ogrenci {Id=7, Ad="Mahmut",Soyad="Cemil", DogumTarihi=new DateTime(1995,7,17) },
                new Ogrenci {Id=8, Ad="Süleyman",Soyad="Arslan", DogumTarihi=new DateTime(1987,7,17) },
                new Ogrenci {Id=9, Ad="Gündüz",Soyad="Akpençe", DogumTarihi=new DateTime(1984,7,17) },
                new Ogrenci {Id=10, Ad="Tuğçe",Soyad="Kalın", DogumTarihi=new DateTime(1989,7,17) }
            };

            #endregion

            #region ID'si 4 ten büyük olan öğrenciler

            //#region Normal C#

            //List<Ogrenci> OgrS = new List<Ogrenci>();
            //foreach (var ogr in Ogrenciler)
            //{
            //    if (ogr.Id > 4)
            //    {
            //        OgrS.Add(ogr);
            //    }
            //}

            ////Listele
            //foreach (var o in OgrS)
            //{
            //    Console.WriteLine(o.Ad);
            //}

            //#endregion

            //#region LINQ yöntemi

            //var query = from x in Ogrenciler
            //            where x.Id > 4
            //            select x;
            ////Listele
            //foreach (var o in query)
            //{
            //    Console.WriteLine(o.Ad);
            //}

            //#endregion

            //var q = Ogrenciler.Where(x => x.Id > 4);
            ////Listele
            //foreach (var o in q)
            //{
            //    Console.WriteLine(o.Ad);
            //}


            #endregion

            //Adının ilk harfi M olan öğrenciler

            //var q = Ogrenciler.Where(x => x.Ad[0] == 'M');
            //var q = Ogrenciler.Where(ogr => ogr.Ad.StartsWith("M"));
            //var q = Ogrenciler.Where(x => x.Ad.Substring(0, 1).ToUpper() == "M");
            //var q = from x in Ogrenciler
            //        where x.Ad.Substring(0, 1).ToUpper() == "M"
            //        select x;

            //Soyadının son harfi n olan öğrenciler

            //var q = Ogrenciler.Where(x => x.Soyad[x.Soyad.Length - 1] == 'n');
            //var q = Ogrenciler.Where(x => x.Soyad.Substring(x.Soyad.Length - 1, 1).ToLower() == "n");
            //var q = Ogrenciler.Where(x => x.Soyad.EndsWith("n"));

            //Yaşı 27'den küçük olan öğrenciler
            //var q = Ogrenciler.Where(x => (DateTime.Now.Year-x.DogumTarihi.Year)<27);
            //var q = Ogrenciler.Where(x => ((DateTime.Now - x.DogumTarihi).TotalDays / 365) < 27);

            //Pazartesi doğan öğrenciler
            //var q = Ogrenciler.Where(x => (x.DogumTarihi.DayOfWeek == DayOfWeek.Monday));
            //var q = Ogrenciler.Where(x => (x.DogumTarihi.DayOfWeek == DayOfWeek.Monday)&& x.Ad.StartsWith("A"));

            // ID'si 4'ten küçük olan öğrenciler
            //var q = Ogrenciler.Select(x => x.Id < 4);
            //var q = Ogrenciler.Select(x =>
            //  new
            //  {
            //      No = x.Id,
            //      AdSoyad = x.Ad + " " + x.Soyad
            //  });

            //var q = Ogrenciler.Where(x => (x.DogumTarihi.DayOfWeek == DayOfWeek.Monday));
            //List<Ogrenci> ogrenciler1 = new List<Ogrenci>();
            //ogrenciler1 = q.ToList();

            List<OgreDemo> q=Ogrenciler.Select(x=>new OgreDemo(x.Id,x.Ad+" "+x.Soyad)).ToList();


            foreach (var i in q)
            {
                //Console.WriteLine(i.Ad + " " + i.Soyad);
                Console.WriteLine(i.AdSoyad);
            }

            Console.ReadKey();
        }
    }
    public class OgreDemo
    {
        public int No { get; set; }
        public string AdSoyad { get; set; }
        public OgreDemo() { }
        public OgreDemo(int no,string adSoyad)
        {
            this.No = no;
            this.AdSoyad = adSoyad;
        }
    }
}
