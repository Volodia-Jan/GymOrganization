using System.Threading.Tasks;
using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.RepositoryContracts;
using GymOrganization.Infrastructure.Results;
using Microsoft.AspNetCore.Identity;

namespace GymOrganization.Infrastructure.Repositories;

public class AccountsRepository : IAccountsRepository
{
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountsRepository(SignInManager<ApplicationUser> signInManager)
    {
        _signInManager = signInManager;
    }

    public async Task<OperationResult<ApplicationUser>> LoginAsync(string login, string password)
    {
        var result = await _signInManager.PasswordSignInAsync(login, password, isPersistent: false, lockoutOnFailure: false);
        
        return result.Succeeded
            ? await OperationResult<ApplicationUser>.Invoke(async () => await _signInManager.UserManager.FindByEmailAsync(login))
            : OperationResult<ApplicationUser>.Fail("User login was unsuccessful");

    }

    public Task<OperationResult<EmptyResult>> LogoutAsync() =>
        OperationResult<EmptyResult>.Invoke(() => _signInManager.SignOutAsync());
}