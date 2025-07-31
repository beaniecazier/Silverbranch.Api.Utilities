using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Gay.Silverbranch.Api.Utilities.Common.Extensions;

public static class RouteHandlerBuilderExtensions
{
    public static RouteHandlerBuilder Produces(this RouteHandlerBuilder builder,
        HttpStatusCode status,
        Type? responseType = null,
        string? contentType = null,
        params string[] additionalContentTypes)
    {
        return builder.Produces((int)status, responseType, contentType, additionalContentTypes);
    }

    public static RouteHandlerBuilder Produces<TResponse>(
        this RouteHandlerBuilder builder,
        HttpStatusCode statusCode = HttpStatusCode.OK,
        string? contentType = null,
        params string[] additionalContentTypes)
    {
        return builder.Produces(statusCode, typeof(TResponse), contentType, additionalContentTypes);
    }
}
