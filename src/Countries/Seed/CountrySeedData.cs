using Avolutions.Baf.Domain.Countries.Models;

namespace Avolutions.Baf.Domain.Countries.Seed;

internal static class CountrySeedData
{
    public static IEnumerable<Country> Countries =>
    [
        new()
        {
            IsDefault = true,
            IsoCode2 = "DE",
            DialingCode = "+49",
            Translations = new List<CountryTranslation>
            {
                new() { Language = "de", Value = "Deutschland" },
                new() { Language = "en", Value = "Germany" }
            }
        },
        new()
        {
            IsoCode2 = "AT",
            DialingCode = "+43",
            Translations = new List<CountryTranslation>
            {
                new() { Language = "de", Value = "Österreich" },
                new() { Language = "en", Value = "Austria" }
            }
        },
        new()
        {
            IsoCode2 = "CH",
            DialingCode = "+41",
            Translations = new List<CountryTranslation>
            {
                new() { Language = "de", Value = "Schweiz" },
                new() { Language = "en", Value = "Switzerland" }
            }
        }
    ];
}