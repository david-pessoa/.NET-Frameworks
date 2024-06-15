using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo
    {
        public int VelocidadeMax { get; set; }
        public override void DeterminaVelocidade(int valor)
        {
            if (valor == 0)
            {
                Console.WriteLine("O carro está parado");
            }
            else
            {
                Console.WriteLine("O carro está a " + valor + "km/h");
            }
        }
        public void AbreJanela()
        {
            Console.WriteLine("A janela do carro está aberta");
        }
        public void FechaJanela()
        {
            Console.WriteLine("A janela do carro está fechada");
        }
    }
}
