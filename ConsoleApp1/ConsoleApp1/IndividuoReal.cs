using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class IndividuoReal
    {
        CromosomaReal cromosomaReal;
        //constructor de IndividuoReal, recibe el # de variables a utilizar, rango [valorMinimo, valorMaximo], y el numero de particiones
        public IndividuoReal(int numVariables, int valorMinimo, int valorMaximo, int particiones)
        {
            cromosomaReal = new CromosomaReal(numVariables, valorMinimo, valorMaximo, particiones);
        }
        //representacion del cromosoma del individuo
        public override string ToString()
        {
            return cromosomaReal.ToString();
        }
    }
}
