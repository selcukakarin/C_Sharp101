using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_delegate
{
    class Program
    {
        delegate void MyGenericDelegate<T>(T args);
        static void Main(string[] args)
        {
            //generic delegate

            //MyGenericDelegate<string> stringDelegate = new MyGenericDelegate<string>(StringTarget);
            //stringDelegate("Selçuk Akarın");

            MyGenericDelegate<int> intDelegate = new MyGenericDelegate<int>(IntTarget);
            intDelegate(6);

            Console.ReadKey();
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("Arg metnini büyüt : "+arg.ToUpper());
        }
        static void IntTarget(int arg)
        {
            Console.WriteLine("++arg : "+ ++arg);
        }
    }
}
