using Avolutions.Baf.Domain.Countries.Models;

namespace Avolutions.Baf.Domain.Countries.Seed;

internal static class CountrySeedData
{
    public static IEnumerable<Country> Countries =>
    [
        new()
        {
            Key = "DE",
            Translations = new List<CountryTranslation>
            {
                new() { Language = "de", Value = "Deutschland" },
                new() { Language = "en", Value = "Germany" }
            }
        }
    ];
}