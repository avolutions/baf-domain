using Avolutions.Baf.Core.Persistence.Extensions;
using Avolutions.Baf.Domain.Salutations.Models;
using Avolutions.Baf.Domain.Salutations.Services;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Salutations.Extensions;

public static class OptionsBuilderExtensions
{
    public static DbContextOptionsBuilder SeedSalutations(this DbContextOptionsBuilder optionsBuilder)
    {
        return optionsBuilder.Seed<Salutation, SalutationSeedService>();
    }
}