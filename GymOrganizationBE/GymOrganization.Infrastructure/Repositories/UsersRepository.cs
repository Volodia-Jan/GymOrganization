using GymOrganization.Infrastructure.ApplicationDbContexts;
using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.RepositoryContracts;
using GymOrganization.Infrastructure.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GymOrganization.Infrastructure.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly GymOrganizationDbContext _dbContext;

    public UsersRepository(GymOrganizationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<OperationResult<ApplicationUser>> UpdateUserAsync(ApplicationUser applicationUser)
    {
        return await OperationResult<ApplicationUser>.Invoke(async () =>
        {
            _dbContext.Users.Update(applicationUser);
            await _dbContext.SaveChangesAsync();
            return applicationUser;
        });
    }

    public async Task<OperationResult<EmptyResult>> DeleteUserAsync(ApplicationUser applicationUser)
    {
        return await OperationResult<EmptyResult>.Invoke(async () =>
        {
            _dbContext.Users.Remove(applicationUser);
            await _dbContext.SaveChangesAsync();
            return new EmptyResult();
        });
    }

    public async Task<OperationResult<ApplicationUser>> CreateAsync(ApplicationUser applicationUser, string password)
    {
        return await OperationResult<ApplicationUser>.InvokeNotNull(async () =>
        {
            var result = await _dbContext.Users.AddAsync(applicationUser);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        });
    }

    public async Task<OperationResult<ApplicationUser>> AddToRoleAsync(Guid userId, Role role)
    {
        return await OperationResult<ApplicationUser>.InvokeNotNull(async () =>
        {
            var roleId = _dbContext.Roles.First(r => r.Name == role.ToString()).Id;
            await _dbContext.UserRoles.AddAsync(new IdentityUserRole<Guid>
            {
                UserId = userId,
                RoleId = roleId
            });

            await _dbContext.SaveChangesAsync();

            return await _dbContext.Users.FirstAsync(x => x.Id == userId);
        });
    }

    public async Task<OperationResult<ApplicationUser>> GetUserByIdAsync(Guid userId) =>
        await OperationResult<ApplicationUser>.InvokeNotNull(async () => await _dbContext.Users.FindAsync(userId));

    public async Task<OperationResult<ApplicationRole>> GetUserRoleByUserId(Guid userId) =>
        await OperationResult<ApplicationRole>.InvokeNotNull(async () =>
        {
            var userRole = await _dbContext.UserRoles.FirstAsync(x => x.UserId == userId);
            
            return await _dbContext.Roles.FirstAsync(x => x.Id == userRole.RoleId);
        });
}