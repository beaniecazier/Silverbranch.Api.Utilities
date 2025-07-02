using Gay.Silverbranch.Api.Utilities.Endpoints.V1.Health;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Gay.Silverbranch.API.Utilities.Common.Extensions.ServiceCollection;

#pragma warning disable CS1591

public static class HealthCheckServiceColletcionExtension 
{
    public static IServiceCollection AddHealthCheckServicesBackend<T>(this IServiceCollection services) where T : DbContext
    {
        services.AddSingleton<StartupCheckEndpoint>();
        services.AddSingleton<ReadinessCheckEndpoint>();
        services.AddSingleton<LivenessCheckEndpoint>();

        services.AddHealthChecks()
                .AddDbContextCheck<T>()
                .AddCheck<StartupCheckEndpoint>(StartupCheckEndpoint.Tag, tags: new[] { StartupCheckEndpoint.Tag })
                .AddCheck<ReadinessCheckEndpoint>(ReadinessCheckEndpoint.Tag, tags: new[] { ReadinessCheckEndpoint.Tag })
                .AddCheck<LivenessCheckEndpoint>(LivenessCheckEndpoint.Tag, tags: new[] { LivenessCheckEndpoint.Tag });
        return services;
    }
    
    public static IServiceCollection AddHealthCheckServicesFrontend(this IServiceCollection services)
    {
        services.AddSingleton<StartupCheckEndpoint>();
        services.AddSingleton<ReadinessCheckEndpoint>();
        services.AddSingleton<LivenessCheckEndpoint>();

        services.AddHealthChecks()
            .AddCheck<StartupCheckEndpoint>(StartupCheckEndpoint.Tag, tags: new[] { StartupCheckEndpoint.Tag })
            .AddCheck<ReadinessCheckEndpoint>(ReadinessCheckEndpoint.Tag, tags: new[] { ReadinessCheckEndpoint.Tag })
            .AddCheck<LivenessCheckEndpoint>(LivenessCheckEndpoint.Tag, tags: new[] { LivenessCheckEndpoint.Tag });
        return services;
    }
}

#pragma warning restore CS1591