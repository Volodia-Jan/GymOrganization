using System;
using System.Threading.Tasks;
using GymOrganization.Domain.DTOs;
using GymOrganization.Domain.Requests;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Domain.ServiceContracts;

/// <summary>
/// Represents users business logic
/// </summary>
public interface IUsersService
{
    /// <summary>
    /// Updates user 
    /// </summary>
    /// <param name="updateUserRequest">Update user request data</param>
    /// <returns>Result of update operation</returns>
    Task<OperationResult<UserDto>> UpdateUserAsync(UpdateUserRequest updateUserRequest);

    /// <summary>
    /// Deletes user by its ID
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <returns>Result or delete operations</returns>
    Task<OperationResult<EmptyResult>> DeleteUserAsync(Guid userId);
    
    /// <summary>
    /// Creates account
    /// </summary>
    /// <param name="createUserRequest">create user request data</param>
    /// <returns>Result of create user operation</returns>
    Task<OperationResult<UserDto>> CreateUserAccountAsync(CreateUserRequest createUserRequest);
}