using System;
using System.Collections.Generic;
using DesignPatternsWithDotNet.Domain;
using Microsoft.EntityFrameworkCore;

namespace DesignPatternsWithDotNet.Infra.Repository.Entity.Framework
{
    public class FrotaContext : DbContext
    {
        public FrotaContext(DbContextOptions<FrotaContext> options) : base(options)
        {

        }

        // Definição de Veiculos no Entity Framework
        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
