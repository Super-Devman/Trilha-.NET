using System;

// Conversão implicita de Value Type
namespace ConversionTypeSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 10;
            short b = a;
            int c = b;
            long d = c;
            float e = d;
            double f = e;
            Console.WriteLine(f);
            Console.Read();
        }
    }
}
