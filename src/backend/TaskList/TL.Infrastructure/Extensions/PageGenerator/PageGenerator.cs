using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq.Expressions;
using TL.ApplicationDto.Common;
using TL.ApplicationDto.Common.Unification.Base;

namespace TL.Infrastructure.Extensions.Pagination
{
    public class PageGenerator : IPageGenerator
    {
        public async Task<IEnumerable<TDto>> GeneratePage<TDto, TEntity>(
            IQueryable<TEntity> entities,
            QueryRequestDto request, 
            CancellationToken cancellationToken)
        {
            if (!entities.Any())
            {
                return new List<TDto>();
            }

            ApplyFilters(entities, request.Filters);

            var dtos = await entities 
                .Skip(request.Pagination != null 
                    ? request.Pagination.PageNumber*request.Pagination.PageSize 
                    : 0)
                .Take(request.Pagination != null 
                    ? request.Pagination.PageSize
                    : int.MaxValue)
                .ProjectToType<TDto>()
                .ToListAsync();

            return dtos;
        }

        private void ApplyFilters<TEntity>(IQueryable<TEntity> entities, IEnumerable<Filter> filters)
        {
                foreach (var filter in filters)
                {
                    var query = entities;

                    var entity = query.FirstOrDefault();
                    var propertyType = entity?.GetType()?.GetProperty(filter.ParamName)?.GetType();

                    if (propertyType == null)
                    {
                        continue;
                    }

                    var parameter = Expression.Parameter(propertyType, filter.ParamName);
                    var bodyExpression = Expression.Equal(parameter, Expression.Constant(1));
                    var lambda = Expression.Lambda<Func<TEntity, bool>>(bodyExpression, parameter);

                    entities = query.Where(lambda);
                }
            
        }
    }
}
