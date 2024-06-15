using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodosDasClasses m = new MetodosDasClasses();
            //Console.WriteLine("Valor inicial: 90");
            //int valor1 = 90, valor2 = 90;
            //m.Add10(valor1);
            //m.Add10(valor1);
            //m.Addref10(ref valor2);
            //m.Addref10(ref valor2);
            //Console.WriteLine("Valor1: " + valor1);
            //Console.WriteLine("Valor2: " + valor2);
            //Console.ReadKey();
            //int code = m.ascii('a');
            //Console.WriteLine(code);
            //int code2 = Console.Read();
            //Console.WriteLine(code2);
            m.Cumprimentar();
            m.Cumprimentar(Console.ReadLine());
        }
    }
}