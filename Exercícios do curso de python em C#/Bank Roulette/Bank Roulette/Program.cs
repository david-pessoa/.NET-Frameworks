using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Roulette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            List<string> names = new List<string>();
            Console.WriteLine("Write the all participant's names: ");
            int participant = 0;
            while (true)
            {
                Console.Write($"Participant {participant+ 1} name: ");
                string real_name = Console.ReadLine();
                if (real_name == "")
                {
                    break;
                }
                else
                {
                    names.Add(real_name);
                    participant++;
                }
            }
            int chosen = rand.Next(participant);
            Console.WriteLine(names[chosen] + " will pay the bill!");

        }
    }
}
