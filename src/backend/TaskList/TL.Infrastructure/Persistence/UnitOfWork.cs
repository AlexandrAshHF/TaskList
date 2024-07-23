using TL.Application.Common.Persistance;

namespace TL.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
