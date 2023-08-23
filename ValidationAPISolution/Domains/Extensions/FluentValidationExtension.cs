using Application.Notifications;
using FluentValidation.Results;

namespace Domains.Extensions;

public static class FluentValidationExtension
{
    public static List<Notification>? GetErrors(this ValidationResult result) =>
        result.Errors?.Select(error => new Notification(error.PropertyName, error.ErrorMessage)).ToList();
}