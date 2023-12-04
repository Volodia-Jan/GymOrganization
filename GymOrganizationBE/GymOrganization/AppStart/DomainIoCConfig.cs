using GymOrganization.Domain.ServiceContracts;
using GymOrganization.Domain.Services;

namespace GymOrganization.AppStart;

public static class DomainIoCConfig
{
    public static void AddDomain(this IServiceCollection services)
    {
        services.AddControllers();
        // registering services
        services.AddScoped<IAccountsService, AccountsService>();
        services.AddScoped<IUsersService, UsersService>();
        services.AddScoped<IJwtService, JwtService>();
        services.AddScoped<ICatalogService, CatalogService>();
        
        // registering mappers
        services.AddAutoMapper(typeof(Domain.Mappers.GymOrganizationMapper).Assembly);
    }
}