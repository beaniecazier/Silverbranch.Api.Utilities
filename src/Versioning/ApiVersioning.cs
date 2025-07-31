using Asp.Versioning;
using Asp.Versioning.Builder;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Gay.Silverbranch.Api.Utilities.Common.Versioning;

public static class ApiVersioning
{
    public static ApiVersionSet? VersionSet { get; private set; }

    public static IEndpointRouteBuilder CreateApiVersionSet(this IEndpointRouteBuilder app, 
        IEnumerable<ApiVersion> availableVersions)
    {
        var builder = app.NewApiVersionSet();

        foreach(var version in availableVersions)
        {
            builder = builder.HasApiVersion(version);
        }

        VersionSet = builder.ReportApiVersions().Build();

        return app;
    }
}
