using Domain.Common.Entities;
using Domain.Interfaces;

namespace Domain.Entities;

public class Company : GlobalEntity<Company>
{
    public string Code { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public override bool Equals(Company? externalEntity)
    {
        return externalEntity is not null &&
            externalEntity.Code == Code &&
            externalEntity.Name == Name;
    }
}