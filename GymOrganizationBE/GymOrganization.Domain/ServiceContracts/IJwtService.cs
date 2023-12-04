using System;

namespace GymOrganization.Domain.ServiceContracts;

/// <summary>
/// Represents JWT functionality
/// </summary>
public interface IJwtService
{
    /// <summary>
    /// Generates user JWT token
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="email">Email ID</param>
    /// <param name="roleName">Role Name</param>
    /// <returns></returns>
    string GenerateJwt(Guid userId, string email, string roleName);
}