using Avolutions.Baf.Core.Lookups.Resources;
using Avolutions.Baf.Core.Lookups.Validators;
using Avolutions.Baf.Domain.QuantityUnits.Models;
using Avolutions.Baf.Domain.QuantityUnits.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.QuantityUnits.Validators;

public class QuantityUnitTranslationValidator : LookupTranslationValidator<QuantityUnitTranslation>
{
    public QuantityUnitTranslationValidator(
        IStringLocalizer<LookupResources> baseLocalizer,
        IStringLocalizer<QuantityUnitResources> localizer) : base(baseLocalizer)
    {
        RuleFor(x => x.Abbreviation)
            .NotEmpty()
            .WithName(localizer["Field.Abbreviation"]);
    }
}