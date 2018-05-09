using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class___Parçalı_Sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Partial Class

            People people = new People();
            people.FirstName = "Selçuk";
            people.LastName = "Akarın";
            people.Email = "selcukakarin@gmail.com";
            people.Password = "1234";
            people.BirthDate = new DateTime(1990, 1, 2);

            Console.WriteLine(people.GetFullName());
            Console.WriteLine(people.GetEmail(2));

            Console.ReadKey();
        }
    }
}
