using Avolutions.Baf.Core.Lookups.Resources;
using Avolutions.Baf.Core.Lookups.Validators;
using Avolutions.Baf.Domain.Calendar.Models;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Calendar.Validators;

public class CalendarEventTypeTranslationValidator : LookupTranslationValidator<CalendarEventTypeTranslation>
{
    public CalendarEventTypeTranslationValidator(IStringLocalizer<LookupResources> localizer) : base(localizer)
    {
    }
}