using System;
using System.Collections.Generic;
using System.Text;

namespace Navrhove_vzory
{
    class OperaceBuilder
    {
        Operace operace;

        public OperaceBuilder(Operace operace)
        {
            this.operace = operace;
        }

        public OperaceBuilder Pripocitej(int v)
        {
            operace = new Pripocitej(v, operace);
            return this;
        }

        public OperaceBuilder Vynasob(int v)
        {
            operace = new Vynasob(v, operace);
            return this;
        }

        public Operace GetOperace()
        {
            return operace;
        }
    }
}
