using MeusProdutos.Models.Interfaces.Repositories;
using MeusProdutos.Models.Interfaces.UnitOfWork;
using MeusProdutos.Repositories.Context;
using MeusProdutos.Repositories.Repositories;

namespace MeusProdutos.Repositories.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private IProdutoRepository? _produtoRepository;

    private readonly MeusProdutosContext _context;

    public UnitOfWork(MeusProdutosContext context) => _context = context;

    public IProdutoRepository ProdutoRepository => _produtoRepository ??= new ProdutoRepository(_context);

    public void Dispose() => _context.Dispose();

    public bool Save() => _context.SaveChanges() > 0;
}
