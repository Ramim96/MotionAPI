using Domain.Entities;
using Infrastructure.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class CompanyActivityLogConfiguration : ActivityLogConfiguration<CompanyActivityLog>
{
    public override void Configure(EntityTypeBuilder<CompanyActivityLog> builder)
    {
        base.Configure(builder);

        // Foreign keys.
        builder
            .HasOne<Company>()
            .WithMany()
            .HasForeignKey(x => x.CompanyId)
            .HasConstraintName($"FK_{nameof(CompanyActivityLog)}_CompanyId");
    }
}