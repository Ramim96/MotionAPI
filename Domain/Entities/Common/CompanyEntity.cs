using Domain.Interfaces;
using System.ComponentModel.Design;

namespace Domain.Entities.Common;

public abstract class CompanyEntity :
    IEntityId,
    ICompany<Company?>,
    INullableCompanyActivityLogId
{
    #region IEntityId

    public Guid Id { get; set; }

    #endregion IEntityId

    #region ICompany<Company?>

    public Guid CompanyId { get; set; }

    public Company? Company { get; set; }

    #endregion ICompany<Company?>

    #region INullableCompanyActivityLogId

    public Guid? CompanyActivityLogId { get; set; }

    #endregion INullableCompanyActivityLogId
}