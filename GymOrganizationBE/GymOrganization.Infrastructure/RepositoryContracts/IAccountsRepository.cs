using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Infrastructure.RepositoryContracts;

/// <summary>
/// Represents accounts functionality
/// </summary>
public interface IAccountsRepository
{
    /// <summary>
    /// Login user into system
    /// </summary>
    /// <param name="login">User login</param>
    /// <param name="password">User password</param>
    /// <returns>Loged user</returns>
    Task<OperationResult<ApplicationUser>> LoginAsync(string login, string password);

    /// <summary>
    /// Logout user from system
    /// </summary>
    /// <returns></returns>
    Task<OperationResult<EmptyResult>> LogoutAsync();
}