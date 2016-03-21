
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07._03._2016
{
    abstract class AnimalCu4Picioare : AnimalCuPicioare
    {

        private string nume;
        private int numarPicioare;
        private AreAripi aripi;

        public AreAripi areAripi
        {
            get
            {
                return aripi;
            }

            set
            {
                aripi = value;
            }
        }

        public int NrPicioare
        {
            get
            {
                return numarPicioare;
            }

            set
            {
                numarPicioare = value;
            }
        }

        public string Nume
        {
            get
            {
                return nume;
            }

            set
            {
                nume = value;
            }
        }

        public virtual string Descrie()
        {
            return "nu se stie prea mult despe acest anim cu 4 picioare";
        }
    }
}
