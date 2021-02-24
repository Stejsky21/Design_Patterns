using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Navrhove_vzory
{
    class Kalendar
    {

        private static Dictionary<int, Mesic> mesice = new Dictionary<int, Mesic>();

        public static Mesic VygenerujMesic(int cislo)
        {
            if (mesice.ContainsKey(cislo))
            {
                Console.WriteLine("mam ulozene");
                return mesice[cislo];
            }
            else
            {
                Console.WriteLine("vypocitavam nazov mesiaca");
                // zložitý výpočet dát z hesla
                // zlozity vypocet nazvu z cisla
                string nazev = new DateTime(2015, cislo, 1)
                    .ToString("MMMM", CultureInfo.CreateSpecificCulture("cs"));
                Mesic mesic = new Mesic(cislo, nazev);
                mesice.Add(cislo, mesic);
                return mesic;
            }
        }
    }
}
