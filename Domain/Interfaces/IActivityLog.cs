using Domain.Entities;

namespace Domain.Interfaces;

#region Global activity log

public interface IGlobalActivityLog : IGlobalActivityLogId, IGlobalActivityLogEntity
{
}

public interface IGlobalActivityLogId
{
    public Guid GlobalActivityLogId { get; set; }
}

public interface IGlobalActivityLogEntity
{
    public GlobalActivityLog? GlobalActivityLog { get; set; }
}

#endregion Global activity log

#region Company activity log
public interface ICompanyActivityLog : ICompanyActivityLogId, ICompanyActivityLogEntity
{
}

public interface ICompanyActivityLogId
{
    public Guid CompanyActivityLogId { get; set; }
}

public interface ICompanyActivityLogEntity
{
    public CompanyActivityLog? CompanyActivityLog { get; set; }
}

#endregion Company activity log