using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    internal class Primo
    {
        public string prime_checker(int num)
        {
            int mod;
            if (num == 0 || num == 1)
            {
                return "This number is not prime";
            }
            else if (num == 2)
            {
                return "This number is prime";
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    mod = num % i;
                    if (mod == 0)
                    {
                        return "This number is not prime";

                    }
                }
                return "This number is prime";
            }
        }
    }
}
