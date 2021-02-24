using System;
using System.Collections.Generic;
using System.Text;

namespace Navrhove_vzory
{
    public abstract class Operace
    {
        private Operace prev;

        public Operace(Operace prev)
        {
            this.prev = prev;
        }

        public virtual double Vypocitaj(double x)
        {
            if (prev != null)
            {
                return prev.Vypocitaj(x);
            }
            else
            {
                return x;
            }
        }
    }
}
