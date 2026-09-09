using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Entities;

public class GlobalActivityLog : IEntityId
{
    #region IEntityId

    public Guid Id { get; set; }

    #endregion IEntityId

    public ActivityLogType ActivityLogType { get; set; }
}