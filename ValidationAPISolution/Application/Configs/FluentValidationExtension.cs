using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Configs;

public static class FluentValidationConfig
{
    public static IServiceCollection AddFluentValidations(this IServiceCollection services, Type assemblyContainingValidators)
    {
        //services.AddFluentValidationAutoValidation(); //Enabling auto-validation only

        //services.AddScoped<IValidator<Aluno>, AlunoValidator>();

        services.AddFluentValidationClientsideAdapters(); // Enabling client validation only
        services.AddValidatorsFromAssemblyContaining(assemblyContainingValidators);

        return services;
    }
}