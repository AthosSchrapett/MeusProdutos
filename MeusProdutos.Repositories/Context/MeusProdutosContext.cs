using MeusProdutos.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeusProdutos.Repositories.Context;

public class MeusProdutosContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    public MeusProdutosContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
