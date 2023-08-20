using MeusProdutos.Models.DTOs.Update;
using MeusProdutos.Models.Entities;

namespace MeusProdutos.Models.Interfaces.Services;

public interface IProdutoService
{
    Produto? GetById(int id);
    IEnumerable<Produto>? GetAll();
    void Delete(int id);
    void Add(Produto produto);
    void Update(ProdutoUpdateDTO produtoUpdateDTO);
}
