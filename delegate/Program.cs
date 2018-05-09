using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // temsilciler - delegate

            //Hesap hesap = Topla;
            //int sonuc = hesap(5, 4);

            //hesap = Carp;

            //Console.WriteLine("Carp : " + hesap(5,4));

            //Console.WriteLine(sonuc);

            //Hesap hesap = new Hesap(Topla);
            //Console.WriteLine("Topla : " +hesap(5,4));
            //hesap=new Hesap(Cikar);
            //Console.WriteLine("Çıkar : "+hesap(5,4));

            Hesap hesap = new Hesap(Topla);
            int sonuc = hesap.Invoke(4, 4);
            Console.WriteLine(sonuc);



            Console.ReadKey();

        }

        delegate int Hesap(int x, int y);

        static int Topla(int a,int b)
        {
            return a + b;
        }
        static int Cikar(int a, int b)
        {
            return a - b;
        }
        static int Carp(int a, int b)
        {
            return a * b;
        }
        static int Bol(int a, int b)
        {
            if(a>0 && b > 0)
            {
                return a / b;
            }
            return 0;
            
        }
    }
}
