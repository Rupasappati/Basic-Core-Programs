using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Programs
{
    public class HormonicNum
    {
        int i, n;
        double s=0.0d;

        public void Hormonic_Num()
        {

            Console.WriteLine("Please enter the input :");
            int n = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= n; i++)
            {

                Console.Write("1/{0} + ", i);
                s += 1/(float)i;
            }
            Console.WriteLine("Sum of Hormonic Series upto {0} terms {1}", n, s);
        }


    }
}
