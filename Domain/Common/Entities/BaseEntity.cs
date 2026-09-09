using Domain.Interfaces;

namespace Domain.Common.Entities;

public abstract class BaseEntity<T> : IEntityId
    where T : class
{
    public Guid Id { get; set; }

    public abstract bool Equals(T? externalEntity);
}