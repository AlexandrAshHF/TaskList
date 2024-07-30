namespace TL.Core.Common.Entity
{
    public interface IEntity
    {

    }
    public interface IEntity<TEntityId> : IEntity
    {
        TEntityId Id { get; }
    }
}
