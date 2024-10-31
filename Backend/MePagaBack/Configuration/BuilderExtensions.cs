using MePagaBack.Data;
using Microsoft.EntityFrameworkCore;

namespace MePagaBack.API.Configuration;

public static class BuilderExtensions
{
    public static void AddDataContext(this WebApplicationBuilder builder)
    {
        builder
            .Services
            .AddDbContext<MePagaDbContext>(x => 
            { 
                x.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]); 
            });
    }
}
