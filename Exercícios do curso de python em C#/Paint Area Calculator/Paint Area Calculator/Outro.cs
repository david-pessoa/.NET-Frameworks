using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_Area_Calculator
{
    internal class Outro
    {
        public void calc_cans(int height, int width, double cover)
        {
            int area = height * width;
            double cans = area / cover;
            double mod = cans % 1;
            if (mod != 0)
            {
                cans = cans - mod + 1;
            }
            if (cans == 1)
            {
                Console.WriteLine($"You will need 1 can");
            }
            else
            {
                Console.WriteLine($"You will need {cans} cans");
            }
        }
    }
}
