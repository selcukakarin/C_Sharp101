using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_ve_Func
{
    class Program
    {
        delegate void MyGenericDelegate<T>(T args);
        static void Main(string[] args)
        {
            //Action 

            //Geriye değer döndürmeyen(void) metotlar için kullanılır.
            //delegate'in geriye değer dönmeyen .Net Framework sınıfı versiyonudur.

            Action<int, string> action = new Action<int, string>(KullaniciBilgi);
            action(3, "Selçuk akarın");

            //Func

            // Geriye değer dönebilen Action versiyonudur. Ya da delegate versiyonudur.

            Func<DateTime, double> func = new Func<DateTime, double>(GetUserAgeAtTime);
            double dateDiff = func(new DateTime(1990,8,12));
            Console.WriteLine(dateDiff+" gündür yaşıyorsunuz");


            Console.ReadKey();
        }

        static void KullaniciBilgi(int kullaniciId,string adSoyad)
        {
            Console.WriteLine("Kullanici Id : "+kullaniciId);
            Console.WriteLine("Ad Soyad : "+adSoyad);

        }

        static double GetUserAgeAtTime(DateTime birthDate)
        {
            return (DateTime.Now - birthDate).TotalDays;
        }
    }
}
