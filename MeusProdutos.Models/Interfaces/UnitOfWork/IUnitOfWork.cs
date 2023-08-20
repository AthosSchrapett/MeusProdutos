using MeusProdutos.Models.Interfaces.Repositories;

namespace MeusProdutos.Models.Interfaces.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IProdutoRepository? ProdutoRepository { get; }
    bool Save();
}
