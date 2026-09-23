using Domain.Entities;
using Infrastructure.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class AppUserConfiguration : GlobalEntityConfiguration<AppUser>
{
    public override void Configure(EntityTypeBuilder<AppUser> builder)
    {
        base.Configure(builder);

        // Base config.
        builder
            .Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        builder
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        builder
            .Property(x => x.Dob)
            .IsRequired()
            .IsUnicode(false);

        builder
            .Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        builder
            .Property(x => x.PasswordHash)
            .IsRequired()
            .HasMaxLength(200);

        builder
            .Property(x => x.Admin)
            .HasDefaultValue(false);

        // Foreign keys config.
        builder
            .HasOne<GlobalActivityLog>()
            .WithOne()
            .HasForeignKey<AppUser>(x => x.GlobalActivityLogId)
            .HasConstraintName($"FK_{_tableName}_GlobalActivityLog_GlobalActivityLogId");
    }
}