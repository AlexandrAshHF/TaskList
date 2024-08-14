using Microsoft.EntityFrameworkCore;
using TL.Application.Common.Persistance.Repositories;
using TL.Core.Entities.Application;
using TL.Infrastructure.Extensions.Pagination;
using TL.Infrastructure.Persistance.Contexts;
using TL.Infrastructure.Persistence.Repositories.Common;

namespace TL.Infrastructure.Persistence.Repositories
{
    internal class ApplicationRepository : Repository<TLApplication>, IApplicationRepository
    {
        public ApplicationRepository(TLDbContext dbContext, IPageGenerator pageGenerator) 
            : base(dbContext, pageGenerator)
        {
        }

        public async Task<TLApplication?> GetByNameAndProjectId(string name, int projectId)
        {
            var application = await _dbContext.Applications.FirstOrDefaultAsync(a => a.Name == name && a.ProjectId == projectId);
            return application;
        }
    }
}
