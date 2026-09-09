using Domain.Common.Entities;

namespace Domain.Entities;

public class AppUser : BaseEntity<AppUser>
{
    public string FirstName { get; set; } = string.Empty;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = string.Empty;

    public DateOnly DateOfBirth {  get; set; }

    public string Email { get; set; } = string.Empty;

    public bool Admin { get; set; } = false;

    public override bool Equals(AppUser? externalEntity)
    {
        return externalEntity is not null &&
            externalEntity.FirstName == FirstName &&
            externalEntity.MiddleName == MiddleName &&
            externalEntity.LastName == LastName &&
            externalEntity.DateOfBirth == DateOfBirth &&
            externalEntity.Email == Email &&
            externalEntity.Admin == Admin;
    }
}