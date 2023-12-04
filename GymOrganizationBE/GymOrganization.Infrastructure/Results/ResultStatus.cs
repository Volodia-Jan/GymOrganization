using System.Text.Json.Serialization;

namespace GymOrganization.Infrastructure.Results;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ResultStatus
{
    Success,
    Failure,
    ValidationError,
    Exception
}