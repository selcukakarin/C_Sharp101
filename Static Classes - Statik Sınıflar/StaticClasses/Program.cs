using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Encryption encrypt = new Encryption();
            encrypt.Encrypt("abc");
            encrypt.Decrypt("asadasd23");
            */

            Console.WriteLine(Encryption.Encrypt("selcuk"));
            Console.WriteLine(Encryption.Decrypt("akarın"));

            Console.ReadKey();

        }
    }
}
