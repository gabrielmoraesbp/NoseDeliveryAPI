using Microsoft.Extensions.DependencyInjection;
using NoseDelivery.Business.Interfaces;
using NoseDelivery.Business.Services;
using NoseDelivery.Data.Context;
using NoseDelivery.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoseDelivery.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDepedencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();

            //services.AddScoped<IPedidoService, PedidoService>();

            return services;
        }

    }
}
