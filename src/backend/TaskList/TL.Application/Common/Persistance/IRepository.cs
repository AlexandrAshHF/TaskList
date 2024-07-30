using TL.Core.Common.Entity;

namespace TL.Application.Common.Persistance
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity
    {
        Task<TEntity[]> GetAll(CancellationToken cancellationToken);
        Task<TEntity> GetById<TId>(TId id, CancellationToken cancellationToken);
        void Create(TEntity entity);
        void Remove(TEntity entity);

    }
}
