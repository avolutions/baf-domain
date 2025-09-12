using Avolutions.Baf.Domain.Addresses.Models;

namespace Avolutions.Baf.Domain.Addresses.Abstractions;

public interface IHasAddress
{
    public Guid AddressId { get; set; }
    public Address Address { get; set; }
}