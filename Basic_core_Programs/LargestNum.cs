using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Programs
{
    public class LargestNum
    {
        public void Largest_Num()
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Please enter the 1st Number :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the 2nd Number :");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the 3rd Number :");
            z = Convert.ToInt32(Console.ReadLine());

            if((x > y) && (x > z))
            {
                Console.WriteLine("Laregest Number is {0} ", x);
            }
            else if((y > z) && (y > x))
            {
                Console.WriteLine("Largest Number is {0}", y);
            }
            else
            {
                Console.WriteLine("Largest Number is {0}", z);
            }
        
        }
    }
}
