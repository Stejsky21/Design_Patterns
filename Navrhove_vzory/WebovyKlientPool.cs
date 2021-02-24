using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Navrhove_vzory
{
    class WebovyKlientPool
    {
        private List<WebovyKlient> klients = new List<WebovyKlient>();

        public WebovyKlientPool()
        {
            for (int i = 0; i < 10; i++) klients.Add(new WebovyKlient());
        }

        public WebovyKlient GetKlient()
        {
            if (!klients.Any())
            {
                return new WebovyKlient();
            }
            else
            {
                WebovyKlient klienti = klients[0];
                klients.Remove(klienti);
                return klienti;
            }
        }
        public int GetCount()
        {
            return klients.Count;
        }
        public void ReturnKlient(WebovyKlient klient)
        {
            klients.Add(klient);
        }
    }
}
