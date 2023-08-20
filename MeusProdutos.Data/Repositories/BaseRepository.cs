using MeusProdutos.Models.Interfaces.Repositories;
using MeusProdutos.Repositories.Context;

namespace MeusProdutos.Repositories.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly MeusProdutosContext? _context;

    public BaseRepository(MeusProdutosContext? context) => _context = context;

    public void Add(T entity) => _context?.Set<T>().Add(entity);
    public void Delete(T entity) => _context?.Set<T>().Remove(entity);
    public IEnumerable<T>? GetAll() => _context?.Set<T>();
    public T? GetById(int id) => _context?.Set<T>().Find(id);
    public void Update(T entity) => _context?.Update(entity);
}
