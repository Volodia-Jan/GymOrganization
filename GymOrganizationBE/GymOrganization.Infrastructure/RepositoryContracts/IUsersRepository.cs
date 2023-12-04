using System;
using System.Threading.Tasks;
using GymOrganization.Infrastructure.Entities;
using GymOrganization.Infrastructure.Results;

namespace GymOrganization.Infrastructure.RepositoryContracts;

/// <summary>
/// Represents users DAL functionality
/// </summary>
public interface IUsersRepository
{
    /// <summary>
    /// Updates user data
    /// </summary>
    /// <param name="applicationUser">Application user to update</param>
    /// <returns>Updated user data</returns>
    Task<OperationResult<ApplicationUser>> UpdateUserAsync(ApplicationUser applicationUser);

    /// <summary>
    /// Deletes user from system
    /// </summary>
    /// <param name="applicationUser">Application user to delete</param>
    /// <returns>True if user was deleted</returns>
    Task<OperationResult<EmptyResult>> DeleteUserAsync(ApplicationUser applicationUser);
    
    /// <summary>
    /// Creates users account
    /// </summary>
    /// <param name="applicationUser">Application user</param>
    /// <param name="password">Application user password</param>
    /// <returns>Created user or null if creating was unsuccessful</returns>
    Task<OperationResult<ApplicationUser>> CreateAsync(ApplicationUser applicationUser, string password);

    /// <summary>
    /// Adds user to specific role
    /// </summary>
    /// <param name="applicationUser">Application user</param>
    /// <param name="role">Role</param>
    /// <returns>Result of add to role operation</returns>
    Task<OperationResult<ApplicationUser>> AddToRoleAsync(ApplicationUser applicationUser, Role role);

    /// <summary>
    /// Gets user by its ID
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <returns>Result of gets operation</returns>
    Task<OperationResult<ApplicationUser>> GetUserByIdAsync(Guid userId);
}