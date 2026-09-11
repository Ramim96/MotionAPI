using Domain.Entities;
using Infrastructure.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class AppUserConfiguration : GlobalEntityConfiguration<AppUser>
{
    public override void Configure(EntityTypeBuilder<AppUser> builder)
    {
        // Base config.
        base.Configure(builder);

        builder
            .ToTable("AppUser");

        builder
            .Property(x => x.FirstName)
            .HasColumnName("FirstName");

        builder
            .Property(x => x.MiddleName)
            .HasColumnName("MiddleName");

        builder
            .Property(x => x.LastName)
            .HasColumnName("LastName");

        builder
            .Property(x => x.Dob)
            .HasColumnType("date")
            .HasColumnName("Dob");

        builder
            .Property(x => x.Email)
            .HasColumnName("Email");

        builder
            .Property(x => x.PasswordHash)
            .HasColumnName("Password");

        builder
            .Property(x => x.Admin)
            .HasDefaultValue(false)
            .HasColumnName("Admin");

        // Indexes config.
        builder
            .HasIndex(x => x.Email)
            .IsUnique()
            .IsClustered(false)
            .HasDatabaseName($"IX_{nameof(AppUser)}_Email");
    }
}