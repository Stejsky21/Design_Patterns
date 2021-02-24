using System;
using System.Collections.Generic;
using System.Text;

namespace Navrhove_vzory
{
    class Vynasob : Operace
    {

        private int cislo;

        public Vynasob(int cislo, Operace prev) : base(prev)
        {
            this.cislo = cislo;
        }

        public override double Vypocitaj(double x)
        {
            var y = base.Vypocitaj(x);
            return y * cislo;
        }
    }
}
