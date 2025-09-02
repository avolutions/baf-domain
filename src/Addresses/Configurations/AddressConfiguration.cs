using Avolutions.Baf.Domain.Addresses.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avolutions.Baf.Domain.Addresses.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.Navigation(a => a.Country)
            .AutoInclude();
    }
}