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

            Islemler<bool> sinif = new Islemler<bool>();
            bool sonuc = sinif.IslemYap(true, -2);
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }

    class Islemler<T>
    {
        public T IslemYap(T kucukT,int param)
        {
            if (param >= 0)
            {
                return kucukT;
            }
            else
            {
                return default(T);
            }
        }
    }

}
