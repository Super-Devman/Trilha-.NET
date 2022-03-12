using System;

namespace DesignPatternsWithDotNet.Domain
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string AnoFabricante { get; set; }
    }
}
