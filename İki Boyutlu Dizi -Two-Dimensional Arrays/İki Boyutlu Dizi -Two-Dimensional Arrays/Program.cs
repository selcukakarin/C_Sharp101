using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İki_Boyutlu_Dizi__Two_Dimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] ikiBoyut = new int[4, 2];
            int[,] ikiBoyut =
            {
                {1,2 },
                {3,4 },
                {5,6 },
                {7,8 }
            };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(ikiBoyut[i, j]);
                }
            }

            ikiBoyut[0, 0] = 10;
            ikiBoyut[0, 1] = 20;
            ikiBoyut[1, 0] = 30;
            ikiBoyut[1, 1] = 40;
            ikiBoyut[2, 0] = 50;
            ikiBoyut[2, 1] = 60;
            ikiBoyut[3, 0] = 70;
            ikiBoyut[3, 1] = 80;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(ikiBoyut[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}

