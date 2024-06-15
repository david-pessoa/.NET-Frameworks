using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Cliente = "David Pessoa";
            //Operação de Depósito
            float valor1 = 1000;
            conta.Deposito(valor1);

            //Operação de Saque
            float valor2 = 300;
            conta.Saque(valor2);

            //Resultado: Saldo Atual
            Console.WriteLine("Cliente: "+ conta.Cliente);
            Console.WriteLine("Saldo: "+conta.Saldo);

        }
    }
}
