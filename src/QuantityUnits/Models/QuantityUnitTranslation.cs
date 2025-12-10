using Avolutions.Baf.Core.Lookups.Models;

namespace Avolutions.Baf.Domain.QuantityUnits.Models;

public class QuantityUnitTranslation : LookupTranslation
{
    public string Abbreviation { get; set; } = string.Empty;
}