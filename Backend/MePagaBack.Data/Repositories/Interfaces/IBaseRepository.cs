namespace MePagaBack.Data.Repositories.Interfaces;

public interface IBaseRepository<T> where T : class
{
    Task Create(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<T?> GetById(long id);
    Task<IEnumerable<T>> GetAll();
    Task SaveChangesAsync();
}
