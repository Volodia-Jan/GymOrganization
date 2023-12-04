using System;

namespace GymOrganization.Domain.Extensions;

public static class DateTimeExtension
{
    public static int GetAge(this DateTime dateTime)
    {
        var today = DateTime.Today;
        var age = today.Year - dateTime.Year;

        if (dateTime.Date > today.AddYears(-age)) age--;

        return age;
    }
}