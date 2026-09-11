namespace Domain.Interfaces;

#region ICompany

public interface ICompany<T> : ICompanyId, ICompanyEntity<T>
{
}

#endregion ICompany

#region INullableCompany

public interface INullableCompany<T> : INullableCompanyId, ICompanyEntity<T>
{
}

#endregion INullableCompany

#region ICompanyId

public interface ICompanyId
{
    public Guid CompanyId { get; set; }
}

public interface INullableCompanyId
{
    public Guid? CompanyId { get; set; }
}

#endregion ICompanyId

#region ICompanyEntity<T>

public interface ICompanyEntity<T>
{
    public T Company { get; set; }
}

#endregion ICompanyEntity<T>