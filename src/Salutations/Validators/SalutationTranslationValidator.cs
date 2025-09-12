using Avolutions.Baf.Domain.Salutations.Models;
using Avolutions.Baf.Domain.Salutations.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Salutations.Validators;

public class SalutationTranslationValidator : AbstractValidator<SalutationTranslation>
{
    public SalutationTranslationValidator(IStringLocalizer<SalutationResources> localizer)
    {
        RuleFor(x => x.LetterSalutation)
            .NotEmpty()
            .WithName(localizer["Field.LetterSalutation"]);
        
        // TODO: to base validator
        RuleFor(x => x.Value)
            .NotEmpty()
            .WithName(localizer["Field.Value"]);
    }
}