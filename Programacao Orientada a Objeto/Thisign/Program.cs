using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Thisign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Access passar = new Access();
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();
            Console.WriteLine(passar.Acesso(senha));
        }
    }
}
