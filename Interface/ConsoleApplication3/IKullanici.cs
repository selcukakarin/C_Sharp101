using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface IKullanici
    {
        void Ekle(string kullaniciAd, string email, string sifre);
        void Guncelle(int kullaniciId, string kullaniciAd, string email, string sifre);
        void Sil(int kullaniciId);
        KullaniciInfo Getir(int kullaniciId);
        List<KullaniciInfo> KullanicilariGetir();
        void Aktif(int kullaniciId);
        void Pasif(int kullaniciId);
        bool Giris(string email, string sifre);
    }
}
