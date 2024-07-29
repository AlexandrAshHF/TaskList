using TL.Core.Common;
using TL.Core.Entities.Application;
using TL.Core.Entities.Empl;
using TL.Core.ValueObjects;

namespace TL.Core.Entities
{
    public class Comment : AuditableEntity<int>
    {
        public virtual Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        
        public virtual TLApplication Application { get; set; }
        public int ApplicationId { get; set; }

        public virtual Description Description { get; set; }
        public int DescriptionId { get; set; }
    }
}
