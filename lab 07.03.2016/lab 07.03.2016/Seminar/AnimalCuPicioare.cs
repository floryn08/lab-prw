using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    public enum AreAripi
    {
        Da,
        Nu
    }

    interface AnimalCuPicioare
    {
        int NrPicioare { get; set; }
        AreAripi areAripi { get; set; }
        string Nume { get; set; }
    }
}
