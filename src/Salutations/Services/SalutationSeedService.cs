using Avolutions.Baf.Core.Persistence.Services;
using Avolutions.Baf.Domain.Salutations.Models;
using Avolutions.Baf.Domain.Salutations.Seed;

namespace Avolutions.Baf.Domain.Salutations.Services;

public sealed class SalutationSeedService : SeedService<Salutation>
{
    protected override IEnumerable<Salutation> Data => SalutationSeedData.Salutations;
}