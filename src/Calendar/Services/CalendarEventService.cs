using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Core.Persistence;
using Avolutions.Baf.Domain.Calendar.Abstractions;
using Avolutions.Baf.Domain.Calendar.Models;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Calendar.Services;

public class CalendarEventService : EntityService<CalendarEvent>, ICalendarEventService
{
    public CalendarEventService(IDbContextFactory<BafDbContext> contextFactory) : base(contextFactory)
    {
    }

    public async Task<List<CalendarEvent>> GetByRangeAsync(
        DateTime start,
        DateTime end,
        Guid userId,
        CancellationToken ct = default)
    {
        await using var context = await ContextFactory.CreateDbContextAsync(ct);

        return await context.Set<CalendarEvent>()
            .AsNoTracking()
            .Where(e => e.Start < end && e.End > start)
            .Where(e => e.Visibility == CalendarEventVisibility.Public || e.CreatedBy == userId)
            .OrderBy(e => e.Start)
            .ToListAsync(ct);
    }
}