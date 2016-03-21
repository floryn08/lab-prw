using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    class SportFaraMinge : ISport, IComparable
    {
        private string numeSport;
        private int numarJucatori;
        private TipSport ts;


        public int NumarJucatori
        {
            get
            {
                return numarJucatori;
            }

            set
            {
                numarJucatori = value;
            }
        }

        public string NumeSport
        {
            get
            {
                return numeSport;
            }

            set
            {
                numeSport = value;
            }
        }

        public TipSport tipSport
        {
            get
            {
                return ts;
            }

            set
            {
                ts = value;
            }
        }

        public void Caracteristici()
        {
            Console.WriteLine("Nume sport= {0}; Tip Sport= {1}; Numar jucatori= {2}", NumeSport, tipSport, NumarJucatori);
        }

        public int CompareTo(object obj)
        {
            if (obj is ISport)
            {
                return this.NumeSport.CompareTo((obj as ISport).NumeSport);
            }
            else
            {
                return 0;
            }
        }
    }
}
