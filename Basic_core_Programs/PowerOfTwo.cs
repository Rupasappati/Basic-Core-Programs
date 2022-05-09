using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Programs
{
    public class PowerOfTwo
    {
        public void Power_Of_Two()
        {
            int N;
            int baseNum = 0;
            int result;

            Console.WriteLine("Please enter a exponent : ");
            N = Convert.ToInt32(Console.ReadLine());

            //condition the N value Should be the range in 0 to 31
            
            if (0 <= N && N <= 31)
            {

                for (int i = 0; i <= N; i++)
                {


                    if (i == 0)
                    {
                        baseNum = 1;

                    }
                    else
                    {
                        baseNum = baseNum * 2;
                    }

                    Console.WriteLine("2^{0} = {1}", i, baseNum);
                }
            }
        }
    }
}




