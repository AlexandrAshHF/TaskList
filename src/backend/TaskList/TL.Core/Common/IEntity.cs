namespace TL.Core.Common
{
    public interface IEntity
    {

    }
    public interface IEntity<TEntityId> : IEntity
    {
        TEntityId Id { get; }
    }
}
