using Gay.Silverbranch.API.Utilities.Common.Endpoints.Interfaces;
using Gay.Silverbranch.API.Utilities.Common.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gay.Silverbranch.API.Utilities.Common.Endpoints.Extensions;

public static class EndpointExtensions
{
    public static void AddApplicationEndpoints<TMarker>(this IServiceCollection services, IConfiguration configuration)
    {
        AddApplicationEndpoints(services, typeof(TMarker), configuration);
    }

    public static void AddApplicationEndpoints(this IServiceCollection services, Type typeMarker, IConfiguration configuration)
    {
        var endpointTypes = typeMarker.GetEndpointTypesFromAssemblyContaining();
        
        foreach (var endpointType in endpointTypes)
        {
            endpointType.GetMethod(nameof(IEndpoints.AddServices))!
                        .Invoke(null, new object[] { services, configuration});
        }
    }

    public static void UseApplicationEndpoints<TMarker>(this IApplicationBuilder app)
    {
        UseApplicationEndpoints(app, typeof(TMarker));
    }

    public static void UseApplicationEndpoints(this IApplicationBuilder app, Type typeMarker)
    {
        var endpointTypes = typeMarker.GetEndpointTypesFromAssemblyContaining();
        
        foreach (var endpointType in endpointTypes)
        {
            endpointType.GetMethod(nameof(IEndpoints.DefineEndpoints))!
                        .Invoke(null, new object[] { app });
        }

    }
}
