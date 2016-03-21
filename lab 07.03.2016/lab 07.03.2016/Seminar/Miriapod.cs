
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    class Miriapod : AnimalCuMaiMultePicioare
    {
        public override string Descrie()
        {
            string rez = base.Descrie();
            rez += "...am aflat ca e un miriapod" + areAripi + Nume + NrPicioare;
            return rez;
        }
    }
}
