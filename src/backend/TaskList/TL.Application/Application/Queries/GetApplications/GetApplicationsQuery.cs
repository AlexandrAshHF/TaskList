using TL.Application.Abstractions;
using TL.Application.Common.Persistance.Repositories;
using TL.ApplicationDto.Application;
using TL.ApplicationDto.Common;

namespace TL.Application.Application.Queries.GetApplications
{
    public record GetApplicationsQuery : IQuery<List<ApplicationsDto>>
    {
        public QueryRequestDto? PageDto { get; set; }
    }

    public class GetApplicationQueryHandler : IQueryHandler<GetApplicationsQuery, List<ApplicationsDto>>
    {
        private readonly IApplicationRepository _applicationRepository;

        public GetApplicationQueryHandler(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<List<ApplicationsDto>> Handle(GetApplicationsQuery request, CancellationToken cancellationToken)
        {
            var applications = await _applicationRepository.GetAll<ApplicationsDto>(request.PageDto, cancellationToken);
            return applications.ToList();
        }
    }
}
