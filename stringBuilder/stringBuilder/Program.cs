using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, email, fb_profil, sonuc, ayirac = "*************";
            ad = "selçuk";
            soyad = "akarın";
            email = "selcukakarin@gmail.com";
            fb_profil = "fb.com/selcukakarin";


            StringBuilder selcuk = new StringBuilder();
            selcuk.Append(ayirac);
            selcuk.Append(Environment.NewLine);
            selcuk.Append("Ad = " + ad);
            selcuk.Append(Environment.NewLine);
            selcuk.Append("Soyad = " + soyad);
            selcuk.Append(Environment.NewLine);
            selcuk.Append("Email = " + email);
            selcuk.Append(Environment.NewLine);
            selcuk.Append("Facebook profil = " + fb_profil);
            selcuk.Append(Environment.NewLine);
            selcuk.Append(ayirac);
            Console.WriteLine(selcuk.ToString());



            Console.ReadKey();

        }
    }
}
