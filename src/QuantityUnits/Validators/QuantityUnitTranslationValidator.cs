using Avolutions.Baf.Domain.QuantityUnits.Models;
using FluentValidation;

namespace Avolutions.Baf.Domain.QuantityUnits.Validators;

public class QuantityUnitTranslationValidator : AbstractValidator<QuantityUnitTranslation>
{
    public QuantityUnitTranslationValidator()
    {
        RuleFor(x => x.Abbreviation)
            .NotEmpty()
            .WithName("field.abbreviation");
        
        // TODO: to base validator
        RuleFor(x => x.Value)
            .NotEmpty()
            .WithName("field.value");
    }
}