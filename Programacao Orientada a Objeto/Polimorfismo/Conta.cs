using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{   // A classe CaixaEletronico deve herdar todos os membros da interface IConta
    class CaixaEletronico : IConta
    {
        public string Usuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Depositar()
        {
            throw new NotImplementedException();
        }

        public void Sacar()
        {
            throw new NotImplementedException();
        }

        public void Saldo()
        {
            throw new NotImplementedException();
        }
    }

    interface IConta // Sempre usar "I" antes do nome para nomear uma interface
    {
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();

    }
}
