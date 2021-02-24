using System;
using System.Collections.Generic;
using System.Text;

namespace Navrhove_vzory
{
    class Obrazovka
    {
        private static Obrazovka obrazovka = null;

        private Obrazovka()
        {

        }

        public static Obrazovka GetObrazovka()
        {
            if (obrazovka == null)
            {
                obrazovka = new Obrazovka();
            }
            return obrazovka;
        }

        
    }
}
