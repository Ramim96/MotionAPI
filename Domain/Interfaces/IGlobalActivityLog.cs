namespace Domain.Interfaces;

#region IGlobalActivityLog

public interface IGlobalActivityLog<T> :
    IGlobalActivityLogId,
    IGlobalActivityLogEntity<T>
{
}

#endregion IGlobalActivityLog

#region IGlobalActivityLogId

public interface IGlobalActivityLogId
{
    public Guid GlobalActivityLogId { get; set; }
}

public interface INullableGlobalActivityLogId
{
    public Guid? GlobalActivityLogId { get; set; }
}

#endregion IGlobalActivityLogId

#region IGlobalActivityLog<T>

public interface IGlobalActivityLogEntity<T>
{
    public T GlobalActivityLog { get; set; }
}

#endregion IGlobalActivityLog<T>