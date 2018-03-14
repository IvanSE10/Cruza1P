using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CromosomaReal
    {
        private GeneParticion[] genes;
        private int min, max, P, numGenes, size;
        private float dx;
        //Constructor de CromosomaReal, recibe el # de genes a utilizar, el rango [min,max], y el numero de particiones
        public CromosomaReal(int numGenes, int min, int max, int P)
        {
            this.numGenes = numGenes;
            this.min = min;
            this.max = max;
            this.P = P;

            size = (int)Math.Ceiling(Math.Log(P, 2)); // calculo de el tamaño de los Genes

            genes = new GeneParticion[numGenes]; // creacion del arreglo de genes, de tamaño numGenes

            dx = Math.Abs(min - max);
            dx = dx / P; // calculo del incremento

            initGenes();
        }
        //instancia #numGenes de tamaño size
        private void initGenes()
        {
            for (int i = 0; i < numGenes; i++)
            {
                genes[i] = new GeneParticion(size);
            }
        }
        //regresa el valor en representacion real del Gene
        private float GetValorReal(GeneParticion g)
        {
            return min + dx * g.GetDecimal();
        }
        //Representacion de el cromosoma [binario] [gray]: valorReal 
        public override string ToString()
        {
            string s = "Cromosomas:\n";
            for (int i = 0; i < numGenes; i++)
            {
                s += "[" + genes[i].GetGrey() + "]: " + GetValorReal(genes[i]) + "\n";
            }
            return s;
        }
        //Regresa el incremento
        public float GetIncremento()
        {
            return dx;
        }
    }
}
