using Avolutions.Baf.Core.Lookups.Models;

namespace Avolutions.Baf.Domain.Countries.Models;

public class Country : Lookup<CountryTranslation>
{
    public Country() : base() { }
    public Country(bool createMissingTranslations) : base(createMissingTranslations) { }
    
    public string IsoCode2 { get; set; } = string.Empty;
    public string? DialingCode { get; set; }
}