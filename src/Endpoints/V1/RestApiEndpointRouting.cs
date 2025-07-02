using Gay.Silverbranch.Api.Utilities.Endpoints;

namespace Gay.Silverbranch.API.Utilities.Common.Endpoints.V1;

public abstract class RestApiEndpointRouting
{
    public const string Tag = "-error-";
    public const string APIVersion = "-13";

    public static string EndpointPrefix = $"{StaticRoutingDefinitions.BaseSubdirectory}/{APIVersion}/{Tag}";

    protected static string _postEndpoint = EndpointPrefix;
    public static string Post => _postEndpoint;

    public static string GetById { get; } = $"{EndpointPrefix}/{{id}}";
    public virtual string GetAll { get; } = EndpointPrefix;

    public static string Put { get; } = $"{EndpointPrefix}/{{id}}";

    public static string Delete = $"{EndpointPrefix}/{{id}}";
}
