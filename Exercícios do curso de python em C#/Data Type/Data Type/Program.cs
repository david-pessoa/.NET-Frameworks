using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            string input = Console.ReadLine();
            int num1 = int.Parse(Convert.ToString(input[0]));
            int num2 = int.Parse(Convert.ToString(input[1]));
            Console.WriteLine(num1 + num2);
        }
    }
}
