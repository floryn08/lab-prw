using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_15._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Persoana p = new Persoana("Ion", "Vasile");
                Console.WriteLine(p.nume);

                Persoana p2 = null;
                Console.WriteLine(p2.nume);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            //int n = 0;
            //int[] vct = new int[4];
            //try
            //{
            //    vct[0] = 100;
            //    vct[1] = 33;
            //    //vct[1] = 33 / n;
            //    vct[2] = 55;
            //    vct[3] = 66;

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(vct[i]);
            //    }
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e);
            //}
            //catch (DivideByZeroException d)
            //{
            //    Console.WriteLine(d);
            //}
            //catch (Exception x)
            //{
            //    Console.WriteLine(x);
            //}

            Console.ReadKey();


            #region
            //for (int i = 0; i < 22; i++)
            //{
            //    Console.WriteLine(i);


            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
