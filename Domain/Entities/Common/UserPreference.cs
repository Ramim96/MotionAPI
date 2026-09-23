using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Entities.Common;

public abstract class UserPreference :
    IEntityId,
    IAppUserId
{
    #region IEntityId

    public Guid Id { get; set; }

    #endregion IEntityId

    public UserPreferenceType UserPreferenceType { get; set; }

    public string Value { get; set; } = string.Empty;

    #region IAppUserId

    public Guid AppUserId { get; set; }

    #endregion IAppUserId
}