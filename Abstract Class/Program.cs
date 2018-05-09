using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract class
            Muhendis muhendis = new Muhendis();
            Console.WriteLine(muhendis.GetSalary());

            Console.ReadKey();
        }
    }
}
