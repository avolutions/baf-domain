using Avolutions.Baf.Core.Persistence.Extensions;
using Avolutions.Baf.Domain.QuantityUnits.Models;
using Avolutions.Baf.Domain.QuantityUnits.Services;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.QuantityUnits.Extensions;

public static class OptionsBuilderExtensions
{
    public static DbContextOptionsBuilder SeedQuantityUnits(this DbContextOptionsBuilder optionsBuilder)
    {
        return optionsBuilder.Seed<QuantityUnit, QuantityUnitSeedService>();
    }
}