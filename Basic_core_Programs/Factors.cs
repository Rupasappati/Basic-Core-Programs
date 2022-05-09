using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Programs
{
    public class Factors
    {
    public void FactorsOfNum()
        {
            int N, x;
            Console.WriteLine("Please enter the Input: ");
            N =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors are : ");
            for (x = 1; x <= N; x++)
            {
                if (N % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            
        }
    }
}
