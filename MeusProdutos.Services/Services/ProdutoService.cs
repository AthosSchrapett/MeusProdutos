using MeusProdutos.Models.DTOs.Update;
using MeusProdutos.Models.Entities;
using MeusProdutos.Models.Interfaces.Services;
using MeusProdutos.Models.Interfaces.UnitOfWork;

namespace MeusProdutos.Services.Services;

public class ProdutoService : IProdutoService
{
    private readonly IUnitOfWork? _unitOfWork;

    public ProdutoService(IUnitOfWork? unitOfWork) =>
        _unitOfWork = unitOfWork;

    public void Add(Produto produto)
    {
        _unitOfWork?.ProdutoRepository?.Add(produto);
        _unitOfWork?.Save();
    }

    public void Delete(int id)
    {
        Produto? produto = GetById(id);

        _unitOfWork?.ProdutoRepository?.Delete(produto);
        _unitOfWork?.Save();
    }

    public IEnumerable<Produto>? GetAll() => _unitOfWork?.ProdutoRepository?.GetAll();
    public Produto? GetById(int id) => _unitOfWork?.ProdutoRepository?.GetById(id);
    public void Update(ProdutoUpdateDTO produtoUpdateDTO)
    {
        Produto? produto = GetById(produtoUpdateDTO.Id);

        produto?.Update(produtoUpdateDTO.Valor, produtoUpdateDTO.Descricao);

        _unitOfWork?.ProdutoRepository?.Update(produto);
        _unitOfWork?.Save();
    }
}
