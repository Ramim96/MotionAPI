using Domain.Entities;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Common;

internal abstract class GlobalEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : GlobalEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        string entityName = typeof(TEntity).Name;

        // Base config.
        builder
            .HasKey(x => x.Id)
            .HasName($"PK_{entityName}Id")
            .IsClustered(true);

        builder
            .Property(x => x.Id)
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        // Foreign keys.
        builder
            .HasOne<GlobalActivityLog>()
            .WithOne()
            .HasForeignKey<TEntity>(x => x.GlobalActivityLogId)
            .HasConstraintName($"FK_{entityName}_GlobalActivityLogId");

        // Indexes.
        builder
            .HasIndex(x => x.GlobalActivityLogId)
            .IsUnique()
            .IsClustered(false)
            .HasDatabaseName($"IX_{entityName}_GlobalActivityLogId");
    }
}