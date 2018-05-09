using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Override
{
    class Muhendis:Calisan
    {
        public string  Tur { get; set; }
        public string Departman { get; set; }
        public override double MaasHesapla()
        {
            //return base.MaasHesapla();
            //return 10.000;
            return base.MaasHesapla() * 4;
        }
    }
}
