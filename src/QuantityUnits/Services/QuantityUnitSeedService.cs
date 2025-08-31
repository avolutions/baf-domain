using Avolutions.Baf.Core.Persistence.Services;
using Avolutions.Baf.Domain.QuantityUnits.Models;
using Avolutions.Baf.Domain.QuantityUnits.Seed;

namespace Avolutions.Baf.Domain.QuantityUnits.Services;

public sealed class QuantityUnitSeedService : SeedService<QuantityUnit>
{
    protected override IEnumerable<QuantityUnit> Data => QuantityUnitSeedData.QuantityUnits;
}