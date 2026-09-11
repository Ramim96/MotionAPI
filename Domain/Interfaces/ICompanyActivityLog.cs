namespace Domain.Interfaces;

#region ICompanyActivityLog

public interface ICompanyActivityLog<T> :
    ICompanyActivityLogId,
    ICompanyActivityLogEntity<T>
{
}

#endregion ICompanyActivityLog

#region ICompanyActivityLogId

public interface ICompanyActivityLogId
{
    public Guid CompanyActivityLogId { get; set; }
}

public interface INullableCompanyActivityLogId
{
    public Guid? CompanyActivityLogId { get; set; }
}

#endregion ICompanyActivityLogId

#region ICompanyActivityLog<T>

public interface ICompanyActivityLogEntity<T>
{
    public T CompanyActivityLog { get; set; }
}

#endregion ICompanyActivityLog<T>