using DesignPatternsWithDotNet.Domain;
using DesignPatternsWithDotNet.Infra.Facade;
using DesignPatternsWithDotNet.Infra.Repository.Entity.Framework;
using DesignPatternsWithDotNet.Infra.Singleton;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsWithDotNet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // O IServiceCollection j� faz a Inje��o de depend�ncias no construtor abaixo
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // Define o Swagger para ser gerado no OpenApi v1
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "DesignPatternsWithDotNet",
                    Description = "API - Design Patterns",
                    Version = "v1"
                });
                // O path onde est� o xml que ser� gerado
                /* Aqui � a defini��o da API que far� a leitura desse arquivo para disponibilizar os
                 * conceitos necess�rio da API */
                var apiPath = Path.Combine(AppContext.BaseDirectory, "DesignPatternsWithDotNet.xml");
                c.IncludeXmlComments(apiPath);
            });

            services.AddTransient<IVeiculoRepository, FrotaRepository>();
            services.AddTransient<IVeiculoDetran, VeiculoDetranFacade>();

            // Add o servi�o do Singleton
            services.AddSingleton<SingletonContainer>();
            services.AddDbContext<FrotaContext>(opt =>
                                               opt.UseInMemoryDatabase("Frota"));

            services.AddHttpClient();

            services.Configure<DetranOptions>(Configuration.GetSection("DetranOptions"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Adiciona o Swagger
            app.UseSwagger();
            // E sua parte de visualiza��o (UI)
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API DesignPatternsWithDotNet");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
