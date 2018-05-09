using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reflection - Yansıma
            /* Reflection nedir?
             * Reflection, bize hakkında bilgi sahibi olmadığımız programatik nesnelerle ilgili çalışma zamanında (runtime) bilgi 
             * alabilmemizi sağlayan bir yöntemdir. Örneğin, programın çalışma anında farklı bir DLL dosyasini uygulama içerisine
             * dahil ederek içerisindeki metot ve dışarıya açık nesneleri kullanabilmeyi sağlar. Örnek WİNAMP'ın tema sürükle bırak özelliği.
             */

            //herbert schildt instance

            Type t = typeof(MyClass);

            Console.WriteLine("İncelenecek metot : "+t.Name);
            Console.WriteLine();

            Console.WriteLine("Desteklenen metotlar : ");

            MethodInfo[] mi = t.GetMethods();

            foreach (MethodInfo m in mi)
            {
                Console.Write("   " + m.ReturnType.Name+" "+m.Name+"(");
                ParameterInfo[] pi = m.GetParameters();
                for(int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name+" "+pi[i].Name);
                    if (i + 1 < pi.Length)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write(")");
                Console.WriteLine();
                Console.ReadLine();
            }

            Console.ReadKey();
        }
    }

    class MyClass
    {
        int x;
        int y;
        public MyClass(int i,int j)
        {
            x = i;
            y = j;
        }
        public int Sum()
        {
            return x + y;
        }
        public bool IsBetween(int i)
        {
            if (x < i && i < y)
                return true;
            else
                return false;
        }
        public void Set(double a,double b)
        {
            x = (int)a;
            y = (int)b;
        }
        public void Show()
        {
            Console.WriteLine("x: {0},y : {1}",x,y);
        }

    }
}
