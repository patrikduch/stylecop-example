using Microsoft.Extensions.DependencyInjection;
using StyleCopExample.Application.Interfaces.Infrastructure;
using StyleCopExample.Infrastructure.Services;

namespace StyleCopExample.Infrastructure;

/// <summary>
/// Registration of infrastructure services.
/// </summary>
public static class InfrastructureServiceConfigurator
{
    /// <summary>
    /// Definition of service sets that are being used by Infrastructure project.
    /// </summary>
    /// <param name="services">Service collection fo Dependency Injection Container.</param>
    /// <returns>Collection of DI services.</returns>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IEmailService, EmailService>();

        return services;
    }
}
