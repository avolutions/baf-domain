using Avolutions.Baf.Core.Entity.Models;
using Avolutions.Baf.Domain.Countries.Models;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Addresses.Models;

public class Address : EntityBase
{
    public string? AdditionalLine { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }
    public string City { get; set; } = string.Empty;
    [Precision(9, 6)]
    public decimal? Latitude { get; set; }
    [Precision(9, 6)]
    public decimal? Longitude { get; set; }
    
    public Guid CountryId { get; set; }
    public Country Country { get; set; } = null!;
    
    public override string GetName()
    {
        var street = Street?.Trim();
        var location = $"{ZipCode} {City}".Trim();

        return string.IsNullOrWhiteSpace(street)
            ? location
            : string.IsNullOrWhiteSpace(location)
                ? street
                : $"{street}, {location}";
    }
    
    public string GetFullAddress()
    {
        return $"{GetName()}, {Country.Value}";
    }
}