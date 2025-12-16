using System.ComponentModel.DataAnnotations.Schema;
using Avolutions.Baf.Core.Entity.Models;
using Avolutions.Baf.Core.Lookups.Attributes;
using Avolutions.Baf.Domain.Countries.Models;

namespace Avolutions.Baf.Domain.Addresses.Models;

public class Address : EntityBase
{
    public string? AdditionalLine { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public string City { get; set; } = string.Empty;
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    
    public Guid CountryId { get; set; }
    [Lookup]
    public Country Country { get; set; } = null!;
    
    public override string GetName()
    {
        var street = Street?.Trim();
        var location = CityWithZipCode;

        return string.IsNullOrWhiteSpace(street)
            ? location
            : string.IsNullOrWhiteSpace(location)
                ? street
                : $"{street}, {location}";
    }
    
    [NotMapped]
    public string CityWithZipCode => $"{ZipCode} {City}".Trim();
    
    public string GetFullAddress()
    {
        return $"{GetName()}, {Country.Value}";
    }
}