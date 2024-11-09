using Microsoft.Extensions.DependencyInjection;

namespace StyleCopExample.Persistence;

/// <summary>
/// Registration of Persistence services.
/// </summary>
public static class PersistenceServiceConfigurator
{
    /// <summary>
    /// Definition of service sets that are being used by Infrastructure project.
    /// </summary>
    /// <param name="services">Service collection fo Dependency Injection Container.</param>
    /// <returns>Collection of DI services.</returns>
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        return services;
    }
}