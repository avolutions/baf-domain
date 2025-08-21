using Avolutions.Baf.Core.Persistence.Services;
using Avolutions.Baf.Domain.Countries.Models;
using Avolutions.Baf.Domain.Countries.Seed;

namespace Avolutions.Baf.Domain.Countries.Services;

public sealed class CountrySeedService : SeedService<Country>
{
    protected override IEnumerable<Country> Data => CountrySeedData.Countries;
}