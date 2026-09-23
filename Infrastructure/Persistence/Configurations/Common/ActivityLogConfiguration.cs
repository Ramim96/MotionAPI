using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Common;

internal class ActivityLogConfiguration : IEntityTypeConfiguration<ActivityLog>
{
    public void Configure(EntityTypeBuilder<ActivityLog> builder)
    {
        string tableName = nameof(ActivityLog);

        // Table per type config.
        builder
            .UseTptMappingStrategy()
            .ToTable(tableName);

        // Base config.
        builder
            .HasKey(x => x.Id)
            .HasName($"PK_{tableName}")
            .IsClustered();

        builder
            .Property(x => x.Id)
            .IsRequired()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder
            .Property(x => x.ActivityLogType)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(100)
            .IsUnicode(false);
    }
}