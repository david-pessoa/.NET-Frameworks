using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Matematica
    {
        public void Soma(float num1, float num2)
        {
            Console.WriteLine("A soma é: "+ (num1 + num2));
        }
        public void Subtracao(float num1, float num2)
        {
            Console.WriteLine("A diferença é: " + (num1 - num2));
        }
        public void Multiplicacao(float num1, float num2)
        {
            Console.WriteLine("O produto é: " + (num1 * num2));
        }
        public void Divisao(float num1, float num2)
        {
            Console.WriteLine("O quociente é: " + (num1 / num2));
        }
        
    }
    class BoasVindas
    {
        public void Cumprimento(string nome)
        {
            Console.WriteLine("Bem vindo, " + nome + "!");
        }
    }
}
