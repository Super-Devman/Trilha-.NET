using System;

namespace DesignPatternsWithDotNet.Infra.Singleton
{   
    // Classe sealed, significa que só existe uma de sua definição
    public sealed class Singleton
    {
        private static Singleton instance = null;
        // Essa classe vai gerar um novo Guid toda vez que for criada
        // Toda vez que essa classe for inicializada, receberá um novo Id
        public Guid Id { get; } = Guid.NewGuid();

        // Cria um construtor privado para que mais ninguém instancie uma nova versão desse Singleton
        private Singleton()
        {

        }

        // Pega a instância desse Singleton
        public static Singleton Instace
        {
            get
            {
                // Controla para que somente seja criado uma única instância desse Singleton
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
