using System.Reflection;
using Avolutions.Baf.Core;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBafDomain(this IServiceCollection services, params Assembly[] assemblies)
    {
        var assembly = typeof(AssemblyMarker).Assembly;
        
        BafAssemblyRegistry.Register(assembly);
        services.AddValidatorsFromAssembly(assembly);
        
        return services;
    }
}