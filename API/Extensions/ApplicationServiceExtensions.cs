using Core.Interfaces;
using Infra.Data;
using Infra.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection service,
        IConfiguration config)
    {
        service.AddControllers();
        service.AddDbContext<DataContext>(options =>
        {
            options.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });
        service.AddCors();
        service.AddScoped<ITokenService, TokenService>();

        return service;
    }
}
