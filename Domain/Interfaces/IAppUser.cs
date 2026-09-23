namespace Domain.Interfaces;

#region IAppUser

public interface IAppUser<T> :
    IAppUserId,
    IAppUserEntity<T>
{
}

#endregion IAppUser

#region INullableAppUser

public interface INullableAppUser<T> :
    INullableAppUserId,
    IAppUserEntity<T>
{
}

#endregion INullableAppUser

#region IAppUserId

public interface IAppUserId
{
    public Guid AppUserId { get; set; }
}

public interface INullableAppUserId
{
    public Guid? AppUserId { get; set; }
}

#endregion IAppUserId

#region IAppUserEntity<T>

public interface IAppUserEntity<T>
{
    public T AppUser { get; set; }
}

#endregion IAppUserEntity<T>