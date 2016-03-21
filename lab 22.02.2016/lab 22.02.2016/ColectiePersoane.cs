using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_22._02._2016
{
    class ColectiePersoane
    {
        private static List<Persoana> listaPersoane;

        public ColectiePersoane()
        {
            if (listaPersoane == null)
            {
                listaPersoane = new List<Persoana>();
            }
        }

        public void Adauga(Persoana p)
        {
            listaPersoane.Add(p);
        }

        public List<Persoana> ListaColectiePersoane()
        {

            return listaPersoane;
        }



        public Persoana GasesteInFunctieDeCNP(string cnp)
        {
            Persoana p = null;

            p = (from persoana in listaPersoane
                 where persoana.CNP == cnp
                 select persoana).FirstOrDefault();

            return p;


            //
            //var longWords = words.Where(w => w.length > 10);
            //

            //string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
            ////Get only short words
            //var shortWords = from word in words         
            //                 where word.Length <= 5
            //                 select word;

            ////Print each word out
            //foreach (var word in shortWords)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadLine();



        }

        public List<Persoana> GasesteInFunctieDeNume(string nume)
        {

            var p = (from persoana in listaPersoane                  //persoana e range, poate fi numit oricum
                     where persoana.Nume.StartsWith(nume)
                     select persoana).ToList();

            return p;


            //foreach (Persoana p in listaPersoane)
            //{
            //    if (p.nume=base.nume)    
            //    {
            //        pGasita = p;
            //    }
            //}


        }

        //public Persoana GasesteInFunctieDeCNPStudent(string cnp)
        //{
        //    ColectieStudenti cs = null;
        //    List<Student> ls = cs.listaColectieStudenti();

        //    Student s = null;
        //    Persoana p = null;

        //    var rez = from persoana in listaPersoane
        //              join student in ls on persoana.CNP equals s.CNP into st
        //              select new { StudentName = persoana.NumeIntreg, Studenti = st };

        //    return rez;
        //}

    }
}
