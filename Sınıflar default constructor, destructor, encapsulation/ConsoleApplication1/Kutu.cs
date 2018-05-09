using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Kutu
    {
        private double uzunluk;
        private double genislik;
        private double yükseklik;

        //Constructor (Yapici metot)
        public Kutu()
        {
            this.uzunluk = 5;
            Console.WriteLine("Nesne örneği türetildi");
        }

        //Constructor Overload
        public Kutu(double uzunluk, double genislik, double yükseklik)
        {
            this.uzunluk = uzunluk;
            this.Genislik = genislik;
            this.yükseklik = yükseklik;
        }

        // Destructor (Yıkıcı Metot)
        ~Kutu()
        {
            Console.WriteLine("Sınıf yıkılıyor....");
            Console.ReadKey();
        }

        // Encapsulation (Kapsülleme)

        #region Getter & Setter Methods

        public double GetUzunluk()
        {
            return uzunluk;
        }

        public void SetUzunluk(double uzunluk)
        {
            if (uzunluk >= 2)
            {
                this.uzunluk = uzunluk;
            }
            else
            {
                this.uzunluk = 2;
            }
        }

        #endregion

        #region Property

        //public double Genislik
        //{
        //    get
        //    {
        //        return genislik;
        //    }
        //    set
        //    {
        //        if (value >= 2)
        //        {
        //            this.genislik = value;
        //        }
        //        else
        //        {
        //            this.genislik = 2;
        //        }
        //    }
        //}

        #endregion
        public double Yukseklik { get; set; }

        public double Genislik
        {
            get
            {
                return genislik;
            }

            set
            {
                genislik = value;
            }
        }
    }
}
