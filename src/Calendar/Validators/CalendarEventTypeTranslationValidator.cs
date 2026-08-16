using Avolutions.Baf.Domain.Calendar.Models;
using Avolutions.Baf.Domain.Calendar.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Calendar.Validators;

public class CalendarEventTypeTranslationValidator : AbstractValidator<CalendarEventTypeTranslation>
{
    public CalendarEventTypeTranslationValidator(IStringLocalizer<CalendarEventTypeResources> localizer)
    {
        // TODO: to base validator
        RuleFor(x => x.Value)
            .NotEmpty()
            .WithName(localizer["Field.Value"]);
    }
}