using System;

namespace ConsoleApp1
{
    class Program
    {

         static void Main(string[] args)
        {
            int min = 0, Max = 0, P = 0, numVariables = 0;
            while (true)
            {
                Console.WriteLine("===Representación Real===");
                Console.WriteLine("Ingresa el numero de variables: ");
                numVariables = int.Parse(Console.ReadLine());
                Console.WriteLine("valor Min: ");
                min = int.Parse(Console.ReadLine());
                Console.WriteLine("valor Max: ");
                Max = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero de Particiones (P): ");
                P = int.Parse(Console.ReadLine());
                IndividuoReal individuo = new IndividuoReal(numVariables, min, Max, P);
                Console.WriteLine(individuo + "\n");
            }
        }
    }
}
