using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_ve_params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EnBuyuk(1, 2));
            Console.WriteLine(EnBuyuk(1, 2, 3));
            Console.WriteLine(EnBuyuk(1, 2, 3, 4, 5, 6, 7, 8));
            Console.ReadKey();
        }

        static int EnBuyuk(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static int EnBuyuk(int a, int b, int c)
        {
            return EnBuyuk(EnBuyuk(a, b), c);
        }
        static int EnBuyuk(params int[] sayilar)
        {
            int eb = 0;
            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                if (sayilar[i] >= sayilar[i + 1])
                    eb = sayilar[i];
                else
                {
                    eb = sayilar[i + 1];
                }
            }
            return eb;
        }
    }
}
