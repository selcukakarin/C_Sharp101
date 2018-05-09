using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Kullanici : IKullanici,IYetki
    {
        public int KullaniciId
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int YetkiId
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Aktif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Ata(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public void Ekle(string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public KullaniciInfo Getir(int kullaniciId)
        {
            KullaniciInfo inf = new KullaniciInfo();
            inf.Ad = "Selçuk";
            inf.Soyad = "Akarın";
            inf.Id = 1;
            return inf;
        }

        public bool Giris(string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(int kullaniciId, string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Kaldir(int kullaniciId, int yetkiId)
        {
            throw new NotImplementedException();
        }

        public List<KullaniciInfo> KullanicilariGetir()
        {
            List<KullaniciInfo> Kullanicilar = new List<KullaniciInfo>();
            Kullanicilar.Add(new KullaniciInfo() { Id = 33, Ad = "Mustafa", Soyad = "Akarın" });
            Kullanicilar.Add(new KullaniciInfo() { Id = 34, Ad = "Alican", Soyad = "Akarın" });
            return Kullanicilar;
        }

        public void Pasif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Sil(int kullaniciId)
        {
            throw new NotImplementedException();
        }
        public void Sil(string email)
        {
            // ekstra yetenek ekleme
        }
    }
}
