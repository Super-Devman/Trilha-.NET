using System;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 8;
            string resultado = "Olá aluno, você foi ";
            resultado += media >= 7 ? "aprovado." : "reprovado";
            Console.WriteLine(resultado);
        }
    }
}
