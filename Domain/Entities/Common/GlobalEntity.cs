using Domain.Interfaces;

namespace Domain.Entities.Common;

public abstract class GlobalEntity : IEntityId, IGlobalActivityLog<GlobalActivityLog?>
{
    #region IEntityId

    public Guid Id { get; set; }

    #endregion IEntityId

    #region IGlobalActivityLog<T>

    public Guid GlobalActivityLogId { get; set; }

    public GlobalActivityLog? GlobalActivityLog { get; set; }

    #endregion IGlobalActivityLog<T>
}