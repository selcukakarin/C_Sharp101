﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutu k = new Kutu(3, 4, 5);
            Console.WriteLine(k.uzunluk);

            Console.ReadKey();
        }


    }
}