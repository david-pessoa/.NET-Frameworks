using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new Teste();
            teste.Nome = "David";
            //teste.Sobrenome = "Pessoa"; Não é possível atribuir valores para Sobrenome, essa propriedade não tem set.
            teste.Idade = DateTime.Now.Year - 2003;
            Console.WriteLine("Nome: " + teste.Nome);
            Console.WriteLine("Sobrenome: " + teste.Sobrenome);
            Console.WriteLine("Idade: " + teste.Idade);
          
        }
    }
}
