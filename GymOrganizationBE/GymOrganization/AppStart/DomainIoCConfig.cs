using GymOrganization.Domain.ServiceContracts;
using GymOrganization.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

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
        
        // registering mappers
        services.AddAutoMapper(typeof(Domain.Mappers.GymOrganizationMapper).Assembly);
    }
}