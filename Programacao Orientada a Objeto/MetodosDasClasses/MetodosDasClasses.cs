using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class MetodosDasClasses
    {
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, Mundo!");
        }
        public void Add10(int num)
        {
            num += 10;
            Console.WriteLine("Passagem1 de parâmetro por valor: "+num);
        }
        public void Addref10(ref int numref)
        {
            numref += 10;
            Console.WriteLine("Passagem2 de parâmetro por referência: "+numref);
        }
        public int ascii(char letra)
        {
            int num = (int)letra;
            return num;
        }
        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá, "+nome);
        }
    }
}
