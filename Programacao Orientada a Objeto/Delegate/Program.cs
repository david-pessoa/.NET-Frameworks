using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        delegate void Operacao(float num1, float num2);
        delegate void Function(string nome);
        
        static void Main(string[] args)
        {
            Matematica math = new Matematica();
            Console.Write("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());
            Operacao conta = math.Soma;
            conta += math.Subtracao;
            conta += math.Multiplicacao;
            conta += math.Divisao;
            conta += math.Subtracao;
            conta(num1, num2);
            BoasVindas boas_vindas = new BoasVindas();
            Function cumprimentar = boas_vindas.Cumprimento;
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            cumprimentar(nome);
        }
    }
}
