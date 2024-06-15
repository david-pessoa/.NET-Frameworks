using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal static class Math
    {
        public static int taxa;
        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }
        public static int Subtrair(int valor)
        {
            return valor - taxa;
        }
    }
}
