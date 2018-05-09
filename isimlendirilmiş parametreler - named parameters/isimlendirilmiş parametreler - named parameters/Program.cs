using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isimlendirilmiş_parametreler___named_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            KullaniciEkle(
                ad: "Selcuk",
                soyad: "Akarın",
                aktifMi: true,
                cinsiyet: true
                );
            Console.ReadKey();
        }

        static void KullaniciEkle(string ad, string soyad, bool aktifMi = true, bool cinsiyet = true)
        {
            Console.WriteLine("Ad : {0} , Soyad : {1}, Aktif mi : {2}, Cinsiyet : {3} ", ad, soyad, aktifMi, cinsiyet);
        }
    }
}
