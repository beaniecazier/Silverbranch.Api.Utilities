using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gay.Silverbranch.API.Utilities.Common.Endpoints.Interfaces;

public interface IEndpoints
{
    public static abstract void DefineEndpoints(IEndpointRouteBuilder app);
    public static abstract void AddServices(IServiceCollection services, IConfiguration configuration);
}
