using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        #region Enum
        enum Notas
        {
            inicio = 10,
            meio = 20,
            fim = 30
        }
        #endregion
        #region Struct
        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
            
        }

        #endregion


        static void Main(string[] args)
        {
        Notas notas = Notas.inicio;
        Console.WriteLine(Notas.inicio); //deveria imprimir "10" e não "inicio"
        Console.ReadKey();

        Pessoa p1 = new Pessoa();
            p1.altura = 1.65;
            p1.idade = 35;
            p1.nome = "Gabriel";
            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                idade = 9,
                altura = 1.35
            };
           
            Console.WriteLine(p1.nome);        
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);
            Console.ReadKey();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);
            Console.ReadKey();

        }

    }
}
