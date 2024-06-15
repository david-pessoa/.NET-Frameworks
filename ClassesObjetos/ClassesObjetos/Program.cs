using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("David", "Pessoa", 2003);

            Console.WriteLine("Nome: " + pessoa1.nome);
            Console.WriteLine("Sobrenome: " + pessoa1.sobrenome);
            Console.WriteLine("Idade: " + pessoa1.idade);
            Console.WriteLine("Ano de nascimento: " + pessoa1.ano_nascimento);

            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Nome: " + pessoa2.nome);
            Console.WriteLine("Sobrenome: " + pessoa2.sobrenome);
            Console.WriteLine("Idade: " + pessoa2.idade);
            Console.WriteLine("Ano de nascimento: " + pessoa2.ano_nascimento);
        }
    }
}
