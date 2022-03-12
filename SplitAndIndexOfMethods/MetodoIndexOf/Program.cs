using System;

namespace MetodoIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            /* IndexOf - serve para sabermos qual índice 
                determinado pedaço da string corresponde */
            string texto = "micro-ondas-micro-ondas-micro-ondas";
            int indice = texto.IndexOf("-");
            System.Console.WriteLine(indice);
        }
    }
}
