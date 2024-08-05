using TL.Application.Abstractions;
using TL.ApplicationDto.Application;
using TL.ApplicationDto.Descriptions;

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
        public Task<int> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
