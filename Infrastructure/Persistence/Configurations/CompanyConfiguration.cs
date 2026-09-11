using Domain.Entities;
using Infrastructure.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class CompanyConfiguration : GlobalEntityConfiguration<Company>
{
    public override void Configure(EntityTypeBuilder<Company> builder)
    {
        // Base config.
        base.Configure(builder);

        builder
            .ToTable("Company");

        builder
            .Property(x => x.Code)
            .HasColumnName("Code");

        builder
            .Property(x => x.Name)
            .HasColumnName("Name");

        // Indexes config.
        builder
            .HasIndex(x => x.Code)
            .IsUnique()
            .IsClustered(false)
            .HasDatabaseName($"IX_{nameof(Company)}_Code");
    }
}