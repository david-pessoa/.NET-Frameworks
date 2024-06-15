using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;
        public int ano_nascimento;

        public Pessoa()
        {
            nome = "Zé";
            sobrenome = "Ninguém";
            idade = 999;
            ano_nascimento = 9999;
        }

        public Pessoa(string nome, string sobrenome, int ano_nascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.ano_nascimento = ano_nascimento;
            idade = Idade();
        }

        private int Idade()
        {
            return 2022 - ano_nascimento;
        }
    }
}
