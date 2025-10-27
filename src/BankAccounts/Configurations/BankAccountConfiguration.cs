using System.Text.RegularExpressions;
using Avolutions.Baf.Domain.BankAccounts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Avolutions.Baf.Domain.BankAccounts.Configurations;

public partial class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
{
    [GeneratedRegex("\\s+")]
    private static partial Regex WhitespaceRegex();
    
    public void Configure(EntityTypeBuilder<BankAccount> builder)
    {
        var converter = new ValueConverter<string, string>(
            v => string.IsNullOrWhiteSpace(v) ? string.Empty : WhitespaceRegex().Replace(v, "").ToUpperInvariant(),
            v => v
        );
        
        builder.HasIndex(x => x.Iban)
            .IsUnique();
        
        builder.Property(x => x.Iban)
            .HasMaxLength(34)
            .HasConversion(converter);

        builder.Property(x => x.Bic)
            .HasMaxLength(11)
            .HasConversion(converter);
    }
}