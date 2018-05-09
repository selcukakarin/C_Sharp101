using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection3
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

            var user = new User()
            {
                userId = 2,
                userName = "Selçuk",
                email = "selcukakarin@gmail.com"
            };

            var props = user.GetType().GetProperties();
            foreach (var pr in props)
            {
                Console.WriteLine(pr.Name);
            }
            Console.WriteLine("-------------------------");

            var prop1 = user.GetType().GetProperty("userName");
            Console.WriteLine(prop1.Name);
            Console.WriteLine(prop1.GetValue(user));
            Console.ReadKey();
        }
    }
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
    }
}
