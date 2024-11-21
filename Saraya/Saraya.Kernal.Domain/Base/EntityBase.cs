namespace Saraya.Kernal.Domain.Base;

public abstract class EntityBase<T> : IEntity<T>
{
    public bool IsDeleted { get; set; }
    public T Id { get; set; }
    public long CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public long? LastModifiedBy { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public long? DeletedBy { get; set; }
    public DateTime? DeletedAt { get; set; }

    public void EntityCreated(long userId, DateTime dateTime)
    {
        CreatedBy = userId;
        CreatedAt = dateTime;
        IsDeleted = false;
    }

    public void EntityUpdated(long userId, DateTime dateTime)
    {
        LastModifiedBy = userId;
        LastModifiedAt = dateTime;
    }

    public void EntityDeleted(long userId, DateTime dateTime)
    {
        DeletedBy = userId;
        DeletedAt = dateTime;
        IsDeleted = true;
    }

    public object[] GetKeys() => new object[] { Id };
}



