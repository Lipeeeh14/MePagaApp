using MePagaBack.Data.Repositories.Interfaces;
using MePagaBack.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace MePagaBack.Data.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
{
    private readonly MePagaDbContext _context;

    public BaseRepository(MePagaDbContext context) => _context = context;

    public async Task Create(T entity) => await _context.AddAsync(entity);

    public async Task Update(T entity) => await Task.Run(() => _context.Update(entity));

    public async Task Delete(T entity) => await Task.Run(() => _context.Remove(entity));

    public async Task<IEnumerable<T>> GetAll() => await _context.Set<T>().ToListAsync();

    public async Task<T?> GetById(long id) => await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
