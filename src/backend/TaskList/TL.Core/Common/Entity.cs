namespace TL.Core.Common
{
    public abstract class Entity : Entity<Guid>
    {
    }

    public abstract class Entity<TEntityId> : IEntity<TEntityId>
    {
        public TEntityId Id { get; protected set; } = default;
    }

}
