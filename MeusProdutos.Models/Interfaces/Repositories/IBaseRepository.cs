namespace MeusProdutos.Models.Interfaces.Repositories;

public interface IBaseRepository<T> where T : class
{
    T? GetById(int id);
    IEnumerable<T>? GetAll();
    void Delete(T entity);
    void Add(T entity);
    void Update(T entity);
}
