using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = ProjectA.TeamA;
using PATB = ProjectB.TeamA;


namespace NameSpace_kullanımı_ve_alias
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProjectA.TeamA.ClassA sinif1 = new ProjectA.TeamA.ClassA();
            //sinif1.Yaz();
            //ProjectA.TeamA.ClassA.Print();

            PATA.ClassA ccc = new PATA.ClassA();
            ccc.Yaz();

            Console.ReadKey();

        }
    }
}
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeA, EkipA, SınıfA, Print ");
            }
            public void Yaz()
            {
                Console.WriteLine("ProjeA, EkipA, SınıfA, Yaz ");
            }
        }
    }
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeA, EkipB, ClassA, Print");
            }
        }
    }
}

namespace ProjectB
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeB, EkipA, SınıfA, Print()");
            }
        }
    }
}
