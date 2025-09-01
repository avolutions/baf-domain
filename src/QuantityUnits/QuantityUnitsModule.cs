using Avolutions.Baf.Core.Entity.Abstractions;
using Avolutions.Baf.Core.Module.Abstractions;
using Avolutions.Baf.Domain.QuantityUnits.Models;
using Avolutions.Baf.Domain.QuantityUnits.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.QuantityUnits;

public class QuantityUnitsModule : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddScoped<QuantityUnitService>();
        services.AddScoped<IEntityService<QuantityUnit>, QuantityUnitService>();
        services.AddScoped<ITranslatableEntityService<QuantityUnit, QuantityUnitTranslation>, QuantityUnitService>();
    }
}