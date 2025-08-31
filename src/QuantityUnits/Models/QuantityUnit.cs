using System.ComponentModel.DataAnnotations.Schema;
using Avolutions.Baf.Core.Entity.Extensions;
using Avolutions.Baf.Core.Entity.Models;

namespace Avolutions.Baf.Domain.QuantityUnits.Models;

public class QuantityUnit : TranslatableEntity<QuantityUnitTranslation>
{
    public QuantityUnit() : base() { }

    public QuantityUnit(bool createMissingTranslations) : base(createMissingTranslations) { }
    
    [NotMapped]
    public string Abbreviation => Translations.Localized(t => t.Abbreviation);
}