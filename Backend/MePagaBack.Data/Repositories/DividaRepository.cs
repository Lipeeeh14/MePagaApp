using MePagaBack.Domain.Models;
using MePagaBack.Domain.Repositories.Interfaces;

namespace MePagaBack.Data.Repositories;

public class DividaRepository(MePagaDbContext context) : BaseRepository<Divida>(context), IDividaRepository
{
}
