namespace GymOrganization.Domain.Requests;

/// <summary>
/// Represents update user request
/// </summary>
public class UpdateUserRequest
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
}