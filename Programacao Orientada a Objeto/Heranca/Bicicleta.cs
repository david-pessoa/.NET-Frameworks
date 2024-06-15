using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal sealed class Bicicleta : Veiculo
    {
        public override void DeterminaVelocidade(int valor)
        {
            if (valor == 0)
            {
                Console.WriteLine("A bicicleta está parada");
            }
            else
            {
                Console.WriteLine("A bicicleta está a " + valor + "km/h");
            }
        }
        public void Sininho()
        {
            Console.WriteLine("O sininho da bicicleta está tocando");
        }
    }
}
