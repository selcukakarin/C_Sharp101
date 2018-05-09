using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection5
{
    class Program
    {
        static void Main() //string[] args
        {
            // Reflection - Yansıma
            /* Reflection nedir?
             * Reflection, bize hakkında bilgi sahibi olmadığımız programatik nesnelerle ilgili çalışma zamanında (runtime) bilgi 
             * alabilmemizi sağlayan bir yöntemdir. Örneğin, programın çalışma anında farklı bir DLL dosyasini uygulama içerisine
             * dahil ederek içerisindeki metot ve dışarıya açık nesneleri kullanabilmeyi sağlar. Örnek WİNAMP'ın tema sürükle bırak özelliği.
             */

            Type t = typeof(MyClass);
            MyClass reflect = new MyClass(10, 20);
            int val;

            Console.WriteLine("Kullanılan sınıf : "+t.Name);
            Console.WriteLine();

            MethodInfo[] mi = t.GetMethods();

            foreach (MethodInfo m in mi)
            {
                ParameterInfo[] pi = m.GetParameters();
                if (m.Name.Equals("Set",StringComparison.Ordinal) && pi[0].ParameterType==typeof(int))
                {
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;
                    m.Invoke(reflect,args);
                }
                else if(m.Name.Equals("Set", StringComparison.Ordinal) && pi[0].ParameterType == typeof(double))
                {
                    object[] args = new object[2];
                    args[0] = 2.32;
                    args[1] = 45.3;
                    m.Invoke(reflect, args);
                }
                else if (m.Name.Equals("Sum", StringComparison.Ordinal))
                {
                    val=(int)m.Invoke(reflect, null);
                    Console.WriteLine("Sum() Sonuç : "+val);

                }else if (m.Name.Equals("IsBetween", StringComparison.Ordinal))
                {
                    object[] args = new object[1];
                    args[0] = 15;
                    if ((bool)m.Invoke(reflect,args))
                    {
                        Console.WriteLine("x - y arası : 15");
                    }
                }else if (m.Name.Equals("Show", StringComparison.Ordinal)){
                    m.Invoke(reflect, null);
                }
            }

            Console.ReadKey();
        }
    }
    class MyClass
    {
        int x;
        int y;
        public MyClass(int i, int j)
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
        public void Set(double a, double b)
        {
            Console.Write("Inside set(double, double). ");
            x = (int)a;
            y = (int)b;
            Show();
        }
        public void Set(int a, int b)
        {
            Console.Write("Inside set(int, int). ");
            x = a;
            y = b;
            Show();
        }
        public void Show()
        {
            Console.WriteLine("x: {0},y : {1}", x, y);
        }

    }
}
