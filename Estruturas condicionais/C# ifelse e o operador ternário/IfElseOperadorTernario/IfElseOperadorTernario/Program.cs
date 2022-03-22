using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 8;
            if(media >= 7)
            {
                Console.WriteLine("Aluno aprovado!");
            } else if(media < 7 && media >= 5)
            {
                Console.WriteLine("Aluno em recuperação!");
            } else
            {
                Console.WriteLine("Aluno reprovado!");
            }
            
        }
    }
}
