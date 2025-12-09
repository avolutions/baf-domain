using Avolutions.Baf.Core.Lookups.Extensions;
using Avolutions.Baf.Core.Module.Abstractions;
using Avolutions.Baf.Domain.Countries.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Countries;

public class CountriesModule : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddLookup<Country>();
    }
}