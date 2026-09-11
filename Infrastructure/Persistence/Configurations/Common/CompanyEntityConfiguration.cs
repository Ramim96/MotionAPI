using Domain.Entities;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Common;

internal class CompanyEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : CompanyEntity
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

        // Foreign keys config.
        builder
            .HasOne(x => x.Company)
            .WithOne()
            .HasForeignKey<TEntity>(x => x.CompanyId)
            .HasConstraintName($"FK_{entityName}_CompanyId");

        builder
            .HasOne<CompanyActivityLog>()
            .WithOne()
            .HasForeignKey<TEntity>(x => x.CompanyActivityLogId)
            .HasConstraintName($"FK_{entityName}_CompanyActivityLogId");

        // Indexes config.
        builder
            .HasIndex(x => x.CompanyId)
            .IsUnique()
            .IsClustered(false)
            .HasDatabaseName($"IX_{entityName}_CompanyId");

        builder
            .HasIndex(x => x.CompanyActivityLogId)
            .IsUnique()
            .IsClustered(false)
            .HasDatabaseName($"IX_{entityName}_CompanyActivityLogId");
    }
}