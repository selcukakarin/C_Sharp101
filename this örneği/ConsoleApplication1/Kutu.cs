using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Kutu
    {
        public double uzunluk;
        public double genislik;
        public double yükseklik;

        //Constructor (Yapici metot)
        public Kutu()
        {
            this.uzunluk = 5;
            Console.WriteLine("Nesne örneği türetildi");
        }

        //Constructor Overload
        public Kutu(double uzunluk,double genislik,double yükseklik)
        {
            this.uzunluk = uzunluk;
            this.genislik = genislik;
            this.yükseklik = yükseklik;
        }
    }
}
