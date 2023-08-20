using MeusProdutos.Models.Entities;
using MeusProdutos.Models.Interfaces.Repositories;
using MeusProdutos.Repositories.Context;

namespace MeusProdutos.Repositories.Repositories;

public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
{
    public ProdutoRepository(MeusProdutosContext? context) : base(context)
    {
    }
}
