using Microsoft.EntityFrameworkCore;
using TL.Application.Common.Persistance;
using TL.Core.Common;
using TL.Infrastructure.Persistance.Contexts;

namespace TL.Infrastructure.Persistence.Repositories.Common
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        protected readonly TLDbContext _dbContext;

        public Repository(TLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity[]> GetAll(CancellationToken cancellationToken)
        {
            return await _dbContext.Set<TEntity>().ToArrayAsync(cancellationToken);
        }

        public virtual async Task<TEntity> GetById<TId>(TId id, CancellationToken cancellationToken)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id, cancellationToken);
        }

        public virtual void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
