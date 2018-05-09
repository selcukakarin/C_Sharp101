using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
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

            string path = @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\System.dll";
            Assembly assembly = Assembly.LoadFile(path);
            AssemblyBilgiGoster(assembly);

            Assembly ourAsm = Assembly.GetExecutingAssembly();
            AssemblyBilgiGoster(ourAsm);



            Console.ReadKey();
        }
        static void AssemblyBilgiGoster(Assembly asm)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine(asm.FullName);
            Console.WriteLine("GAC'da mı? : "+(asm.GlobalAssemblyCache?"Evet":"Hayır"));
            Console.WriteLine("Path : "+asm.Location);
            Console.WriteLine("Versiyon : "+asm.ImageRuntimeVersion);

        }
    }
}
