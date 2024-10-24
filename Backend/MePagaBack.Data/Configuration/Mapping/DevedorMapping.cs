using MePagaBack.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MePagaBack.Data.Configuration.Mapping;

public class DevedorMapping : IEntityTypeConfiguration<Devedor>
{
    public void Configure(EntityTypeBuilder<Devedor> builder)
    {
        throw new NotImplementedException();
    }
}
