using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBafDomain(this IServiceCollection services, params Assembly[] assemblies)
    {
        services.AddValidatorsFromAssembly(typeof(AssemblyMarker).Assembly);
        
        return services;
    }
}