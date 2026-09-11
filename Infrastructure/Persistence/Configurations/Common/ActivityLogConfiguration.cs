using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Common;

internal class ActivityLogConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : ActivityLog
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        // Table per type config.
        builder
            .ToTable("ActivityLog")
            .UseTptMappingStrategy();

        // Base config.
        builder
            .HasKey(x => x.Id)
            .HasName($"PK_{nameof(ActivityLog)}Id")
            .IsClustered(true);

        builder
            .Property(x => x.Id)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder
            .Property(x => x.ActivityLogType)
            .HasConversion<string>();
    }
}