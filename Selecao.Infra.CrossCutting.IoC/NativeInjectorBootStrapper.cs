using Microsoft.Extensions.DependencyInjection;
using Selecao.Application.Interfaces;

namespace Selecao.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<ICalculadorService, TipoAtendimentoService>();
            services.AddScoped<ILocalAtendimentoService, LocalAtendimentoService>();
        }
    }
}
