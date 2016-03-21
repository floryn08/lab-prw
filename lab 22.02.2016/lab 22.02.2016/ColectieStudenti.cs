using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_22._02._2016
{


    class ColectieStudenti
    {
        private static List<Student> listaStudenti;

        public ColectieStudenti()
        {
            if (listaStudenti == null)
            {
                listaStudenti = new List<Student>();
            }
        }

        public List<Student> listaColectieStudenti()
        {
            return listaStudenti;
        }

        public void AdaugaStudent(Student s)
        {
            listaStudenti.Add(s);
        }

       


        }
}
