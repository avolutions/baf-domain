using Avolutions.Baf.Domain.Calendar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avolutions.Baf.Domain.Calendar.Configurations;

public class CalendarEventConfiguration : IEntityTypeConfiguration<CalendarEvent>
{
    public void Configure(EntityTypeBuilder<CalendarEvent> builder)
    {
        builder.Property(a => a.Visibility)
            .HasConversion<string>();
        
        builder.HasIndex(e => new { e.Start, e.End });
        builder.HasIndex(e => new { e.Visibility, e.CreatedBy });
    }
}