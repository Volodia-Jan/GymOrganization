using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace GymOrganization.AppStart;

public static class JwtIoCConfig
{
    /// <summary>
    /// Extension method to add JWT authorization
    /// </summary>
    /// <param name="services">Application services</param>
    /// <param name="configuration">Application configuration</param>
    public static void AddJwtAuthorization(this IServiceCollection services, IConfiguration configuration)
    {
        var jwtSection = configuration.GetSection("JWT");
        var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSection["Key"]));
        
        services.AddAuthorization();
        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = symmetricKey
                };
            });
    }
}