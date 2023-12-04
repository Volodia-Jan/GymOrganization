using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GymOrganization.Domain.Requests;

/// <summary>
/// Represents create user request data
/// </summary>
public class CreateUserRequest
{
    /// <summary>
    /// Gets or sets First name
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    public string FirstName { get; set; }
    
    /// <summary>
    /// Gets or sets Last name
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    public string LastName { get; set; }
    
    /// <summary>
    /// Gets or sets email
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [EmailAddress(ErrorMessage = "Invalid format of email addres")]
    public string Email { get; set; }
    
    /// <summary>
    /// Gets or sets date of birth
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets password
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets Confirm password
    /// </summary>
    [Required(ErrorMessage = "{0} field cannot be empty")]
    [DisplayName("Confirm password")]
    public string ConfirmPassword { get; set; }
}