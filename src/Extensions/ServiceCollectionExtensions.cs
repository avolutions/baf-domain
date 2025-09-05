using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBafDomain(this IServiceCollection services, params Assembly[] assemblies)
    {
        var assembly = typeof(AssemblyMarker).Assembly;
        
        services.AddValidatorsFromAssembly(assembly);
        
        return services;
    }
}