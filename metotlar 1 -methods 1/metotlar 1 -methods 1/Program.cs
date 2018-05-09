using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace metotlar_1__methods_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Topla(5, 4);
            //Yaz(result.ToString());
            //Bosluk(4);
            //Yaz(Topla(4, 5).ToString());
            //var sonuc = GetAccountName(10);
            //Yaz(sonuc);

            var sonuc = isValid("selcukakarin@gmail.com");
            Yaz(sonuc.ToString());

            Beklet();

        }

        static bool isValid(string email)
        {
            bool isValid = default(bool);
            if (email.Contains("@"))
            {
                isValid = true;
            }
            return isValid;
        }

        static string GetAccountName(int accountId)
        {
            string accountName = string.Empty;
            switch (accountId)
            {
                case 1:
                    accountName = "Selçuk";
                    break;
                case 2:
                    accountName = "Ahmet";
                    break;
                case 3:
                    accountName = "Mustafa";
                    break;
                default:
                    accountName = "unknown";
                    break;
            }
            return accountName;
        }

        static void Beklet()
        {
            Console.ReadKey();
        }

        static void Bosluk(int kacKere)
        {
            for (int i = 0; i < kacKere; i++)
            {
                Console.WriteLine();
            }
        }

        static void Yaz(string gelen)
        {
            Console.WriteLine(gelen);
        }

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}

