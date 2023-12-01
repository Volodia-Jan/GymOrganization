using GymOrganization.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymOrganization.Infrastructure.ApplicationDbContexts;

public class GymOrganizationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<ApplicationRole> Roles { get; set; }
    
    public GymOrganizationDbContext(DbContextOptions<GymOrganizationDbContext> options) : base(options) {}
}