using GymOrganization.Infrastructure.Entities;

namespace GymOrganization.Domain.DTOs;

/// <summary>
/// Represents user DTO
/// </summary>
public class UserDto
{
    /// <summary>
    /// Gets or sets ID
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets first name
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets last name
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets email
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets date of birth
    /// </summary>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets age
    /// </summary>
    public int Age { get; set; }
    
    /// <summary>
    /// Gets or sets user role
    /// </summary>
    public string Role { get; set; }
    
    /// <summary>
    /// Gets or sets token
    /// </summary>
    public string Token { get; set; }
}