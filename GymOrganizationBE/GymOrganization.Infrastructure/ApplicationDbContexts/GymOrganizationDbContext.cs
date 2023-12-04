using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using GymOrganization.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymOrganization.Infrastructure.ApplicationDbContexts;

public class GymOrganizationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<ApplicationRole> Roles { get; set; }
    
    public GymOrganizationDbContext(DbContextOptions<GymOrganizationDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        var usersSeed = GetUsersSeed("Seeds/usersSeed.json");
        var rolesSeed = GetRoles("Seeds/rolesSeed.json");
        var usersRolesSeed = GetSeedData<List<IdentityUserRole<Guid>>>("Seeds/users-role.json");
        
        builder.Entity<ApplicationUser>().HasData(usersSeed);
        builder.Entity<ApplicationRole>().HasData(rolesSeed);
        builder.Entity<IdentityUserRole<Guid>>().HasData(usersRolesSeed);
    }

    private List<ApplicationUser> GetUsersSeed(string fileName)
    {
        var users = GetSeedData<List<ApplicationUser>>(fileName);
        foreach (var user in users)
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            user.NormalizedUserName = user.UserName.ToUpper();
            user.NormalizedEmail = user.Email.ToUpper();
            user.SecurityStamp = Guid.NewGuid().ToString("D");
            user.PasswordHash = passwordHasher.HashPassword(user, user.PasswordHash);
        }

        return users;
    }

    private List<ApplicationRole> GetRoles(string fileName)
    {
        var roles = GetSeedData<List<ApplicationRole>>(fileName);
        foreach (var role in roles)
            role.NormalizedName = role.Name.ToUpper();

        return roles;
    }

    private T GetSeedData<T>(string fileName) where T : class, new()
    {
        T? seed;
        using (StreamReader reader = new(fileName))
        {
            var json = reader.ReadToEnd();
            seed = JsonSerializer.Deserialize<T>(json);
        }

        return seed ?? new T();
    }
}