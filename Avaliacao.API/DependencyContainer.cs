using Avaliacao.API.Application.Interfaces;
using Avaliacao.API.Application.Services;
using Avaliacao.API.Data.Repositories;
using Avaliacao.API.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Avaliacao.API
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IPedidoService, PedidoService>();
           
            services.AddScoped<IClienteRepository, ClienteRepository>();            
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
           
        }
    }
}
