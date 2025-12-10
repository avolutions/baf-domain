using Avolutions.Baf.Core.Lookups.Extensions;
using Avolutions.Baf.Core.Module.Abstractions;
using Avolutions.Baf.Domain.Salutations.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Salutations;

public class SalutationModule : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddLookup<Salutation>();
    }
}