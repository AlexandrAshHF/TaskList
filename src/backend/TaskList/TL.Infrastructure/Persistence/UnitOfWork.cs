using TL.Application.Common.Persistance;
using TL.Core.Common;
using TL.Infrastructure.Abstractions.Providers;
using TL.Infrastructure.Persistance.Contexts;

namespace TL.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TLDbContext _dbContext;
        private readonly IUserProvider _userProvider;

        public UnitOfWork(TLDbContext dbContext, IUserProvider userProvider)
        {
            _dbContext = dbContext;
            _userProvider = userProvider;
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            AuditEntity();

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
        }

        private async Task AuditEntity()
        {
            var entries = _dbContext.ChangeTracker.Entries<IAuditableEntity>();

            var userId = await _userProvider.GetCurrentUserId();
        }
    }
}
