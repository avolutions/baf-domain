using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Core.NumberSequences.Services;
using Avolutions.Baf.Core.Persistence;
using Avolutions.Baf.Domain.Articles.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Articles.Services;

public class ArticleService : EntityService<Article>
{
    private readonly INumberSequenceService<ArticleNoSequence> _numberSequence;
    
    public ArticleService(
        DbContext context,
        IDbContextFactory<BafDbContext> contextFactory,
        IValidator<Article>? validator,
        INumberSequenceService<ArticleNoSequence> numberSequence) : base(context, contextFactory, validator)
    {
        _numberSequence = numberSequence;
    }
    
    public override async Task<Article> CreateAsync(Article article, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(article.ArticleNo))
        {
            article.ArticleNo = await _numberSequence.GetNextAsync();
        }
        
        return await base.CreateAsync(article, cancellationToken);
    }
    
    public async Task<Article> GetByArticleNoAsync(string articleNo, CancellationToken cancellationToken = default)
    {
        var article = await DbSet.AsNoTracking().SingleOrDefaultAsync(l => l.ArticleNo == articleNo, cancellationToken);
        if (article == null)
        {
            throw new Exception($"Article with ArticleNo '{articleNo}' not found");
        }

        return article;
    }
}