using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Common.Entities;

public abstract class GlobalEntity<T> : BaseEntity<T>, IGlobalActivityLog
    where T : class
{
    #region IGlobalActivityLog

    public Guid GlobalActivityLogId { get; set; }

    public GlobalActivityLog? GlobalActivityLog { get; set; }

    #endregion IGlobalActivityLog
}