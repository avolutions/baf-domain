using Avolutions.Baf.Domain.AcademicTitles.Models;
using Avolutions.Baf.Domain.AcademicTitles.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.AcademicTitles.Validators;

public class AcademicTitleTranslationValidator : AbstractValidator<AcademicTitleTranslation>
{
    public AcademicTitleTranslationValidator(IStringLocalizer<AcademicTitleResources> localizer)
    {
        // TODO: to base validator
        RuleFor(x => x.Value)
            .NotEmpty()
            .WithName(localizer["Field.Value"]);
    }
}