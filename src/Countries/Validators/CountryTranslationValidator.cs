using Avolutions.Baf.Domain.Countries.Models;
using Avolutions.Baf.Domain.Countries.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Countries.Validators;

public class CountryTranslationValidator : AbstractValidator<CountryTranslation>
{
    public CountryTranslationValidator(IStringLocalizer<CountryResources> localizer)
    {
        // TODO: to base validator
        RuleFor(x => x.Value)
            .NotEmpty()
            .WithName(localizer["field.value"]);
    }
}