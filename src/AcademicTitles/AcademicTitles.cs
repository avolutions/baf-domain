using Avolutions.Baf.Core.Lookups.Extensions;
using Avolutions.Baf.Core.Module.Abstractions;
using Avolutions.Baf.Domain.AcademicTitles.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.AcademicTitles;

public class AcademicTitles : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddLookup<AcademicTitle>();
    }
}