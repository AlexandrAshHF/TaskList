using TL.Infrastructure.Abstractions.Providers;

namespace TL.Infrastructure.Providers
{
    public class UserProvider : IUserProvider
    {
        public Task<Guid> GetCurrentUserId()
        {
            throw new NotImplementedException();
        }
    }
}
