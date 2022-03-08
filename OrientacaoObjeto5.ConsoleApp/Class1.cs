using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto5.ConsoleApp
{
    internal class Esfera
    {
        public double raio;
        public double volume()
        {
            double ValorFinal = 4 * 3.14 * raio * raio* raio / 3;
            return ValorFinal;
        }
    }
}
