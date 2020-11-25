using System;

namespace Exc7
{
    class Program
    {
        static void Main(string[] args)
        {
            {double[] numeros_digitados = new double[15];
            for (var i = 0; i <= 14; i++)      
                {Console.WriteLine();
                Console.WriteLine($"Escreva o {i+1}° número:\n ");
                numeros_digitados[i] = double.Parse(Console.ReadLine());}
                Console.WriteLine("Os números foram invertidos e ficaram assim:\n ");
            for (var i = 14; i >= 0; i--)
            {Console.WriteLine();
             Console.WriteLine(numeros_digitados[i]);}     
            }
        }
    }
}
