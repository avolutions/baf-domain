using Avolutions.Baf.Core.Persistence.Abstractions;
using Avolutions.Baf.Domain.Addresses.Abstractions;
using Avolutions.Baf.Domain.Addresses.Models;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Addresses.Configurations;

public class HasAddressConfiguration : IModelConfiguration
{
    public void Configure(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes()
                     .Where(t => typeof(IHasAddress).IsAssignableFrom(t.ClrType)))
        {
            var builder = modelBuilder.Entity(entityType.ClrType);
          
            builder.HasOne(typeof(Address), nameof(IHasAddress.Address))
                .WithMany()
                .HasForeignKey(nameof(IHasAddress.AddressId))
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}