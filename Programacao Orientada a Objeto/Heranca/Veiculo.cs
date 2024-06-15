using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    abstract class Veiculo
    {
        private string _cor;
        private string _marca;
        private int _velocidade;
        public string Cor { get; set; }
        public string Marca { get; set; }
        public int Velocidade
        {
            get { return _velocidade; }
            private set
            {
                _velocidade = value;
            }
        }
        public abstract void DeterminaVelocidade(int valor);
    }
}
