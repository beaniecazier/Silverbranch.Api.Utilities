using System.Reflection;
using Gay.Silverbranch.API.Utilities.Common.Endpoints.Interfaces;

namespace Gay.Silverbranch.API.Utilities.Common.Extensions;

public static class TypeInfoExtensions
{
    public static IEnumerable<TypeInfo> GetEndpointTypesFromAssemblyContaining(this Type typeMarker)
    {
        return typeMarker.Assembly.DefinedTypes
            .Where(x => !x.IsAbstract &&
                        !x.IsInterface &&
                        typeof(IEndpoints).IsAssignableFrom(x));
    }
    
    public static IEnumerable<TypeInfo> GetEndpointRoutingTypesFromAssemblyContaining(this Type typeMarker)
    {
        return typeMarker.Assembly.DefinedTypes
            .Where(x => !x.IsAbstract &&
                        !x.IsInterface &&
                        typeof(IEndpoints).IsAssignableFrom(x));
    }
}