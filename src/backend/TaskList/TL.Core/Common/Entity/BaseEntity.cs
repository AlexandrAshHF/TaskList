namespace TL.Core.Common.Entity
{
    public abstract class BaseEntity : BaseEntity<Guid>
    {
    }

    public abstract class BaseEntity<TEntityId> : IEntity<TEntityId>
    {
        public TEntityId Id { get; protected set; } = default;
    }

}
