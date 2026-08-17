using Avolutions.Baf.Core.Colors.Models;
using Avolutions.Baf.Core.Lookups.Models;

namespace Avolutions.Baf.Domain.Calendar.Models;

public class CalendarEventType : Lookup<CalendarEventTypeTranslation>
{
    public CalendarEventType() : base() { }
    public CalendarEventType(bool createMissingTranslations) : base(createMissingTranslations) { }

    public string Color { get; set; } = MaterialColors.Grey;
    public bool IsSystem { get; set; }
}