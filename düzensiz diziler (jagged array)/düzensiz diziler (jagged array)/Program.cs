using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace düzensiz_diziler__jagged_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged =
            {
                new int[] {1,2,3,4,5,6},
                new int[] {1,2},
                new int[] {1,2,3,4},
                new int[] {1}
            };

            foreach (var jag in jagged)
            {
                foreach (var item in jag)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

