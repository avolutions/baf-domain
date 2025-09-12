using Avolutions.Baf.Core.Persistence.Services;
using Avolutions.Baf.Domain.AcademicTitles.Models;
using Avolutions.Baf.Domain.AcademicTitles.Seed;

namespace Avolutions.Baf.Domain.AcademicTitles.Services;

public sealed class AcademicTitleSeedService : SeedService<AcademicTitle>
{
    protected override IEnumerable<AcademicTitle> Data => AcademicTitleSeedData.AcademicTitles;
}