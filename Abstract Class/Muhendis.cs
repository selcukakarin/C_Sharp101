﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Muhendis:Calisan
    {
        public Muhendis()
        {
            Unvan = "Mühendis";
        }

        public override double GetSalary()
        {
            return 4.000;
        }
    }
}
