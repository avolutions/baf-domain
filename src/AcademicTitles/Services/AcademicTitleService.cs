using Avolutions.Baf.Core.Entity.Services;
using Avolutions.Baf.Domain.AcademicTitles.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.AcademicTitles.Services;

public class AcademicTitleService : TranslatableEntityService<AcademicTitle, AcademicTitleTranslation>
{
    public AcademicTitleService(DbContext context) : base(context)
    {
    }

    public AcademicTitleService(DbContext context, IValidator<AcademicTitle>? validator) : base(context, validator)
    {
    }
}