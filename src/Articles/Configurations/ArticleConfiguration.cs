using Avolutions.Baf.Domain.Articles.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avolutions.Baf.Domain.Articles.Configurations;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasIndex(a => a.ArticleNo)
            .IsUnique();
        
        builder.Navigation(a => a.QuantityUnit)
            .AutoInclude();
        
        builder.Property(a => a.Type)
            .HasConversion<string>();
    }
}