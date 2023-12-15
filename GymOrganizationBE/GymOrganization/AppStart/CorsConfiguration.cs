namespace GymOrganization.AppStart;

public static class CorsConfiguration
{
    public static void DisableCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("Default", policy =>
            {
                policy.AllowAnyOrigin();
                policy.AllowAnyMethod();
                policy.AllowAnyHeader();
            });
        });
    }
}