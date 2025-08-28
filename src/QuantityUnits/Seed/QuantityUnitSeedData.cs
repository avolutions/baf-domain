using Avolutions.Baf.Domain.QuantityUnits.Models;

namespace Avolutions.Baf.Domain.QuantityUnits.Seed;

internal static class QuantityUnitSeedData
{
    public static IEnumerable<QuantityUnit> QuantityUnits =>
    [
        new()
        {
            Translations = new List<QuantityUnitTranslation>
            {
                new() { Language = "de", Value = "Stück", Abbreviation = "Stk"},
                new() { Language = "en", Value = "Piece", Abbreviation = "pc"}
            }
        }
    ];
}