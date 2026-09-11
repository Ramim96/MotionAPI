using Domain.Entities.Common;
using Domain.Interfaces;

namespace Domain.Entities;

public sealed class Company : GlobalEntity, IEntityEquality<Company>
{
    public string Code { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public bool Equals(Company? external)
    {
        return external is not null &&
            external.Code == Code &&
            external.Name == Name;
    }
}