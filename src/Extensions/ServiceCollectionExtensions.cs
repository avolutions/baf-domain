using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBafDomain(this IServiceCollection services, params Assembly[] assemblies)
    {
        return services;
    }
}