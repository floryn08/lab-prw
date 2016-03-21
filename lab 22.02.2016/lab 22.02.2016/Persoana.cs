using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_22._02._2016
{
    class Persoana
    {
        public Persoana() { }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        //public string Prenume { get { return prenume; } set { prenume = value; } }

        private string cnp;

        public string CNP
        {
            get { return cnp; }
            set
            {
                cnp = value;

                if (cnp.Length >= 7)
                {
                    int an;
                    if (cnp.Substring(0, 1) == "1" || cnp.Substring(0, 1) == "2")
                        an = 1900;
                    else
                        an = 2000;

                    an = an + int.Parse(cnp.Substring(1, 2));

                    DataNasterii = new DateTime(an, int.Parse(cnp.Substring(3, 2)), int.Parse(cnp.Substring(5, 2)));
                }
            }
        }




        public string NumeIntreg
        {
            get { return Prenume + " " + Nume; }
        }

        public DateTime DataNasterii { get; set; }

        public int Varsta
        {
            get
            {
                int ret = 0;
                if (DataNasterii != null)
                {
                    ret = (DateTime.Now - DataNasterii).Days;

                    ret = ret / 365;
                }

                return ret;

            }
        }




        public Persoana(string nume, string prenume, DateTime dataNastere, string CNP)
        {
            Nume = nume;
            Prenume = prenume;
            DataNasterii = dataNastere;
            CNP = cnp;
        }







    }
}
