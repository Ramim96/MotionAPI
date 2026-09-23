using Domain.Entities;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Common;

internal class UserPreferenceConfiguration : IEntityTypeConfiguration<UserPreference>
{
    public void Configure(EntityTypeBuilder<UserPreference> builder)
    {
        string tableName = nameof(UserPreference);

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
            .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder
            .Property(x => x.UserPreferenceType)
            .HasConversion<string>()
            .HasMaxLength(100)
            .IsUnicode(false);

        builder
            .Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);

        // Foreign keys config.
        builder
            .HasOne<AppUser>()
            .WithMany()
            .HasForeignKey(x => x.AppUserId)
            .HasConstraintName($"FK_{tableName}_AppUser_AppUserId");
    }
}