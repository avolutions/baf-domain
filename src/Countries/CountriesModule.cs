using Avolutions.Baf.Core.Entity.Abstractions;
using Avolutions.Baf.Core.Module.Abstractions;
using Avolutions.Baf.Domain.Countries.Models;
using Avolutions.Baf.Domain.Countries.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Countries;

public class CountriesModule : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddScoped<CountryService>();
        services.AddScoped<ITranslatableEntityService<Country, CountryTranslation>, CountryService>();
    }
}