namespace Saraya.Kernal.Domain.Base
{
    public interface IEntity
    {
        long CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        long? LastModifiedBy { get; set; }
        DateTime? LastModifiedAt { get; set; }
        long? DeletedBy { get; set; }
        DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }

    public interface IEntity<T> : IEntity
    {
        T Id { get; set; }
    }

    public interface IMustHaveKey
    {
        object[] GetKey();
    }
   
}
