using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Love_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Love Calculator!");
            Console.Write("Type your name: ");
            string my_name = Console.ReadLine().ToLower();
            Console.Write("Type your crush's name: ");
            string crush_name = Console.ReadLine().ToLower();
            int True = 0;
            int love = 0;

            foreach (char letter in my_name)
            {
                if ("true".Contains(letter))
                {
                    True++;
                }

                if ("love".Contains(letter))
                {
                    love++;
                }
            }

            foreach (char letter in crush_name)
            {
                if("true".Contains(letter))
                {
                    True++;
                }

                if("love".Contains(letter))
                {
                    love++;
                }
            }
            int score = int.Parse($"{True}{love}");
            Console.WriteLine(score);
        }
    }
}
