using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Seminar

            AnimalCu4Picioare a4p = new Caine()
            {
                Nume = "Caine",
                areAripi = AreAripi.Nu,
                NrPicioare = 4
            };
            Console.WriteLine(a4p.Descrie());

            Vaca vc = new Vaca()
            {
                Nume = "Vaca",
                areAripi = AreAripi.Nu,
                NrPicioare = 4
            };
            Console.WriteLine(vc.Descrie());

            AnimalCuMaiMultePicioare acm = new Miriapod()
            {
                Nume = "Miriapod",
                areAripi = AreAripi.Da,
                NrPicioare = 24
            };
            Console.WriteLine(acm.Descrie());

            List<AnimalCuPicioare> list = new List<AnimalCuPicioare>();
            list.Add(a4p);
            list.Add(acm);
            list.Add(vc);

            Console.WriteLine("*********************");

            foreach (AnimalCuPicioare item in list)
            {
                Console.WriteLine("Nume: " +item.Nume+"\n   Picioare: "+item.NrPicioare+"\n   Are aripi? "+item.areAripi);

            }

            Console.ReadKey();


            #endregion



            #region Curs
            //Dreptunghi dr = new Dreptunghi(10, 20);
            //dr.CalculArie();
            //dr.AfisareValoareArie();

            //Triunghi tr = new Triunghi(10, 20);
            //tr.CalculArie();
            //tr.AfisareValoareArie();

            //Voley v = new Voley();
            //v.Caracteristici();


            //SportCuMinge fotbal = new SportCuMinge()
            //{
            //    NumeSport = "Fotbal",
            //    NumarJucatori = 11,
            //    tipSport = TipSport.Colectiv,
            //    tipBalon =TipMinge.Rotunda

            //};
            //fotbal.Caracteristici();

            //SportCuMinge tenis = new SportCuMinge()
            //{
            //    NumeSport = "Tenis",
            //    NumarJucatori = 2,
            //    tipSport = TipSport.Individual,
            //    tipBalon =TipMinge.Rotunda


            //};
            //tenis.Caracteristici();

            //SportFaraMinge sah = new SportFaraMinge()
            //{
            //    NumeSport = "Sah",
            //    NumarJucatori = 2,
            //    tipSport = TipSport.Individual
            //};
            //sah.Caracteristici();

            //SportFaraMinge ski = new SportFaraMinge()
            //{
            //    NumeSport = "Ski",
            //    NumarJucatori = 1,
            //    tipSport = TipSport.Necunoscut
            //};
            //ski.Caracteristici();

            //SportFaraMinge atletism = new SportFaraMinge()
            //{
            //    NumeSport = "Atletism",
            //    NumarJucatori = 14,
            //    tipSport = TipSport.Necunoscut
            //};

            //Console.WriteLine("=======================");

            //List<ISport> lista = new List<ISport>();
            //lista.Add(v);
            //lista.Add(fotbal);
            //lista.Add(tenis);

            //List<ISport> lista2 = new List<ISport>();
            //lista2.Add(ski);
            //lista2.Add(atletism);
            //lista2.Add(sah);


            //lista.Sort();
            //lista2.Sort();///foloseste interfata IComparable
            //foreach (ISport item in lista)
            //{
            //    item.Caracteristici();

            //}

            //Console.WriteLine("***********************");

            //foreach (ISport item in lista2)
            //{
            //    item.Caracteristici();

            //}



            //Console.ReadKey();

            ////sortare in functie de nume pentru sport fara minge
            #endregion
        }
    }
}
