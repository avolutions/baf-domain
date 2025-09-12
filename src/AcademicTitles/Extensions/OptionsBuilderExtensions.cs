using Avolutions.Baf.Core.Persistence.Extensions;
using Avolutions.Baf.Domain.AcademicTitles.Models;
using Avolutions.Baf.Domain.AcademicTitles.Services;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.AcademicTitles.Extensions;

public static class OptionsBuilderExtensions
{
    public static DbContextOptionsBuilder SeedAcademicTitles(this DbContextOptionsBuilder optionsBuilder)
    {
        return optionsBuilder.Seed<AcademicTitle, AcademicTitleSeedService>();
    }
}