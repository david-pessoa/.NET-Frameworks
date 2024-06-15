using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Conta
    {
        private string _cliente;
        private float _saldo;
        private float _taxa = 10;
        public string Cliente
        {
            get { return _cliente; }
            set
            {
                if (value != "David Pessoa")
                {
                    _cliente = "Visitante";
                }
                else
                {
                    _cliente = value;
                    Saldo = 0;
                }
            }
        }
        public float Saldo
        {
            get { return _saldo; }
            private set
            {
                _saldo = value;
            }
        }
        public void Saque(float valor)
        {
            valor += _taxa;
            _saldo -= valor;
        }
        public void Deposito(float valor)
        {
            _saldo += valor;
        }
    }
}
