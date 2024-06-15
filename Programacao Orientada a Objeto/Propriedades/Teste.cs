using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Teste
    {
        //Definição de um campo
        private string _nome;
        private int _idade;

        //Definição de uma propriedade
        public string Sobrenome { get; } = "Pessoa"; 
        //Não é possível atribuir valores para Sobrenome, essa propriedade não tem set.
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }
        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Não é possível inserir valores menores que 18 anos.");
                }
                else
                {
                    _idade = value;
                }
            }
        }
        public void Apresentar()
        {
            if (_nome != "")
            {
                Console.WriteLine("Bem vindo, " + _nome);
            }
        }
    }
}
