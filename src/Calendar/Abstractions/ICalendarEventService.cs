using Avolutions.Baf.Core.Entity.Abstractions;
using Avolutions.Baf.Domain.Calendar.Models;

namespace Avolutions.Baf.Domain.Calendar.Abstractions;

public interface ICalendarEventService : IEntityService<CalendarEvent>
{
    Task<List<CalendarEvent>> GetByRangeAsync(
        DateTime start,
        DateTime end,
        Guid userId,
        CancellationToken cancellationToken = default);
}