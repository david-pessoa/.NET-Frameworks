using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classe Estática
            Math.taxa = 10;
            Console.WriteLine("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            int soma = Math.Adicionar(valor);
            int diferenca = Math.Subtrair(valor);
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Diferença: " + diferenca);
            #endregion

            Pessoa.maioridade = 21;
            Pessoa pessoa1 = new Pessoa();
            Console.Write("Digite seu nome: ");
            pessoa1.nome = Console.ReadLine();
            pessoa1.Apresentar();
            Console.Write("Digite seu ano de nascimento: ");
            Console.WriteLine(Pessoa.CalculaIdade(int.Parse(Console.ReadLine())));
            

        }
    }
}
