using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StaticClasses
{
    static class Encryption
    {
        private static int _id;

        public static string Encrypt(string data)
        {
            // Kullanici k=new Kullanici();
            return data + _id;
        }

        public static string Decrypt(string data)
        {
            return data + _id;
        }

        /*public Encryption()
                {

                }*/
        static Encryption()
        {
            _id = new Random().Next(100, 1000);
        }
    }
}
