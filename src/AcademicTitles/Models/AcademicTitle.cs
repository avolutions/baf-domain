using Avolutions.Baf.Core.Lookups.Models;

namespace Avolutions.Baf.Domain.AcademicTitles.Models;

public class AcademicTitle : Lookup<AcademicTitleTranslation>
{
    public AcademicTitle() : base() { }
    public AcademicTitle(bool createMissingTranslations) : base(createMissingTranslations) { }
}