using TL.Core.Common;

namespace TL.Application.Common.Persistance
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
        Task<TEntity[]> GetAll(CancellationToken cancellationToken);
        Task<TEntity> GetById<TId>(TId id, CancellationToken cancellationToken);
        void Create(TEntity entity);
        void Remove(TEntity entity);

    }
}
