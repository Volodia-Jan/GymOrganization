using GymOrganization.Infrastructure.ApplicationDbContexts;
using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.Repositories;
using GymOrganization.Infrastructure.RepositoryContracts;
using Microsoft.EntityFrameworkCore;

namespace GymOrganization.AppStart;

public static class InfrastructureIoCConfig
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IAccountsRepository, AccountsRepository>();
        services.AddScoped<IUsersRepository, UsersRepository>();
        services.AddScoped<ICatalogRepository, CatalogRepository>();
        
        services.AddDbContext<GymOrganizationDbContext>(opt =>
        {
            opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });

        services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
            })
            .AddEntityFrameworkStores<GymOrganizationDbContext>();
    }
}