using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            bool isValid = default(bool);
            string message = string.Empty;
            string str = string.Empty;
            do
            {
                Console.Write("Şifreyi giriniz : ");
                str = Console.ReadLine();
                if (str == "12345")
                {
                    isValid = true;
                }
                counter++;
                if (counter >= 5)
                {
                    break;
                }
            } while (str != "12345");

            Console.WriteLine("************");
            message = isValid ? "Başarılı" : "Başarısız";
            Console.WriteLine("Giriş " + message);
            Console.WriteLine("Parola deneme sayısı = " + counter);
            Console.WriteLine("**************");


            Console.ReadKey();
        }
    }
}

