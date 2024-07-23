using Microsoft.EntityFrameworkCore;
using TL.Core.Entities.Authentication;
using TL.Infrastructure.Persistance.Contexts;

namespace TL.Infrastructure.Persistence.Contexts
{
    public class AuthDbContext : BaseDbContext
    {
        public DbSet<User> Users => Set<User>();

        public DbSet<Role> Roles => Set<Role>();

        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
