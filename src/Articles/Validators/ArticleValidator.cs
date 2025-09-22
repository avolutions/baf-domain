using Avolutions.Baf.Core;
using Avolutions.Baf.Core.Validation.Abstractions;
using Avolutions.Baf.Core.Validation.Extensions;
using Avolutions.Baf.Domain.Articles.Models;
using Avolutions.Baf.Domain.Articles.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Articles.Validators;

public class ArticleValidator : AbstractValidator<Article>
{
    public ArticleValidator(BafDbContext dbContext, IStringLocalizer<ArticleResources> localizer)
    {
        RuleFor(x => x.ArticleNo)
            .UniqueFor(dbContext, x => x.Id)
            .WithName(localizer["Field.ArticleNo"])
            .When(x => !string.IsNullOrWhiteSpace(x.ArticleNo));

        RuleFor(x => x.Title)
            .NotEmpty()
            .WithName(localizer["Field.Title"]);

        RuleFor(x => x.QuantityUnitId)
            .NotEmpty()
            .WithName(localizer["Field.QuantityUnit"]);
        
        RuleFor(x => x.TaxRate)
            .NotEmpty()
            .WithName(localizer["Field.TaxRate"])
            .InclusiveBetween(0, 100)
            .WithMessage(localizer["Validation.TaxRateRange"]);
        
        RuleSet(RuleSets.CreateOrUpdate, () => 
        {
            RuleFor(x => x.ArticleNo)
                .NotEmpty()
                .WithName(localizer["Field.ArticleNo"]);
        });
    }
}