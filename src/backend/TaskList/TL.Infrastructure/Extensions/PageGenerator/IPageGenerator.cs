using TL.ApplicationDto.Common;

namespace TL.Infrastructure.Extensions.Pagination
{
    public interface IPageGenerator
    {
        Task<IEnumerable<TDto>> GeneratePage<TDto, TEntity>(IQueryable<TEntity> entities, QueryRequestDto request, CancellationToken cancellationToken);
    }
}
