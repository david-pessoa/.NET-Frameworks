using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Forma
    {
        public virtual void Desenhar()
        {
            Console.WriteLine("Vou desenhar...");
        }
    }

    class Circulo : Forma
    {
        public void Circulos()
        {
            base.Desenhar();
            Console.WriteLine("Círculos");
            
        }
    }

}
