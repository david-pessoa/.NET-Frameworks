using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_Orientada_a_Objeto
{
    internal class Metodos
    {
        public void Soma(int num1,int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, mundo!");
        }

        public void Apresentar(int num, string nome)
        {
            Console.WriteLine("Olá, sou " + nome + " e tenho " + num + " anos!");
        }
    }
}
