using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    class Vaca : AnimalCu4Picioare
    {
        public bool AreCoarne
        {
            get { return true; }
        }

        public override string Descrie()
        {
            string rez = base.Descrie();

            rez += String.Format(" e vaca si AreCoarne={0}", AreCoarne);

            return rez;
        }
    }
}
