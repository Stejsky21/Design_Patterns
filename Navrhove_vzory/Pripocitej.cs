using System;
using System.Collections.Generic;
using System.Text;

namespace Navrhove_vzory
{
    class Pripocitej : Operace
    {
        private int cislo;

        public Pripocitej(int cislo, Operace prev) : base(prev)
        {
            this.cislo = cislo;
        }

        public override double Vypocitaj(double x)
        {
            var y = base.Vypocitaj(x) ; 
            return y + cislo;
        }
    }
}
