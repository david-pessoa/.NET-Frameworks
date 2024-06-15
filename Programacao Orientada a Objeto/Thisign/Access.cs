using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thisign
{
    internal class Access
    {
        string senha = "6431";
        public bool Acesso(string senha)
        {
            return this.senha == senha;
        }
    }
}
