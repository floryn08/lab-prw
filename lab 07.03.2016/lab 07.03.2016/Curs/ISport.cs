using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{

    public enum TipMinge
    {
        Rotunda,
        Ovala
    }

    public enum TipSport
    {
        Individual,
        Colectiv,
        Necunoscut
    }

    interface ISport
    {

        TipSport tipSport { get; set; }
        int NumarJucatori { get; set; }
        string NumeSport { get; set; }
        void Caracteristici();


    }
}
