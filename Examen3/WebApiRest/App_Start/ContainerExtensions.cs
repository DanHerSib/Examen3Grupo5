using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using WBL;

namespace WebApiRest
{
    public static class ContainerExtension
    {
        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {
            services.AddSingleton<IDataAccess, DataAccess>();
            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<ICompraService, CompraService>();
            return services;
        }
    }
}
