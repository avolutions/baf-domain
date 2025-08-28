using Avolutions.Baf.Domain.QuantityUnits.Models;
using Avolutions.Baf.Domain.QuantityUnits.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.QuantityUnits.Validators;

public class QuantityUnitTranslationValidator : AbstractValidator<QuantityUnitTranslation>
{
    public QuantityUnitTranslationValidator(IStringLocalizer<QuantityUnitResources> localizer)
    {
        RuleFor(x => x.Abbreviation)
            .NotEmpty()
            .WithName(localizer["field.abbreviation"]);
        
        // TODO: to base validator
        RuleFor(x => x.Value)
            .NotEmpty()
            .WithName(localizer["field.value"]);
    }
}