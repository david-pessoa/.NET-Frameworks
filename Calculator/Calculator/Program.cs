using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            float first, next, memory, result;
            result = memory = 0;
            string operation, desire;
            Console.Write("Choose a number: ");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("%");
            Console.WriteLine("M");
            Console.WriteLine("M+");
            Console.WriteLine("CE");
            while (true)
            {
                Console.WriteLine("Choose a symbol: ");
                operation = Console.ReadLine();
            switch (operation)
            {
                case "M+":
                    memory = result;
                    Console.WriteLine("M = " + memory);
                    break;
                case "M":
                    result = memory;
                    Console.WriteLine("M = " + memory);
                    break;
                case "CE":
                    result = 0;
                    Console.WriteLine(" = 0");
                    break;
                default:
                    Console.Write("Choose the next number: ");
                    next = int.Parse(Console.ReadLine());
                        switch (operation)
                        {
                            case "+":
                                result = first + next;
                                Console.WriteLine(first + " + " + next + " = " + result);
                                break;

                            case "-":
                                result = first - next;
                                Console.WriteLine(first + " - " + next + " = " + result);
                                break;
                            case "*":
                                result = first * next;
                                Console.WriteLine(first + " * " + next + " = " + result);
                                break;
                                case "/":
                                    result = first / next;
                                    Console.WriteLine(first + " / " + next + " = " + result);
                                    break;
                                case "%":
                                    result = first % next;
                                    Console.WriteLine(first + " % " + next + " = " + result);
                                break;
                    }
               break;
            }
            first = result;
            Console.WriteLine("Do you want to continue calculating with " + result + "? Type 'continue', 'reset' or 'exit'");
            desire = Console.ReadLine();
            if (desire == "reset")
            {
                Console.Clear();
                goto Start;
            }
            if (desire == "exit")
            {
                break;
            }

                        

        
            }
        }
    }
}
