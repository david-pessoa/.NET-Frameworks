using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculadora_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;
            Console.Write("Digite seu peso em kg: ");
            peso = float.Parse(Console.ReadLine());
            Console.Write("Digite sua altura em metros: ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura*altura);
            Console.WriteLine("Seu IMC é: "+imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso!");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Seu peso é o ideal");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Você possui sobrepeso.");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("Você é obeso!");
            }
            else
            {
                Console.WriteLine("Você possui obesidade mórbida!");
            }

        }
    }
}
