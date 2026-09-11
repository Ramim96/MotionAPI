using Domain.Entities.Common;
using Domain.Interfaces;

namespace Domain.Entities;

public sealed class AppUser :
    GlobalEntity,
    IEntityEquality<AppUser>
{
    public string FirstName { get; set; } = string.Empty;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = string.Empty;

    public DateOnly Dob { get; set; }

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public bool Admin { get; set; } = false;

    public bool Equals(AppUser? external)
    {
        return external is not null &&
            external.FirstName == FirstName &&
            external.MiddleName == MiddleName &&
            external.LastName == LastName &&
            external.Dob == Dob &&
            external.Email == Email &&
            external.PasswordHash == PasswordHash &&
            external.Admin == Admin;
    }
}