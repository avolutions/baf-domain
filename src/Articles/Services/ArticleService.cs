using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Core.NumberSequences.Services;
using Avolutions.Baf.Core.Persistence;
using Avolutions.Baf.Domain.Articles.Models;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Articles.Services;

public class ArticleService : EntityService<Article>
{
    private readonly INumberSequenceService<ArticleNoSequence> _numberSequence;
    
    public ArticleService(
        IDbContextFactory<BafDbContext> contextFactory,
        INumberSequenceService<ArticleNoSequence> numberSequence) : base(contextFactory)
    {
        _numberSequence = numberSequence;
    }
    
    public override async Task<Article> CreateAsync(Article article, CancellationToken ct = default)
    {
        if (string.IsNullOrEmpty(article.ArticleNo))
        {
            article.ArticleNo = await _numberSequence.GetNextAsync();
        }
        
        return await base.CreateAsync(article, ct);
    }
}