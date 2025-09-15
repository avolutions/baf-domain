using Avolutions.Baf.Core.Entity.Abstractions;
using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Core.NumberSequences.Services;
using Avolutions.Baf.Domain.Articles.Models;
using Avolutions.Baf.Domain.QuantityUnits.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Articles.Services;

public class ArticleService : EntityService<Article>
{
    private readonly INumberSequenceService<ArticleNoSequence> _numberSequence;
    private readonly ITranslatableEntityService<QuantityUnit, QuantityUnitTranslation> _quantityUnitService;
    
    public ArticleService(
        DbContext context,
        IValidator<Article>? validator,
        INumberSequenceService<ArticleNoSequence> numberSequence, 
        ITranslatableEntityService<QuantityUnit, QuantityUnitTranslation> quantityUnitService) : base(context, validator)
    {
        _numberSequence = numberSequence;
        _quantityUnitService = quantityUnitService;
    }
    
    public override async Task<Article> CreateAsync(Article article, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(article.ArticleNo))
        {
            article.ArticleNo = await _numberSequence.GetNextAsync();
        }
        
        if (article.QuantityUnitId == Guid.Empty)
        {
            var defaultQuantityUnit = await _quantityUnitService.GetDefaultAsync(cancellationToken);
            article.QuantityUnitId = defaultQuantityUnit.Id;
        }
        
        return await base.CreateAsync(article, cancellationToken);
    }
    
    public async Task<Article> GetByArticleNo(string articleNo, CancellationToken cancellationToken = default)
    {
        var article = await DbSet.AsNoTracking().SingleOrDefaultAsync(l => l.ArticleNo == articleNo, cancellationToken);
        if (article == null)
        {
            throw new Exception($"Article with ArticleNo '{articleNo}' not found");
        }

        return article;
    }
}