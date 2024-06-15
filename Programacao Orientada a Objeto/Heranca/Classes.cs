using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Humano
    {
        public virtual void Olho()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelo()
        {
            Console.WriteLine("Humano.Cabelo");
        }
    }

    class Pessoa : Humano
    {
        public sealed override void Olho()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelo()
        {
            Console.WriteLine("Pessoa.Cabelo");
        }
    }

    class Homem : Pessoa
    {
        //public override void Olho()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}

        public override void Cabelo()
        {
            Console.WriteLine("Homem.Cabelo");
        }
    }
}
