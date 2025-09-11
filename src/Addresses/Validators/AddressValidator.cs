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
        var latLabel = localizer["Field.Latitude"];
        var lonLabel = localizer["Field.Longitude"];
        
        RuleFor(x => x.City)
            .NotEmpty()
            .WithName(localizer["Field.City"]);

        RuleFor(x => x.CountryId)
            .NotEmpty()
            .WithName(localizer["Field.Country"]);
        
        // If one coord is set, both must be set
        RuleFor(a => a)
            .Must(a => !(a.Latitude.HasValue ^ a.Longitude.HasValue))
            .WithMessage(localizer["Validation.Coords.BothOrNone", latLabel, lonLabel]);

        RuleFor(a => a.Latitude)
            .InclusiveBetween(-90m, 90m)
            .When(a => a.Latitude.HasValue)
            .WithMessage(localizer["Validation.Coords.Range", latLabel, -90, 90]);

        RuleFor(a => a.Longitude)
            .InclusiveBetween(-180m, 180m)
            .When(a => a.Longitude.HasValue)
            .WithMessage(localizer["Validation.Coords.Range", lonLabel, -180, 180]);
    }
}