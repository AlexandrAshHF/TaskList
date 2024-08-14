using TL.Application.Abstractions;
using TL.Application.Common.Persistance.Repositories;
using TL.ApplicationDto.Application;
using TL.ApplicationDto.Descriptions;
using TL.Application.Common.Exceptions;
using TL.Core.Entities.Application;
using TL.Core.ValueObjects;
using TL.Application.Common.Persistance;

namespace TL.Application.Application.Commands.Create
{
    public record CreateApplicationCommand : ICommand<int>
    {
        public string Name { get; set; } 
        public DescriptionDto Description { get; set; }
        public int StatusId { get; set; }
        public int ProjectId { get; set; }
        public IEnumerable<EmployeeInApplicationDto> Employees { get; set; }
    }
    public class CreateApplicationCommandHandler : ICommandHandler<CreateApplicationCommand, int>
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IEmplInAppRepository _emplInAppRepository;
        private readonly IUnitOfWork _uow;

        public CreateApplicationCommandHandler(
            IApplicationRepository applicationRepository,
            IEmplInAppRepository emplInAppRepository,
            IUnitOfWork uow)
        {
            _applicationRepository = applicationRepository;
            _emplInAppRepository = emplInAppRepository;
            _uow = uow;
        }

        public async Task<int> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            var application = await _applicationRepository.GetByNameAndProjectId(request.Name, request.ProjectId);

            if (application != null)
            {
                throw new LogicException($"В данном проекте уже существует задача с именем {request.Name}");
            }

            var description = new Description(request.Description.Marking);

            var newApplication = new TLApplication();
            newApplication.Name = request.Name;
            newApplication.StatusId = request.StatusId;
            newApplication.Description = description;
            newApplication.ProjectId = request.ProjectId;

            _applicationRepository.Create(newApplication);

            await _uow.CommitAsync(cancellationToken);

            CreateEmployeesToApplication(newApplication.Id, request.Employees);

            await _uow.CommitAsync(cancellationToken);

            return newApplication.Id;
        }

        private void CreateEmployeesToApplication(int applicationId, IEnumerable<EmployeeInApplicationDto> emplsDto)
        {
            foreach (var dto in emplsDto)
            {
                var empl = new EmployeeInApplication();
                empl.ApplicationId = applicationId;
                empl.Status = dto.Status;
                empl.EmployeeId = dto.EmployeeId;
                
                _emplInAppRepository.Create(empl);
            }
        }
    }
}