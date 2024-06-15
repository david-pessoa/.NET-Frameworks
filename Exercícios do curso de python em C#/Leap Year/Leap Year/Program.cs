using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int current_year = 1200; /*DateTime.Now.Year;*/

            if (current_year % 4 != 0)
            {
                Console.WriteLine(current_year + " is not a Leap Year");
            }

            else if (current_year % 4 == 0 && current_year % 100 != 0)
            {
                Console.WriteLine(current_year + " is a Leap Year!");
            }

            else if (current_year % 100 == 0 && current_year % 400 != 0)
            {
                Console.WriteLine(current_year + " is not a Leap Year");
            }

            else
            {
                Console.WriteLine(current_year + " is a Leap Year!");
            }
        }
    }
}
