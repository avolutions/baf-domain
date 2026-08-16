using Avolutions.Baf.Domain.Calendar.Models;
using Avolutions.Baf.Domain.Calendar.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Calendar.Validators;

public class CalendarEventTypeValidator : AbstractValidator<CalendarEventType>
{
    public CalendarEventTypeValidator(IStringLocalizer<CalendarResources> localizer)
    {
        RuleFor(x => x.Color)
            .NotEmpty()
            .WithName(localizer["Field.Color"]);
    }
}