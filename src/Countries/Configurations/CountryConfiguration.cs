using Avolutions.Baf.Domain.Countries.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avolutions.Baf.Domain.Countries.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasIndex(a => a.IsoCode2)
            .IsUnique();
    }
}