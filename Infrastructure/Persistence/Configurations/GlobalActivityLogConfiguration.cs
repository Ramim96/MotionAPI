using Domain.Entities;
using Infrastructure.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class GlobalActivityLogConfiguration : ActivityLogConfiguration<GlobalActivityLog>
{
    public override void Configure(EntityTypeBuilder<GlobalActivityLog> builder)
    {
        base.Configure(builder);
    }
}