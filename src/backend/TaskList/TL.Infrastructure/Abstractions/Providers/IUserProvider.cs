using TL.Core.Entities.Authentication;

namespace TL.Infrastructure.Abstractions.Providers
{
    public interface IUserProvider
    {
        Task<Guid> GetCurrentUserId();
    }
}
