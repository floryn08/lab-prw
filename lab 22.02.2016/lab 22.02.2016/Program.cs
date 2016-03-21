using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_22._02._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            ColectiePersoane cp = new ColectiePersoane();
            ColectieStudenti cs = new ColectieStudenti();
            List<Persoana> lp = cp.ListaColectiePersoane();
            List<Student> ls = cs.listaColectieStudenti();

            Persoana p;
            Student s;


            //Persoana p1 = new Persoana("nume1", "prenume1", DateTime.Now);
            //Persoana p2 = new Persoana("nume2", "prenume2", DateTime.Now);
            //Persoana p3 = new Persoana("nume3", "prenume3", DateTime.Now);


            //
            ////citeste persoane
            p = CitesteOPersoana();
            cp.Adauga(p);

            Console.WriteLine("===================");

            p = CitesteOPersoana();
            cp.Adauga(p);

            Console.WriteLine("===================");

            p = CitesteOPersoana();
            cp.Adauga(p);

            Console.WriteLine("===================");

            ////
            //////afisare persoane
            //AfisareDateColectiePersoane(cp);

            //Console.WriteLine("===================");

            //
            ////citeste studenti
            s = CitesteUnStudent();
            cs.AdaugaStudent(s);

            Console.WriteLine("===================");

            s = CitesteUnStudent();
            cs.AdaugaStudent(s);

            Console.WriteLine("===================");




            //cp.Adauga(p1);
            //cp.Adauga(p2);
            //AfisareDateColectiePersoane(cp);
            //cp.Adauga(p3);

            //
            ////afiseaza datele persoanei






            ////
            //////ar trebui sa caute dupa CNP si sa afiseze persoana + CNP
            ////

            //Console.Write("Cauta CNP: ");
            //Persoana pGasita = cp.GasesteInFunctieDeCNP(Console.ReadLine());
            //if (pGasita != null)
            //{
            //    Console.WriteLine("S-a gasit: " + pGasita.NumeIntreg);
            //}
            //else
            //{
            //    Console.WriteLine("Nu s-a gasit");
            //}

            //Console.Write("Cauta nume: ");
            //var listPersGasite = cp.GasesteInFunctieDeNume(Console.ReadLine());

            //foreach (var item in listPersGasite)
            //{
            //    Console.WriteLine("S-a gasit: " + item.NumeIntreg);
            //}

            //
            ////https://msdn.microsoft.com/en-us/library/bb397905.aspx
            //

            var rez = from persoana in lp
                      join student in ls on persoana.CNP equals student.CNP
                      select new
                      {
                          persoana.NumeIntreg,
                          student.CNP,
                          student.Facultate,
                          student.Specializare,
                          student.NrGrupa,
                          student.AnStudiu
                      };

            foreach (var item in rez)
            {
                if (item.CNP != null)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("S-a gasit: " + item.NumeIntreg
                        + "\n          Student la: " + item.Facultate
                        + "\n          Specializarea: " + item.Specializare
                        + "\n          An: " + item.AnStudiu
                        + "\n          Grupa: " + item.NrGrupa);
                    Console.WriteLine("===================");
                }
                else
                {
                    Console.WriteLine("CNPul nu a fost gasit");
                }

            }

            Console.ReadKey();

        }

        private static void AfisareDateColectiePersoane(ColectiePersoane cp)
        {
            List<Persoana> lp = cp.ListaColectiePersoane();

            foreach (var item in lp)
            {
                Console.WriteLine("=================");
                Console.WriteLine("nume intreg: " + item.NumeIntreg
                    + "\ndata nasterii: " + item.DataNasterii
                    + "\nvarsta= " + item.Varsta
                    + "\nCNP: " + item.CNP);
                Console.WriteLine("=================");
            }

        }

        //private static void AfisareDateColectieStudenti(ColectieStudenti cs)
        //{
        //    List<Student> ls = cs.listaColectieStudenti();
        //    foreach (var item in ls)
        //    {
        //        Console.WriteLine("=================");
        //        Console.WriteLine("CNP student: " + item.CNP);
        //        Console.WriteLine("=================");
        //    }
        //}



        private static Persoana CitesteOPersoana()
        {
            Persoana pers = new Persoana();

            Console.Write("Nume: ");
            pers.Nume = Console.ReadLine();
            Console.Write("Preume: ");
            pers.Prenume = Console.ReadLine();
            Console.Write("Data nasterii: ");
            pers.DataNasterii = DateTime.Parse(Console.ReadLine());            //dd.mm.yyyy
            Console.Write("CNP: ");
            pers.CNP = Console.ReadLine();
            return pers;
        }

        private static Student CitesteUnStudent()
        {
            Student stud = new Student();

            Console.Write("CNP student: ");
            stud.CNP = Console.ReadLine();
            Console.Write("Facultate: ");
            stud.Facultate = Console.ReadLine();
            Console.Write("Specializare: ");
            stud.Specializare = Console.ReadLine();
            Console.Write("Grupa: ");
            stud.NrGrupa = int.Parse(Console.ReadLine());
            Console.Write("An studiu: ");
            stud.AnStudiu = int.Parse(Console.ReadLine());


            return stud;
        }








    }
}
