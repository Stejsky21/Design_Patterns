using System;

namespace Navrhove_vzory
{
    
    class Program : Verze
    {
        
        static void Main(string[] args)
        {
            //var dataFactory = new DataFactory();
            //IData objekt1 = dataFactory.GetData(50);
            //Console.WriteLine(objekt1);
            //IData objekt2 = dataFactory.GetData(150);
            //Console.WriteLine(objekt2);

            //var kalendar = new Kalendar();
            //var mesic = Kalendar.VygenerujMesic(1);
            //Console.WriteLine(mesic.nazev);
            //mesic = Kalendar.VygenerujMesic(1);
            //Console.WriteLine(mesic.nazev);

            //var pool = new WebovyKlientPool();
            //var count = pool.GetCount();
            //Console.WriteLine(count);
            //var client = pool.GetKlient();
            //var client2 = pool.GetKlient();
            //var count2 = pool.GetCount();
            //Console.WriteLine(count2);
            //// tvrda a dlha a narocna praca s klientom
            //pool.ReturnKlient(client);
            //Console.WriteLine(pool.GetCount());

            //var operaceBuiler = new OperaceBuilder(null);
            //var vyraz = operaceBuiler.Pripocitej(-3).Vynasob(2).GetOperace();
            //Console.WriteLine(vyraz.Vypocitaj(10));




        }
        
        
        [Test]
        [Verze]
        public void vypocitej()
        {

        }
    }
}
