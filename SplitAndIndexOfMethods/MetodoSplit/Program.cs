using System;

namespace MetodoSplit
{
    class Program
    {
        static void Main(string[] args)
        {
           string texto = "micro-ondas";
           // O Split é usado para dividir uma string em pequenos pedaços
           string[] retornoSplit = texto.Split("-");

           System.Console.WriteLine(String.Format("Posição 0: {0} \nPosição 1: {1}", retornoSplit[0], retornoSplit[1]));

           Console.ReadKey();
        }

        
    }
}
