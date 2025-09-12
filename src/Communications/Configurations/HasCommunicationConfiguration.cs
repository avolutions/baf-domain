using Avolutions.Baf.Core.Persistence.Abstractions;
using Avolutions.Baf.Domain.Communications.Abstractions;
using Avolutions.Baf.Domain.Communications.Models;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Communications.Configurations;

public class HasCommunicationConfiguration : IModelConfiguration
{
    public void Configure(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes()
                     .Where(t => typeof(IHasCommunication).IsAssignableFrom(t.ClrType)))
        {
            var builder = modelBuilder.Entity(entityType.ClrType);
          
            builder.HasOne(typeof(Communication), nameof(IHasCommunication.Communication))
                .WithMany()
                .HasForeignKey(nameof(IHasCommunication.CommunicationId))
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}