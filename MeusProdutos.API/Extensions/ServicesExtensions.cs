using MeusProdutos.Models.Interfaces.Services;
using MeusProdutos.Models.Interfaces.UnitOfWork;
using MeusProdutos.Repositories.UnitOfWork;
using MeusProdutos.Services.Services;

namespace MeusProdutos.API.Extensions;

public static class ServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IProdutoService, ProdutoService>();

        return services;
    }
}
