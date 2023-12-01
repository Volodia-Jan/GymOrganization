namespace GymOrganization.Domain.Exceptions;

/// <summary>
/// Represents API exception data
/// </summary>
public class ApiException
{
    /// <summary>
    /// Initialize <see cref="ApiException"/> class
    /// </summary>
    /// <param name="statusCode">Status code</param>
    /// <param name="message">Message</param>
    /// <param name="details">Details</param>
    public ApiException(int statusCode, string message, string details)
    {
        StatusCode = statusCode;
        Message = message;
        Details = details;
    }

    /// <summary>
    /// Gets or sets status code
    /// </summary>
    public int StatusCode { get; set; }
    
    /// <summary>
    /// Gets or sets message
    /// </summary>
    public string Message { get; set; }
    
    /// <summary>
    /// Gets or sets details
    /// </summary>
    public string Details { get; set; }
}