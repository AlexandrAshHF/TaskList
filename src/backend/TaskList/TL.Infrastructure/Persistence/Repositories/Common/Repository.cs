using Microsoft.EntityFrameworkCore;
using TL.Application.Common.Persistance;
using TL.ApplicationDto.Common;
using TL.Core.Common.Entity;
using TL.Infrastructure.Extensions.Pagination;
using TL.Infrastructure.Persistance.Contexts;

namespace TL.Infrastructure.Persistence.Repositories.Common
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected readonly TLDbContext _dbContext;
        protected readonly IPageGenerator _pageGenerator;

        public Repository(TLDbContext dbContext, IPageGenerator pageGenerator)
        {
            _dbContext = dbContext;
            _pageGenerator = pageGenerator;
        }

        public async Task<IEnumerable<TDto>> GetAll<TDto>(QueryRequestDto request, CancellationToken cancellationToken)
        {
            var result = await _pageGenerator.GeneratePage<TDto, TEntity>(_dbContext.Set<TEntity>(), request, cancellationToken);
            return result;
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
