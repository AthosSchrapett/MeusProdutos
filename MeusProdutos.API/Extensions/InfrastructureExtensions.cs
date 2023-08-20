using MeusProdutos.Repositories.Context;
using Microsoft.EntityFrameworkCore;

namespace MeusProdutos.API.Extensions
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MeusProdutosContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("MeusProdutosConnection"),
                    b => b.MigrationsAssembly(typeof(MeusProdutosContext).Assembly.FullName))
                );

            return services;
        }
    }
}
