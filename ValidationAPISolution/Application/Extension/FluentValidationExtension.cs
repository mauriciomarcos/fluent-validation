using Application.Services.Bases;
using Domains.Interfaces.Services.Bases;
using FluentValidation.Results;

namespace Application.Extension;

public static class FluentValidationExtension
{
    public static List<INotification>? GetErrors(this ValidationResult result) =>
        result.Errors?.Select(error => new Notification(error.PropertyName, error.ErrorMessage)).ToList<INotification>();
}