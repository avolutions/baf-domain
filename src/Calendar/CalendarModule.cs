using Avolutions.Baf.Core.Entity.Abstractions;
using Avolutions.Baf.Core.Lookups.Extensions;
using Avolutions.Baf.Core.Module.Abstractions;
using Avolutions.Baf.Domain.Calendar.Abstractions;
using Avolutions.Baf.Domain.Calendar.Models;
using Avolutions.Baf.Domain.Calendar.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Calendar;

public class CalendarModule : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddLookup<CalendarEventType>();
        services.AddScoped<CalendarEventService>();
        services.AddScoped<ICalendarEventService, CalendarEventService>();
        services.AddScoped<IEntityService<CalendarEvent>, CalendarEventService>();
    }
}