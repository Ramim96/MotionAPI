using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Entities.Common;

public abstract class ActivityLog : IEntityId
{
    #region IEntity

    public Guid Id { get; set; }

    #endregion IEntity

    public ActivityLogType ActivityLogType { get; set; }
}