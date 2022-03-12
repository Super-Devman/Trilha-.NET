using DesignPatternsWithDotNet.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace DesignPatternsWithDotNet.Infra.Repository.Entity.Framework
{
    public class FrotaRepository : IVeiculoRepository
    {
        private readonly FrotaContext context;

        public FrotaRepository(FrotaContext context)
        {
            this.context = context;
        }

        public void Add(Veiculo veiculo)
        {
            context.Veiculos.Add(veiculo);
            context.SaveChanges();
        }

        public void Delete(Veiculo veiculo)
        {
            context.Veiculos.Remove(veiculo);
            context.SaveChanges();
        }

        public IEnumerable<Veiculo> GetAll()
        {
            return context.Veiculos.ToListAsync().Result;
        }

        public Veiculo GetById(Guid id)
        {
            return context.Veiculos.SingleOrDefaultAsync().Result;
        }

        public void Update(Veiculo veiculo)
        {
            context.Entry(veiculo).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
