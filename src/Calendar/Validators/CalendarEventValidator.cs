using Avolutions.Baf.Domain.Calendar.Models;
using Avolutions.Baf.Domain.Calendar.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Calendar.Validators;

public class CalendarEventValidator : AbstractValidator<CalendarEvent>
{
    public CalendarEventValidator(IStringLocalizer<CalendarResources> localizer)
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .WithName(localizer["Field.Title"]);

        RuleFor(x => x.Start)
            .NotEmpty()
            .WithName(localizer["Field.Start"]);

        RuleFor(x => x.End)
            .NotEmpty()
            .GreaterThan(x => x.Start)
            .WithName(localizer["Field.End"]);

        RuleFor(x => x.CalendarEventTypeId)
            .NotEmpty()
            .WithName(localizer["Field.CalendarEventType"]);

        RuleFor(x => x.Visibility)
            .IsInEnum()
            .WithName(localizer["Field.Visibility"]);
    }
}