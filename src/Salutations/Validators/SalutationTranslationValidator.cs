using Avolutions.Baf.Core.Lookups.Resources;
using Avolutions.Baf.Core.Lookups.Validators;
using Avolutions.Baf.Domain.Salutations.Models;
using Avolutions.Baf.Domain.Salutations.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Salutations.Validators;

public class SalutationTranslationValidator : LookupTranslationValidator<SalutationTranslation>
{
    public SalutationTranslationValidator(
        IStringLocalizer<LookupResources> baseLocalizer,
        IStringLocalizer<SalutationResources> localizer) : base(baseLocalizer)
    {
        RuleFor(x => x.LetterSalutation)
            .NotEmpty()
            .WithName(localizer["Field.LetterSalutation"]);
    }
}