using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Programs
{
    public class SwapNum
    {
        public void SwapTwoNum()
        {
            int num1;
            int num2;
            int temp;

            Console.WriteLine("Enter the First number :");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            
            Console.WriteLine("After Swapping First Number : {0}", num1);
            Console.WriteLine("After Swapping Second Number : {0}", num2);
            

        }
    }
}
