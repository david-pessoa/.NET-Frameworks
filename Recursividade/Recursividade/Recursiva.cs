using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    static class Recursiva
    {
        public static void Executar(int n)
        {
            if (n == 0)
                return;
            Console.WriteLine("Olá mundo!");
            Executar(n - 1);
        }
        public static void Cria(string palavra)
        {
            Console.WriteLine(palavra);
        }
    }
}
