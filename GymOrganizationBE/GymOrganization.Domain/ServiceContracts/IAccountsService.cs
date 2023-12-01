using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.Requests;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Domain.ServiceContracts;

/// <summary>
/// Represents accounts business logic
/// </summary>
public interface IAccountsService
{
    /// <summary>
    /// Logins into system
    /// </summary>
    /// <param name="loginRequest">login request data</param>
    /// <returns>Result of user login operation</returns>
    Task<OperationResult<UserDto>> LoginAsync(LoginRequest loginRequest);

    /// <summary>
    /// Logouts from system
    /// </summary>
    /// <returns>Result of logout operation</returns>
    Task<OperationResult<EmptyResult>> LogoutAsync();
}