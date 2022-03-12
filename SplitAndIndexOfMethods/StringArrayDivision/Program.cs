using System;

// Iterando os valores de um Array de Strings
namespace StringArrayDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "micro-ondas-micro-ondas-micro-ondas";
            string[] retornoSplit = texto.Split("-");
            int numeroElementos = retornoSplit.Length;

            for (int i = 0; i < numeroElementos; i++)
            {
                System.Console.WriteLine(String.Format("Posição " + i.ToString()
                + ": {0}\n", retornoSplit[i]));
            }
            Console.ReadKey();
        }
    }
}
