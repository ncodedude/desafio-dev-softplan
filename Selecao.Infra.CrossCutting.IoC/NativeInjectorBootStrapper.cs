using Microsoft.Extensions.DependencyInjection;
using Selecao.Application.Interfaces;
using Selecao.Application.Services;

namespace Selecao.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<ICalculadorService, CalculadorService>();
            services.AddScoped<ITaxaService, TaxaService>();
        }
    }
}
