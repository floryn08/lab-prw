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

        static string continut = string.Empty;

        static StreamReader sr = null;
        static StreamWriter sw = null;


        static void Main(string[] args)
        {
            DirectoryInfo di = null;

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

            //Console.WriteLine("Scriem in fisier ");

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

            //        
            //    }
            //}
            //catch (Exception ex)
            //{


            //    Console.WriteLine(ex.ToString());
            //}
            #endregion


            string numeDirector = Console.ReadLine();

            try
            {
                di = new DirectoryInfo(numeDirector);
                DirectoryInfo[] arrDir = di.GetDirectories();
                DirectoryInfo dirPrograms = new DirectoryInfo(numeDirector);
                FileInfo fi = new FileInfo(numeDirector);
                var primulDir = arrDir[0];

                Console.WriteLine("Enumerare directoare:");
                var dirs = from dir in primulDir.EnumerateDirectories()

                           select new
                           {
                               ProgDir = dir,
                           };



                //scriere continut in fisier

                try
                {
                    using (sw = new StreamWriter("output.txt"))
                    {
                        sw.Write(continut);
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                //afisareSubdirectoare(di, 0);



                //using (sw = new StreamWriter("output.txt"))
                //    {
                //        string linie = Console.ReadLine();
                //        while (linie != "exit")
                //        {
                //            sw.Write(linie + Environment.NewLine);
                //            linie = Console.ReadLine();
                //        }

                //        
                //    }


                Console.WriteLine("*********************");
                Console.WriteLine("Enumerare fisiere:");
                var files = from f in primulDir.EnumerateFiles()

                            select f;

                foreach (var f in files)
                {
                    Console.WriteLine("{0}", f.Name);
                }



                Console.WriteLine("*********************");
                Console.WriteLine("Nume complet: {0} \nData creatiei: {1}", di.FullName, di.CreationTime);
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

        static void afisareSubdirectoare(DirectoryInfo diDeAfisat, int nivel)
        {

            string listaFP = string.Empty;

            foreach (var f in diDeAfisat.GetDirectories())
            {

                string minusuri = null;
                for (int i = 0; i < nivel; i++)
                {
                    minusuri += "-";
                }

                //Console.WriteLine(minusuri + " " + f.Name);
                continut += minusuri + " " + f.Name + Environment.NewLine;

                foreach (var di in f.GetDirectories())
                {
                    listaFP += "dir: " + di.Name + Environment.NewLine;
                }


                try
                {
                    using (sw = new StreamWriter(f.FullName + Path.DirectorySeparatorChar + "xxx.txt"))
                    {
                        sw.Write(listaFP);
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                foreach (var fInfo in f.GetFiles())
                {
                    //Console.WriteLine(fInfo.Length + " " + fInfo.Name);
                    continut += ">>>" + fInfo.Name + Environment.NewLine;
                }


                afisareSubdirectoare(f, nivel + 1);
            }



        }



    }
}
