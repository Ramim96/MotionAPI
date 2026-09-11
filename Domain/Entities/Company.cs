using Domain.Entities.Common;
using Domain.Interfaces;

namespace Domain.Entities;

public sealed class Company :
    GlobalEntity,
    IEntityEquality<Company>
{
    public string CompanyCode { get; set; } = string.Empty;

    public string CompanyName { get; set; } = string.Empty;

    public bool Equals(Company? external)
    {
        return external is not null &&
            external.CompanyCode == CompanyCode &&
            external.CompanyName == CompanyName;
    }
}