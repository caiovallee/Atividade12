using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12
{
    internal class traingulo
    {
        internal int y;
        internal int z;
        internal int x;

        internal string ReceberTexto()
        {
            string texto = "";
            if (x == y && x == z)
            {
                texto = "O triangulo é equilatero";
            }
            else
            {
                texto = "O triangulo não é equilatero";
            }
            return texto;
        }
    }
}
