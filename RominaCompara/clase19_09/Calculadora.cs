using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase19_09
{
    public class Calculadora
    {
        double primerOperando;
        double segundoOperando;
        string operacion;

        public Calculadora(double n1, double n2)
        {
            this.primerOperando = n1;
            this.segundoOperando = n2;
          
        }
        public double Sumar() 
        {
            double sum = this.primerOperando + this.segundoOperando;
            return sum;
        }
    }
}
