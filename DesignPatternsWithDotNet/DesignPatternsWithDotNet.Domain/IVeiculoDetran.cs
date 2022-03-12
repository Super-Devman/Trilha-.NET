using System;
using System.Threading.Tasks;

namespace DesignPatternsWithDotNet.Domain
{
    public interface IVeiculoDetran
    {
        public Task AgendarVistoriaDetran(Guid VeiculoId);
    }
}
