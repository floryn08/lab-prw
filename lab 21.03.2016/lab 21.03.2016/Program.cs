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
            try
            {
                sr = new StreamReader("input.txt");

                int i = 1;
                string linie;
                linie = sr.ReadLine();
                while (linie != null)
                {
                    Console.WriteLine("linia {0}: {1}", i, linie);
                    linie = sr.ReadLine();
                    i++;
                }

                sr.Close();

            }



            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            Console.WriteLine("SCriemin fisier ");

            try
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    string linie = Console.ReadLine();
                    while (linie != "exit")
                    {
                        sw.Write(linie + Environment.NewLine);
                        linie = Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.ToString());
            }


            Console.ReadKey();
        }
    }
}
