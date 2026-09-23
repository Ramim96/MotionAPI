using Domain.Entities.Common;
using Domain.Interfaces;

namespace Domain.Entities;

public sealed class CompanyUserPreference :
    UserPreference,
    ICompanyId
{
    #region ICompanyId

    public Guid CompanyId { get; set; }

    #endregion ICompanyId
}