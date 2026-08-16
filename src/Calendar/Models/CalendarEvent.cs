using Avolutions.Baf.Core.Entity.Models;
using Avolutions.Baf.Core.Lookups.Attributes;

namespace Avolutions.Baf.Domain.Calendar.Models;

public class CalendarEvent : EntityBase
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public bool IsAllDay { get; set; }
    public CalendarEventVisibility Visibility { get; set; } = CalendarEventVisibility.Private;

    public Guid CalendarEventTypeId { get; set; }
    [Lookup]
    public CalendarEventType CalendarEventType { get; set; } = null!;

    public override string GetName() => Title;
}