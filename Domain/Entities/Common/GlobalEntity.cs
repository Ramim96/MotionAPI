using Domain.Interfaces;

namespace Domain.Entities.Common;

public abstract class GlobalEntity :
    IEntityId,
    INullableGlobalActivityLogId
{
    #region IEntityId

    public Guid Id { get; set; }

    #endregion IEntityId

    #region INullableGlobalActivityLogId

    public Guid? GlobalActivityLogId { get; set; }

    #endregion INullableGlobalActivityLogId
}