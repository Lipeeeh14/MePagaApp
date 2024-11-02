using MePagaBack.Data.Repositories.Interfaces;
using MePagaBack.Domain.Models;

namespace MePagaBack.Data.Repositories;

public class DividaRepository(MePagaDbContext context) : BaseRepository<Divida>(context), IDividaRepository
{
}
