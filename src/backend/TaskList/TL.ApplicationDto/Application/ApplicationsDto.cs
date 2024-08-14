using TL.ApplicationDto.Application.Status;
using TL.ApplicationDto.Common;
using TL.Core.Entities.Application;

namespace TL.ApplicationDto.Application
{
    public class ApplicationsDto : BaseDto<ApplicationsDto, TLApplication>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public StatusDto Status { get; set; }
        public bool IsDeleted { get; set; }

        protected override void Mapping()
        {
            Set()
                .Map(e => e.Id, d => d.Id)
                .Map(e => e.Name, d => d.Name)
                .Map(e => e.CreatedOn, d => d.CreatedOn)
                .Map(e => e.LastModifiedOn, d => d.LastModifiedOn)
                .Map(e => e.Status, d => d.Status)
                .Map(e => e.IsDeleted, d => d.IsDeleted);
        }
    }
}
