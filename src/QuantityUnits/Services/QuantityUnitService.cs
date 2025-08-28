using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Domain.QuantityUnits.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.QuantityUnits.Services;

public class QuantityUnitService : TranslatableEntityService<QuantityUnit, QuantityUnitTranslation>
{
    public QuantityUnitService(DbContext context) : base(context)
    {
    }

    public QuantityUnitService(DbContext context, IValidator<QuantityUnit>? validator) : base(context, validator)
    {
    }
}