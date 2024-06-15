using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    partial class Pessoa
    {
        public void Apresentar()
        {
            Console.WriteLine("Olá, eu sou :" + nome);
        }
        public static int CalculaIdade(int ano_nascimento)
        {
            return DateTime.Now.Year - ano_nascimento;
        }
    }
}
