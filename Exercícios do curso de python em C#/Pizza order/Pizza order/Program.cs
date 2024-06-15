using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Python Pizza delivery!");
            Console.Write("What size of pizza do you want? ");
            string size = Console.ReadLine().ToLower();
            Console.Write("Do you want pepperoni in your pizza? ");
            string pepperoni = Console.ReadLine().ToLower();
            Console.Write("Do you want extra cheese? ");
            string extra_cheese = Console.ReadLine().ToLower();
            int bill = 0;

            if (size == "small")
            {
                bill += 15;

                if (pepperoni == "yes")
                {
                    bill += 2;
                }
            }

            else if (size == "medium")
            {
                bill += 20;

                if (pepperoni == "yes")
                {
                    bill += 3;
                }

            }

            else
            {
                bill += 25;

                if (pepperoni == "yes")
                {
                    bill += 3;
                }

            }

            if (extra_cheese == "yes")
            {
                bill += 1;
            }

            Console.WriteLine("Your total bill is US$"+bill+".00");
        }
    }
}
