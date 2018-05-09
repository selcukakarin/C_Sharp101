using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriSeviyeSınıf_kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Advanced class - 1

            //Liste liste = new Liste();
            //Liste<decimal> liste = new Liste<decimal>();

            Liste<string> liste = new Liste<string>();
            liste.Add("Ali");
            liste.Add("Veli");
            liste.Get();

            Console.ReadKey(); 
            
        }
    }
    
    class Liste
    {

    }

    //class Liste<T>   //class overloading
    //{
    //    public Liste()
    //    {
    //        Console.WriteLine(typeof(T));
    //    }
    //}

    class Liste<T>
    {
        List<T> list = new List<T>();
        public void Add(T kucukT)
        {
            list.Add(kucukT);
        }
        public void Get()
        {
            foreach (var t in list)
            {
                Console.WriteLine("t -> " + t);
            }
        }

    }

}
