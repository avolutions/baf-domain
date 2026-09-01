using Avolutions.Baf.Core.Lookups.Resources;
using Avolutions.Baf.Core.Lookups.Validators;
using Avolutions.Baf.Domain.Countries.Models;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Countries.Validators;

public class CountryTranslationValidator : LookupTranslationValidator<CountryTranslation>
{
    public CountryTranslationValidator(IStringLocalizer<LookupResources> localizer) : base(localizer)
    {
    }
}