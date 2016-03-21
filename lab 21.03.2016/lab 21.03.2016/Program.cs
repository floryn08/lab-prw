using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_21._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {


            StreamReader sr = null;
            StreamWriter sw = null;

            #region citire si scriere in fisier
            //try
            //{
            //    sr = new StreamReader("input.txt");

            //    int i = 1;
            //    string linie;
            //    linie = sr.ReadLine();
            //    while (linie != null)
            //    {
            //        Console.WriteLine("linia {0}: {1}", i, linie);
            //        linie = sr.ReadLine();
            //        i++;
            //    }

            //    sr.Close();

            //}



            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex);
            //}

            //Console.WriteLine("Scriemin fisier ");

            //try
            //{
            //    using (sw = new StreamWriter("output.txt"))
            //    {
            //        string linie = Console.ReadLine();
            //        while (linie != "exit")
            //        {
            //            sw.Write(linie + Environment.NewLine);
            //            linie = Console.ReadLine();
            //        }

            //        sw.Close();
            //    }
            //}
            //catch (Exception ex)
            //{


            //    Console.WriteLine(ex.ToString());
            //}
            #endregion


            DirectoryInfo di = null;

            string numeDirector = Console.ReadLine();

            try
            {
                DirectoryInfo dirPrograms = new DirectoryInfo(numeDirector);
                FileInfo fi = new FileInfo(numeDirector);
                di = new DirectoryInfo(numeDirector);

                Console.WriteLine("Enumerare directoare:");
                var dirs = from dir in dirPrograms.EnumerateDirectories()

                           select new
                           {
                               ProgDir = dir,
                           };

                foreach (var d in dirs)
                {
                    Console.WriteLine("{0}", d.ProgDir.Name);
                }
                Console.WriteLine("*********************");
                Console.WriteLine("Enumerare fisiere:");
                var files = from f in dirPrograms.EnumerateFiles()

                            select f;

                foreach (var f in files)
                {
                    Console.WriteLine("{0}", f.Name);
                }


                
                Console.WriteLine("*********************");


                Console.WriteLine("Nume complet: {0}, \nData creatiei: {1}", di.FullName, di.CreationTime);
                Console.WriteLine("Numarul de directoare: {0}", di.GetDirectories().Count());
                Console.WriteLine("Numarul de fisiere: {0}", di.GetFiles().Count());
                Console.WriteLine("Numarul de fisiere .zip: {0}", di.GetFiles("*.zip").Count());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            Console.ReadKey();
        }
    }
}
