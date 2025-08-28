using System.ComponentModel.DataAnnotations.Schema;
using Avolutions.Baf.Core.Entity.Extensions;
using Avolutions.Baf.Core.Entity.Models;

namespace Avolutions.Baf.Domain.QuantityUnits.Models;

public class QuantityUnit : TranslatableEntity<QuantityUnit, QuantityUnitTranslation>
{
    [NotMapped]
    public string Abbreviation => Translations.Localized(t => t.Abbreviation);
}