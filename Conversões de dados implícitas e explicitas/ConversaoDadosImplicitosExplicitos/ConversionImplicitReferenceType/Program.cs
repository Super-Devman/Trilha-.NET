using System;

// Conversão implicita de ReferencedType (DerivedClass)
namespace ConversionImplicitReferenceType
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
            Masculino Raphael = new Masculino();
            Humano humano = Raphael;
        }
    }
}
