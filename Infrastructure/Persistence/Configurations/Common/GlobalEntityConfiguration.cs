using Domain.Entities;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Common;

internal abstract class GlobalEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : GlobalEntity
{
    protected readonly string _tableName = typeof(TEntity).Name;

    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        // Base config.
        builder
            .ToTable(_tableName);

        builder
            .HasKey(x => x.Id)
            .HasName($"PK_{_tableName}")
            .IsClustered();

        builder
            .Property(x => x.Id)
            .IsRequired()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        // Foreign keys.
        builder
            .HasOne<GlobalActivityLog>()
            .WithOne()
            .HasForeignKey<TEntity>(x => x.GlobalActivityLogId)
            .HasConstraintName($"FK_{_tableName}_GlobalActivityLog_GlobalActivityLogId");
    }
}