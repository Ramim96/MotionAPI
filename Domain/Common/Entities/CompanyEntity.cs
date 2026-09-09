using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Common.Entities;

public abstract class CompanyEntity<T> : BaseEntity<T>, ICompanyActivityLog
    where T : class
{
    #region ICompanyActivityLog

    public Guid CompanyActivityLogId { get; set; }

    public CompanyActivityLog? CompanyActivityLog { get; set; }

    #endregion ICompanyActivityLog
}