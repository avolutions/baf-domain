using Avolutions.Baf.Core;
using Avolutions.Baf.Core.Validation.Extensions;
using Avolutions.Baf.Domain.Countries.Models;
using Avolutions.Baf.Domain.Countries.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Countries.Validators;

public class CountryValidator : AbstractValidator<Country>
{
    public CountryValidator(BafDbContext dbContext, IStringLocalizer<CountryResources> localizer)
    {
        RuleFor(x => x.IsoCode2)
            .NotEmpty()
            .Length(2)
            .Matches("^[A-Z]{2}$")
            .UniqueFor(dbContext, x => x.Id)
            .WithName(localizer["Field.IsoCode2"]);
        
        RuleFor(x => x.DialingCode)
            .Matches(@"^\+\d{1,4}$")
            .WithName(localizer["Field.DialingCode"]);
    }
}