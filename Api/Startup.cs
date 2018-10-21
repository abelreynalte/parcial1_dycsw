using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DyCswParcial1.Api.Common.Infrastructure.Persistence.NHibernate;
using AutoMapper;
using DyCswParcial1.Api.Productos.Domain.Repository;
using DyCswParcial1.Api.Productos.Infrastructure.Persistence.NHibernate.Repository;
using DyCswParcial1.Api.Productos.Application.Assembler;
using DyCswParcial1.Api.Common.Application;

namespace DyCswParcial1.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton(new SessionFactory(Environment.GetEnvironmentVariable("MSSQL_STRCON_PATTERNS")));
            var serviceProvider = services.BuildServiceProvider();
            var mapper = serviceProvider.GetService<IMapper>();
            services.AddSingleton(new ProductoAssembler(mapper));
            services.AddScoped<IUnitOfWork, UnitOfWorkNHibernate>();
            services.AddTransient<IProductoRepository, ProductoNHibernateRepository>((ctx) =>
            {
                IUnitOfWork unitOfWork = ctx.GetService<IUnitOfWork>();
                return new ProductoNHibernateRepository((UnitOfWorkNHibernate)unitOfWork);
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
