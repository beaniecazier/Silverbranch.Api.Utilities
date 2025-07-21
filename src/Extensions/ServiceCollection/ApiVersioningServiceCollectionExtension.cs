using Asp.Versioning;
using Microsoft.Extensions.DependencyInjection;

namespace Gay.Silverbranch.Api.Utilities.Common.Extensions.ServiceCollection;

#pragma warning disable CS1591

public static class ApiVersioningServiceCollectionExtension
{
    public static IServiceCollection AddApiVersioningSettings(this IServiceCollection services, ApiVersion defaultVersion)
    {
        services.AddApiVersioning(x =>
        {
            x.DefaultApiVersion = defaultVersion;
            x.AssumeDefaultVersionWhenUnspecified = true;
            x.ReportApiVersions = true;
            x.ApiVersionReader = new MediaTypeApiVersionReader("api-version");
        }).AddApiExplorer();
        services.AddEndpointsApiExplorer();
        return services;
    }
}

#pragma warning restore CS1591