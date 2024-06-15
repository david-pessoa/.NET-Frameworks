using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Digite um número: ");
            valor = int.Parse(Console.ReadLine());
            if (valor < 0)
            {
                Console.WriteLine("Número negativo");
            }
            else if (valor < 5)
            {
                Console.WriteLine("Número entre 0 e 5");
            }
            else if (valor < 10)
            {
                Console.WriteLine("Número entre 5 e 10");
            }
            else
            {
                Console.WriteLine("Número maior ou igual a 10");
            }
        }

    }
}
