using Avolutions.Baf.Core.Persistence.Extensions;
using Avolutions.Baf.Domain.Countries.Models;
using Avolutions.Baf.Domain.Countries.Services;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Countries.Extensions;

public static class OptionsBuilderExtensions
{
    public static DbContextOptionsBuilder SeedCountries(this DbContextOptionsBuilder optionsBuilder)
    {
        return optionsBuilder.Seed<Country, CountrySeedService>();
    }
}