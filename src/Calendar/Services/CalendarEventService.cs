using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Core.Persistence;
using Avolutions.Baf.Domain.Calendar.Abstractions;
using Avolutions.Baf.Domain.Calendar.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Calendar.Services;

public class CalendarEventService : EntityService<CalendarEvent>, ICalendarEventService
{
    public CalendarEventService(
        DbContext context,
        IDbContextFactory<BafDbContext> contextFactory,
        IValidator<CalendarEvent>? validator) : base(context, contextFactory, validator)
    {
    }

    public async Task<List<CalendarEvent>> GetByRangeAsync(
        DateTime start,
        DateTime end,
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        await using var context = await ContextFactory.CreateDbContextAsync(cancellationToken);

        return await context.Set<CalendarEvent>()
            .AsNoTracking()
            .Where(e => e.Start < end && e.End > start)
            .Where(e => e.Visibility == CalendarEventVisibility.Public || e.CreatedBy == userId)
            .OrderBy(e => e.Start)
            .ToListAsync(cancellationToken);
    }
}