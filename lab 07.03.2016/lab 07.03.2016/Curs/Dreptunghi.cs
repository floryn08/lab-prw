using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    class Dreptunghi : IFiguraGeometrica
    {

        private int arie;

        public int Lungime { get; set; }

        public int Latime { get; set; }

        public Dreptunghi(int l, int L)
        {
            Lungime = L;
            Latime = l;
        }

        public void AfisareValoareArie()
        {
            Console.WriteLine("Arie= {0}; Lungime= {1}; Latime= {2}", arie, Lungime, Latime);
        }

        public double CalculArie()
        {
            arie = Lungime * Latime;
            return arie;
        }
    }
}
