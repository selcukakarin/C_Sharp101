using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringin_dizi_özelliği
{
    class Program
    {
        static void Main(string[] args)
        {
            string akademi = "selcuk akademi";
            for (int i = 0; i < akademi.Length; i++)
            {
                Console.WriteLine(akademi[i]);
            }
            Console.ReadKey();
        }
    }
}
