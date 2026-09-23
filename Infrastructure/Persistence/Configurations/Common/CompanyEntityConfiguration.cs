using Domain.Entities;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Common;

internal class CompanyEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : CompanyEntity
{
    protected readonly string _tableName = typeof(TEntity).Name;

    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        // Base config.
        builder
            .HasKey(x => x.Id)
            .HasName($"PK_{_tableName}")
            .IsClustered();

        builder
            .Property(x => x.Id)
            .IsRequired()
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder
            .Property(x => x.CompanyId)
            .IsRequired();

        // Foreign keys config.
        builder
            .HasOne(x => x.Company)
            .WithOne()
            .HasForeignKey<TEntity>(x => x.CompanyId)
            .HasConstraintName($"FK_{_tableName}_Company_CompanyId");

        builder
            .HasOne<CompanyActivityLog>()
            .WithOne()
            .HasForeignKey<TEntity>(x => x.CompanyActivityLogId)
            .HasConstraintName($"FK_{_tableName}_CompanyActivityLog_CompanyActivityLogId");
    }
}