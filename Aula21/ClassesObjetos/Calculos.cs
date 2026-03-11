using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Calculos
    {
        public double A;
        public double B;

        public void SomarSEMretorno()
        {
            double resultado = A + B;

        }

        public double SomarCOMretorno()
        {
            double resultado = A + B;
            return resultado;
        }
    }
}
