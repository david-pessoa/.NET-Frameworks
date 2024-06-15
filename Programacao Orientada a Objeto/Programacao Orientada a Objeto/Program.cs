using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_Orientada_a_Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Pessoa
            //MiClasse mivar = new MiClasse();
            //MiClasse otravar = null;

            //Pessoa p1 = new Pessoa();
            //p1.nome = "David";
            //p1.sobrenome = "Pessoa";
            //p1.anoNascimento = 2003;
            //Console.WriteLine(p1.nome);
            //Console.WriteLine(p1.sobrenome);
            //Console.WriteLine(p1.anoNascimento);
            //p1.Cumprimento();

            //Pessoa p2 = new Pessoa()
            //{
            //    nome = "Arthur",
            //    sobrenome = "Maciel",
            //    anoNascimento = 2011

            //};
            #endregion
            Metodos objeto = new Metodos();
            objeto.Cumprimentar();
            objeto.Soma(3, 5);
            objeto.Apresentar(19, "David");
        }
        class MiClasse
        {
           
        }

        class Pessoa
        {
            public string nome;
            public string sobrenome;
            public int anoNascimento;

            public void Cumprimento()
            {
                Console.WriteLine("Olá, eu sou "+ nome + " "+ sobrenome);
            }
        }
    }
}
