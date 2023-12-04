using GymOrganization.AppStart;
using GymOrganization.Middlewares;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDomain();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddJwtAuthorization(builder.Configuration);
builder.Services.AddSwagger();

var app = builder.Build();

app.UseExceptionHandlerMiddleware();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gym Organization API");
    c.RoutePrefix = string.Empty;
});
app.MapControllers();

app.Run();