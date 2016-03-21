using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//cati studenti exista si in lista de persoane

namespace lab_22._02._2016
{
    class Student : Persoana
    {
        public string Specializare { get; set; }

        public string Facultate { get; set; }

        public int NrGrupa { get; set; }

        public int AnStudiu { get; set; }

        public Student() { }

        public Student(string nume, string prenume, string facultate, DateTime dataNastere, string specializare, int nrGrupa, int anStudiu, string cnp)
        {
            Specializare = specializare;
            Facultate = facultate;
            NrGrupa = nrGrupa;
            AnStudiu = anStudiu;

            base.Nume = nume;
            base.Prenume = prenume;
            base.DataNasterii = dataNastere;
            base.CNP = cnp;

        }

    }
}
