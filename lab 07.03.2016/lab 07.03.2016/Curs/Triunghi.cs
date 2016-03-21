using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    class Triunghi : IFiguraGeometrica
    {
        private int arie;
        public int Inaltime { get; set; }
        public int Latura { get; set; }

        public Triunghi(int h, int l)
        {
            Inaltime = h;
            Latura = l;


        }

        public void AfisareValoareArie()
        {
            Console.WriteLine("Arie= {0}; Latura= {1}; Inaltime= {2}", arie, Latura, Inaltime);
        }

        public double CalculArie()
        {
            arie = (Latura * Inaltime) / 2;
            return arie;
        }
    }
}
