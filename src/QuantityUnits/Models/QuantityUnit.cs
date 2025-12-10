using System.ComponentModel.DataAnnotations.Schema;
using Avolutions.Baf.Core.Lookups.Extensions;
using Avolutions.Baf.Core.Lookups.Models;

namespace Avolutions.Baf.Domain.QuantityUnits.Models;

public class QuantityUnit : Lookup<QuantityUnitTranslation>
{
    public QuantityUnit() : base() { }

    public QuantityUnit(bool createMissingTranslations) : base(createMissingTranslations) { }
    
    [NotMapped]
    public string Abbreviation => Translations.Localized(t => t.Abbreviation);
}