using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class CompanyUserPreferenceConfiguration : IEntityTypeConfiguration<CompanyUserPreference>
{
    public void Configure(EntityTypeBuilder<CompanyUserPreference> builder)
    {
        string tableName = nameof(CompanyUserPreference);

        // Table per type config.
        builder
            .ToTable(tableName);

        // Base config.
        builder
            .Property(x => x.CompanyId)
            .IsRequired();

        // Foreign keys config.
        builder
            .HasOne<Company>()
            .WithMany()
            .HasForeignKey(x => x.CompanyId)
            .HasConstraintName($"FK_{tableName}_Company_CompanyId");
    }
}