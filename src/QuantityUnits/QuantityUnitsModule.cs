using Avolutions.Baf.Core.Lookups.Extensions;
using Avolutions.Baf.Core.Module.Abstractions;
using Avolutions.Baf.Domain.QuantityUnits.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.QuantityUnits;

public class QuantityUnitsModule : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddLookup<QuantityUnit>();
    }
}