using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Entities;

public class CompanyActivityLog : IEntityId, ICompany
{
    #region IEntityId

    public Guid Id { get; set; }

    #endregion IEntityId

    public ActivityLogType ActivityLogType { get; set; }

    #region ICompany

    public Guid CompanyId { get; set; }

    public Company? Company { get; set; }

    #endregion ICompany
}