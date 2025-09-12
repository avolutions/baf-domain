using Avolutions.Baf.Core.Entity.Models;

namespace Avolutions.Baf.Domain.AcademicTitles.Models;

public class AcademicTitle : TranslatableEntity<AcademicTitleTranslation>
{
    public AcademicTitle() : base() { }
    public AcademicTitle(bool createMissingTranslations) : base(createMissingTranslations) { }
}