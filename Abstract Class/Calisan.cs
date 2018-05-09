using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Calisan
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }

        public string GetFullName()
        {
            return this.Ad + " " + this.Soyad;
        }

        public abstract double GetSalary();

        //public double GetSalary()
        //{
        //    return 1200;
        //}
    }
}
