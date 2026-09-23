using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class GlobalUserPreferenceConfiguration : IEntityTypeConfiguration<GlobalUserPreference>
{
    public void Configure(EntityTypeBuilder<GlobalUserPreference> builder)
    {
        // TPT derived table configuration.
        string tableName = nameof(GlobalUserPreference);

        // Base config.
        builder
            .ToTable(tableName);
    }
}