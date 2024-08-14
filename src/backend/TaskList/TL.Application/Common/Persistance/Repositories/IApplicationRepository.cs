using TL.Core.Entities.Application;

namespace TL.Application.Common.Persistance.Repositories
{
    public interface IApplicationRepository : IRepository<TLApplication>
    {
        Task<TLApplication?> GetByNameAndProjectId(string name, int projectId);
    }
}
