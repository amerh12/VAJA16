using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga16Vaje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vpišite prvo številko:");
            int st1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vpišite drugo številko:");
            int st2 = Convert.ToInt32(Console.ReadLine());


            if (st1 < st2)
            {

                for (int stevec = st1+1; stevec <= st2-1; stevec++)
                {

                    Console.Write("{0}, ", stevec);

                }
            }
            else if (st2 < st1)
            {
                for (int stevec = st2+1; stevec <= st1-1; stevec++)
                {

                    Console.Write("{0}, ", stevec);

                }




            }
            else
            {
                Console.WriteLine("{0} in {1} sta enake številke", st1,st2);
            }


        }
    }
}
