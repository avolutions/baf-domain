using Avolutions.Baf.Core.Entity.Abstractions;
using Avolutions.Baf.Core.Module.Abstractions;
using Avolutions.Baf.Domain.Articles.Models;
using Avolutions.Baf.Domain.Articles.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Avolutions.Baf.Domain.Articles;

public class ArticlesModule : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddScoped<ArticleService>();
        services.AddScoped<IEntityService<Article>, ArticleService>();
    }
}