using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, kelvin, f;
            Console.WriteLine("Digite a escala de temperatura: ");
            string odiado = Console.ReadLine();
            Console.WriteLine("Digite o número da temperatura: ");
            double num = double.Parse(Console.ReadLine());

            if (odiado == "celsius")
            {
                f = 1.8 * num + 32;
                kelvin = num + 273;
                Console.WriteLine("A temperatura em Fahrenheit é :");
                Console.WriteLine(f);
                Console.WriteLine("A temperatura em Kelvin é :");
                Console.WriteLine(kelvin);
            }
            if (odiado == "kelvin")
            {
                celsius = num - 273;
                f = 1.8 * celsius + 32;
                Console.WriteLine("A temperatura em Fahrenheit é :");
                Console.WriteLine(f);
                Console.WriteLine("A temperatura em Celsius é :");
                Console.WriteLine(celsius);
            }
            if (odiado == "f")
            {
                celsius = (num - 32) * 5 / 9;
                kelvin = celsius + 273;
                Console.WriteLine("A temperatura em Kelvin é :");
                Console.WriteLine(kelvin);
                Console.WriteLine("A temperatura em Celsius é :");
                Console.WriteLine(celsius);
            }

        }
    }
}
