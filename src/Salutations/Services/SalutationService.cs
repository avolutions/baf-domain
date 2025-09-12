using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Domain.Salutations.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Salutations.Services;

public class SalutationService : TranslatableEntityService<Salutation, SalutationTranslation>
{
    public SalutationService(DbContext context) : base(context)
    {
    }

    public SalutationService(DbContext context, IValidator<Salutation>? validator) : base(context, validator)
    {
    }
}