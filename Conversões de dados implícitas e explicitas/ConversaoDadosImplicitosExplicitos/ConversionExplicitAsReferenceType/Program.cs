using System;

// Conversão Explicita com as
namespace ConversionExplicitAsReferenceType
{
    class Humano
    {
        //Propriedades e Métodos
    }
    class Feminino : Humano
    {
        //Propriedades e Métodos
    }
    class Masculino : Humano
    {
        //Propriedades e Métodos
    }

    class Program
    {
        static void Main(string[] args)
        {
            Feminino Mulher = new Feminino();
            Humano SerHumano = Mulher;
            Feminino outraMulher = SerHumano as Feminino;
        }
    }
}
