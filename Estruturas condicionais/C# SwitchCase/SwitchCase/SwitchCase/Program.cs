using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes = "Dezembro";
            switch (mes)
            {
                case "Janeiro":
                case "Março":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    Console.WriteLine("Este mês tem 31 dias");
                    break;
                case "Fevereiro":
                    Console.WriteLine("Este mês tem 28 ou 29 dias");
                    break;
                default:
                    Console.WriteLine("Este mês tem 30 dias");
                    break;

            }
        }
    }
}
