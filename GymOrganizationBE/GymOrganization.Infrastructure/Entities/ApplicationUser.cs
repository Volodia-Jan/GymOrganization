using Microsoft.AspNetCore.Identity;

namespace GymOrganization.Infrastructure.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    /// <summary>
    /// Gets or sets First name
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Gets or sets Last name
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// Gets or sets Dte of birth
    /// </summary>
    public DateTime DateOfBirth { get; set; }
}