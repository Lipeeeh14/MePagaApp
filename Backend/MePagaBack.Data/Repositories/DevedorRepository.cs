using MePagaBack.Data.Repositories.Interfaces;
using MePagaBack.Domain.Models;

namespace MePagaBack.Data.Repositories;

public class DevedorRepository(MePagaDbContext context) : BaseRepository<Devedor>(context), IDevedorRepository
{
}
