using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    class Voley : ISport
    {
        public int NumarJucatori
        {
            get
            {
                return 6;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string NumeSport
        {
            get
            {
                return "Volei";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public TipSport tipSport
        {
            get
            {
                return TipSport.Colectiv;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Caracteristici()
        {
            Console.WriteLine("Nume sport= {0}; Tip Sport= {1}; Numar jucatori= {2}", NumeSport, tipSport, NumarJucatori);

        }
    }
}
