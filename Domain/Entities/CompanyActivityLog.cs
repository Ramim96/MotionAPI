using Domain.Entities.Common;
using Domain.Interfaces;

namespace Domain.Entities;

public sealed class CompanyActivityLog :
    ActivityLog,
    ICompanyId
{
    #region ICompanyId

    public Guid CompanyId { get; set; }

    #endregion ICompanyId
}