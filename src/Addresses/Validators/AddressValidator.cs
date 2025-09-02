using Avolutions.Baf.Core;
using Avolutions.Baf.Domain.Addresses.Models;
using Avolutions.Baf.Domain.Addresses.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Addresses.Validators;

public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator(BafDbContext dbContext, IStringLocalizer<AddressResources> localizer)
    {
        RuleFor(x => x.City)
            .NotEmpty()
            .WithName(localizer["field.city"]);

        RuleFor(x => x.CountryId)
            .NotEmpty()
            .WithName(localizer["field.country"]);
    }
}