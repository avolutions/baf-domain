using Avolutions.Baf.Core.Lookups.Extensions;
using Avolutions.Baf.Core.Module.Abstractions;
using Avolutions.Baf.Domain.Calendar.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Calendar;

public class CalendarModule : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddLookup<CalendarEventType>();
    }
}