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
        public String[] cruza_1_punto(IndividuoReal individuo, int puntoCruza) {
            String[] hijos = new String[2];
            String[] genesPadre = this.cromosomaReal.GetGenes();
            String[] genesMadre = individuo.cromosomaReal.GetGenes();
            for (int i = 0; i < genesPadre.Length && i < genesMadre.Length; i++) {
                hijos[0] = genesPadre[i].Substring(0, puntoCruza) + genesMadre[i].Substring(puntoCruza, genesMadre[i].Length - 1);
                hijos[1] = genesMadre[i].Substring(0, puntoCruza) + genesPadre[i].Substring(puntoCruza, genesPadre[i].Length - 1);
            }
            return hijos;
        }
    }
}
