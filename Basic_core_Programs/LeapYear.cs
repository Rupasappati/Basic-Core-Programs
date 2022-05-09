using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Programs
{
    public class LeapYear
    {
        
        public void Leap_year()
        {
            int checkYear = 0;

            //User Input
            Console.WriteLine("Please enter a year : ");
            int checkyear = Convert.ToInt32(Console.ReadLine());

            //Passing the conditions
            if ((checkyear % 400) == 0)
            {
                Console.WriteLine("Leap year", checkYear);
            }            
            else if ((checkYear % 100) == 0)
            {
                Console.WriteLine("Not a leap year.", checkYear);
            }
            else if((checkyear % 4) == 0)
            {
                Console.WriteLine("Leap year.", checkYear);
            }
            else
                Console.WriteLine("Not a leap year.", checkYear);

        }
    }
}
