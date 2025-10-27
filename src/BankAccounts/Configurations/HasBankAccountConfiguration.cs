using Avolutions.Baf.Core.Persistence.Abstractions;
using Avolutions.Baf.Domain.BankAccounts.Abstractions;
using Avolutions.Baf.Domain.BankAccounts.Models;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.BankAccounts.Configurations;

public class HasBankAccountConfiguration : IModelConfiguration
{
    public void Configure(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes()
                     .Where(t => typeof(IHasBankAccount).IsAssignableFrom(t.ClrType)))
        {
            var builder = modelBuilder.Entity(entityType.ClrType);
          
            builder.HasOne(typeof(BankAccount), nameof(IHasBankAccount.BankAccount))
                .WithMany()
                .HasForeignKey(nameof(IHasBankAccount.BankAccountId))
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}