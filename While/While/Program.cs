using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "sim";
            while (resp == "sim")
            {
                int a = 2, b = 1, c, num;
                Console.WriteLine("Quantos números da sequência deseja mostrar?");
                num = int.Parse(Console.ReadLine());
                for (int i = 0; i < num; i++)
                {
                    if (i <= 1)
                    {
                        Console.Write(1);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(a);
                        Console.Write(" ");
                        c = a;
                        a += b;
                        b = c;
                    }

                }
                Console.WriteLine("\nDeseja continuar? Digite 'sim' ou 'não': ");
                resp = Console.ReadLine();
            }
            /*Console.Write(a);
            Console.Write(" ");
            Console.Write(b);
            while (b < 400)
            {
                Console.Write(" ");
                a += b;
                Console.Write(a);
                b += a;
                Console.Write(" ");
                Console.Write(b);
                

            }
            Console.WriteLine();
            */
        }
    }
}
