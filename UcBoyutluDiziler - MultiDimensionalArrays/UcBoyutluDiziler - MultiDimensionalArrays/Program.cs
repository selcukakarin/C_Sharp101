using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcBoyutluDiziler___MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,,] ucBoyut;
            //int[,,] ucBoyut = new int[4, 2, 2];
            int[,,] ucBoyut =
            {
                { {1,2 }, {3,4 } },
                { {5,6 },{7,8 } },
                { {9,10 }, {11,12 } },
                { {13,14 }, {15,16 } }
            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write(ucBoyut[i, j, k] + "   ");
                    }
                }
            }

            ucBoyut[0, 0, 0] = 10;
            ucBoyut[0, 0, 1] = 20;
            ucBoyut[0, 1, 0] = 30;
            ucBoyut[0, 1, 1] = 40;
            ucBoyut[1, 0, 0] = 50;
            ucBoyut[1, 0, 1] = 60;
            ucBoyut[1, 1, 0] = 70;
            ucBoyut[1, 1, 1] = 80;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write(ucBoyut[i, j, k] + "   ");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
