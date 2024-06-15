using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heads_or_Tails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            bool bit = rand.Next(2) == 1;
            if (bit)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                Console.WriteLine("Tails");
            }
        }
    }
}
