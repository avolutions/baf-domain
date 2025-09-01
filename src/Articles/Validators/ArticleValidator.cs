using Avolutions.Baf.Core;
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
            .NotEmpty()
            .WithName(localizer["field.article-no"])
            .UniqueFor(dbContext, x => x.Id)
            .When(x => !string.IsNullOrWhiteSpace(x.ArticleNo));

        RuleFor(x => x.Title)
            .NotEmpty()
            .WithName(localizer["field.title"]);

        RuleFor(x => x.QuantityUnitId)
            .NotEmpty()
            .WithName(localizer["field.quantity-unit"]);
    }
}