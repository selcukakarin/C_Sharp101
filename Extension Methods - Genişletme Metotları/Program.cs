using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods___Genişletme_Metotları
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extension Methods - Genişletme Metotları

            //object obj1 = new object();
            //obj1 = new Program();
            //obj1.DisplayASMInfo();
            //int x = 5;
            //Console.WriteLine(x.Square());

            ArrayList list = new ArrayList();
            list.Add("Selçuk");
            list.Add("Akarın");
            list.ShowItems();

            Console.ReadKey();

        }
    }
}
