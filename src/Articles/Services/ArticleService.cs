using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Core.NumberSequences.Services;
using Avolutions.Baf.Domain.Articles.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Articles.Services;

public class ArticleService : EntityService<Article>
{
    private readonly INumberSequenceService<ArticleNoSequence> _numberSequence;
    
    public ArticleService(
        DbContext context,
        IValidator<Article>? validator,
        INumberSequenceService<ArticleNoSequence> numberSequence) : base(context, validator)
    {
        _numberSequence = numberSequence;
    }
    
    public override async Task<Article> CreateAsync(Article article)
    {
        if(string.IsNullOrEmpty(article.ArticleNo))
        {
            article.ArticleNo = await _numberSequence.GetNextAsync();
        }
        
        return await base.CreateAsync(article);
    }
}