using MePagaBack.Data;
using MePagaBack.Data.Repositories;
using MePagaBack.Data.Repositories.Interfaces;
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

    public static void AddRepositories(this WebApplicationBuilder builder) 
    {
        builder.Services.AddScoped<IDevedorRepository, DevedorRepository>();
        builder.Services.AddScoped<IDividaRepository, DividaRepository>();
    }

    public static void AddServices(this WebApplicationBuilder builder) 
    {

    }
}
