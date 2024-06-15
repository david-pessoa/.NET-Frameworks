using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            Bicicleta bike1 = new Bicicleta();
            //Veiculo ferrari = new Veiculo();

            Humano humani = new Humano();
            Pessoa David = new Pessoa();
            Homem Homi = new Homem();

            humani.Olho();
            David.Olho();
            Homi.Olho();
            humani.Cabelo();
            David.Cabelo();
            Homi.Cabelo();

        }
    }
}
