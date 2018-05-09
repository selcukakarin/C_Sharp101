using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSinif
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            var result = acc.GetAccount(1);

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
