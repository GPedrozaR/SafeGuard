namespace SafeGuard.Core.Base
{
    public abstract class BaseEntity
    {
        public string Id { get; protected set; }

        public DateTime CreatedAt { get; protected set; } = DateTime.Now;
    }
}
