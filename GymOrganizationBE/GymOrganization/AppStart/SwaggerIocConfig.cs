using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace GymOrganization.AppStart;

public static class SwaggerIocConfig
{
    public static void AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Gym Organization API", Version = "v1" });
        });
    }
}