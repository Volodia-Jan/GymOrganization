using GymOrganization.Infrastructure.ApplicationDbContexts;
using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.RepositoryContracts;
using GymOrganization.Infrastructure.Results;
using Microsoft.AspNetCore.Identity;

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

    public async Task<OperationResult<ApplicationUser>> AddToRoleAsync(ApplicationUser applicationUser, Role role)
    {
        return await OperationResult<ApplicationUser>.InvokeNotNull(async () =>
        {
            var roleId = _dbContext.Roles.First(r => r.Name == role.ToString()).Id;
            await _dbContext.UserRoles.AddAsync(new IdentityUserRole<Guid>
            {
                UserId = applicationUser.Id,
                RoleId = roleId
            });

            await _dbContext.SaveChangesAsync();

            return applicationUser;
        });
    }

    public async Task<OperationResult<ApplicationUser>> GetUserByIdAsync(Guid userId) =>
        await OperationResult<ApplicationUser>.InvokeNotNull(async () => await _dbContext.Users.FindAsync(userId));
}
//todo delete this
// public class UsersRepository : IUsersRepository
    // {
    //     private readonly UserManager<ApplicationUser> _userManager;
    //
    //     public UsersRepository(UserManager<ApplicationUser> userManager)
    //     {
    //         _userManager = userManager;
    //     }
    //
    //     public async Task<OperationResult<ApplicationUser>> UpdateUserAsync(ApplicationUser applicationUser)
    //     {
    //         var result = await _userManager.UpdateAsync(applicationUser);
    //
    //         return result.Succeeded
    //             ? OperationResult<ApplicationUser>.Success(applicationUser)
    //             : OperationResult<ApplicationUser>.Fail("User updating was unsuccessful", applicationUser);
    //     }
    //
    //     public async Task<OperationResult<EmptyResult>> DeleteUserAsync(ApplicationUser applicationUser)
    //     {
    //         var result = await _userManager.DeleteAsync(applicationUser);
    //
    //         return result.Succeeded
    //             ? OperationResult<EmptyResult>.Success(new())
    //             : OperationResult<EmptyResult>.Fail("User deleting was unsuccessful");
    //     }
    //
    //     public async Task<OperationResult<ApplicationUser>> CreateAsync(ApplicationUser applicationUser, string password)
    //     {
    //         var result = await _userManager.CreateAsync(applicationUser, password);
    //
    //         return result.Succeeded
    //             ? OperationResult<ApplicationUser>.Success(applicationUser)
    //             : OperationResult<ApplicationUser>.Fail("User creating was unsuccessful", applicationUser);
    //     }
    //
    //     public async Task<OperationResult<ApplicationUser>> AddToRoleAsync(ApplicationUser applicationUser, Role role)
    //     {
    //         var result = await _userManager.AddToRoleAsync(applicationUser, role.ToString());
    //
    //         return result.Succeeded
    //             ? OperationResult<ApplicationUser>.Success(applicationUser)
    //             : OperationResult<ApplicationUser>.Fail($"Cannot add user to role: {role}", applicationUser);
    //     }
    //
    //     // public async Task<OperationResult<ApplicationUser>> GetUserByIdAsync(Guid userId)
    //     // {
    //     //     var result = await _userManager.FindByIdAsync(userId.ToString());
    //     //     
    //     //     return result.Succeeded
    //     //         ? OperationResult<ApplicationUser>.Success(applicationUser)
    //     //         : OperationResult<ApplicationUser>.Fail($"Cannot add user to role: {role}", applicationUser);
    //     // }
    // }