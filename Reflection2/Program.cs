using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection2
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

            var ogrenci = new Ogrenci
            {
                Ad = "Selçuk",
                Soyad = "Akarın"
            };
            Type ogrenciTip = typeof(Ogrenci);
            FieldInfo[] ogrenciAlanlar = ogrenciTip.GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (FieldInfo ogrenciAlan in ogrenciAlanlar)
            {
                Console.WriteLine("Alan : "+ogrenciAlan.Name);
                Console.WriteLine("Değer : "+ogrenciAlan.GetValue(ogrenci));
                Console.WriteLine("***********************");
            }


            Console.ReadKey();
        }
    }

    public class Ogrenci
    {
        public string Ad;
        public string Soyad;
        string email;
    }
}
