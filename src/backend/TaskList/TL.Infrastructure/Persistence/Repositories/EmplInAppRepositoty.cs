using TL.Application.Common.Persistance.Repositories;
using TL.Core.Entities.Application;
using TL.Infrastructure.Extensions.Pagination;
using TL.Infrastructure.Persistance.Contexts;
using TL.Infrastructure.Persistence.Repositories.Common;

namespace TL.Infrastructure.Persistence.Repositories
{
    internal class EmplInAppRepositoty : Repository<EmployeeInApplication>, IEmplInAppRepository
    {
        public EmplInAppRepositoty(TLDbContext dbContext, IPageGenerator pageGenerator) 
            : base(dbContext, pageGenerator)
        {
        }
    }
}
