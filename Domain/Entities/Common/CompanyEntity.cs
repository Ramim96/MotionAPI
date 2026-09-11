using Domain.Interfaces;

namespace Domain.Entities.Common;

public abstract class CompanyEntity :
    IEntityId,
    ICompany<Company?>,
    ICompanyActivityLog<CompanyActivityLog?>
{
    #region IEntityId

    public Guid Id { get; set; }

    #endregion IEntityId

    #region ICompany

    public Guid CompanyId { get; set; }

    public Company? Company { get; set; }

    #endregion ICompany

    #region ICompanyActivityLog<T>

    public Guid CompanyActivityLogId { get; set; }

    public CompanyActivityLog? CompanyActivityLog { get; set; }

    #endregion ICompanyActivityLog<T>
}