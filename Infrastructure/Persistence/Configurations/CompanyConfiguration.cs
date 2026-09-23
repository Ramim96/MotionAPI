using Domain.Entities;
using Infrastructure.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class CompanyConfiguration : GlobalEntityConfiguration<Company>
{
    public override void Configure(EntityTypeBuilder<Company> builder)
    {
        base.Configure(builder);

        // Base config.
        builder
            .Property(x => x.CompanyCode)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .Property(x => x.CompanyName)
            .IsRequired()
            .HasMaxLength(50);

        // Foreign keys config.
        builder
            .HasOne<GlobalActivityLog>()
            .WithOne()
            .HasForeignKey<Company>(x => x.GlobalActivityLogId)
            .HasConstraintName($"FK_{_tableName}_GlobalActivityLog_GlobalActivityLogId");
    }
}