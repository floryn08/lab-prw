using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    class Caine : AnimalCu4Picioare
    {
        public override string Descrie()
        {
            string rez = base.Descrie();
            rez += "...am aflat ca e un caine";
            return rez;
        }
    }
}
