using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_ve_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa = 10;
            int selcuk;

            Console.WriteLine("Param isimli metoda girmeden önce " + aa);
            Param(aa);
            Console.WriteLine("Param isimli metoda girdikten sonra " + aa);

            Console.WriteLine("------------------------------");

            Console.WriteLine("ParamRef isimli metoda girmeden önce " + aa);
            ParamRef(ref aa);
            Console.WriteLine("ParamRef isimli metoda girdikten sonra " + aa);

            ParamOut(out selcuk);
            Console.WriteLine("ParamOut isimli metoda girdikten sonra " + selcuk);

            Console.ReadKey();
        }

        static void Param(int x)
        {
            x = x * 2;
        }
        static void ParamRef(ref int x)
        {
            x = x * 2;
        }
        static void ParamOut(out int x)
        {
            x = 2;
        }

    }
}

