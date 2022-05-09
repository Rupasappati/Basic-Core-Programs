using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Programs
{
    public class EvenOrOdd
    {
        public void Even_Or_Odd()
        {
            int num1;
            int rem;
            Console.WriteLine("Please Enter a Input");
            num1=Convert.ToInt32(Console.ReadLine());
            rem = num1 % 2;
            if (rem == 0)
            {
                Console.WriteLine("The Entered Number is  Even_Num {0}", num1);
            }
            else
            {
                Console.WriteLine("The Entered Number is  Odd_Num {0}", num1);

            }
        }
    }
}
