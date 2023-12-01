using GymOrganization.AppStart;
using GymOrganization.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDomain();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddJwtAuthorization(builder.Configuration);

var app = builder.Build();

app.UseExceptionHandlerMiddleware();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();