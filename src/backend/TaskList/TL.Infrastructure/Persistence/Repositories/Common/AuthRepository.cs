using Microsoft.EntityFrameworkCore;
using TL.Application.Common.Persistance;
using TL.Core.Common;
using TL.Infrastructure.Persistence.Contexts;

namespace TL.Infrastructure.Persistence.Repositories.Common
{
    public class AuthRepository<TEntity> : IRepository<TEntity> 
        where TEntity : Entity
    {
        protected readonly AuthDbContext _dbContext;

        public AuthRepository(AuthDbContext dbContext)
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
