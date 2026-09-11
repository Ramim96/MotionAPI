namespace Domain.Interfaces;

public interface IEntityId
{
    public Guid Id { get; set; }
}

public interface IEntityEquality<T>
{
    public bool Equals(T? external);
}