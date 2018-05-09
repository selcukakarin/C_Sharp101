using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Classes___Mühürlü_Sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.propA = 1;
            b.propB = 3;

            Console.ReadKey();

        }

        sealed class A
        {
            public int propA { get; set; }
        }
        
        class B :A
        {
            public int propB { get; set; }
        }

    }
}
