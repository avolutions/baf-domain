using Avolutions.Baf.Core.Lookups.Resources;
using Avolutions.Baf.Core.Lookups.Validators;
using Avolutions.Baf.Domain.AcademicTitles.Models;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.AcademicTitles.Validators;

public class AcademicTitleTranslationValidator
    : LookupTranslationValidator<AcademicTitleTranslation>
{
    public AcademicTitleTranslationValidator(IStringLocalizer<LookupResources> localizer) : base(localizer)
    {
    }
}