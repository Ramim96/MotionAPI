using Domain.Entities;

namespace Domain.Interfaces;

public interface ICompany : ICompanyId, ICompanyEntity
{
}

public interface ICompanyId
{
    public Guid CompanyId { get; }
}

public interface ICompanyEntity
{
    public Company? Company { get; }
}