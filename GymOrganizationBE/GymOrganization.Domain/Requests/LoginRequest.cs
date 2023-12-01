namespace GymOrganization.Domain.Requests;

/// <summary>
/// Represents login request data
/// </summary>
public class LoginRequest
{
    /// <summary>
    /// Gets or sets login
    /// </summary>
    public string Login { get; set; }
    
    /// <summary>
    /// Gets or sets password
    /// </summary>
    public string Password { get; set; }
}