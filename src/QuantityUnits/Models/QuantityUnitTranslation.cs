using Avolutions.Baf.Core.Entity.Models;

namespace Avolutions.Baf.Domain.QuantityUnits.Models;

public class QuantityUnitTranslation : TranslationEntity<QuantityUnit>
{
    public string Abbreviation { get; set; } = string.Empty;
}