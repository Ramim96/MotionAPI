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
            .Property(x => x.CompanyCode);

        builder
            .Property(x => x.CompanyName);

        // Indexes config.
        builder
            .HasIndex(x => x.CompanyCode)
            .IsUnique()
            .IsClustered(false)
            .HasDatabaseName($"IX_{nameof(Company)}_Code");
    }
}