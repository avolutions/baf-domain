using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Domain.Countries.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Countries.Services;

public class CountryService : TranslatableEntityService<Country, CountryTranslation>
{
    public CountryService(DbContext context) : base(context)
    {
    }

    public CountryService(DbContext context, IValidator<Country>? validator) : base(context, validator)
    {
    }
}