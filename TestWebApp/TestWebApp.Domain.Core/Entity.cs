namespace TestWebApp.Domain.Core
{
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public T Id { get; set; }
    }
}