using TL.Core.Common;
using TL.Core.Entities.Empl;
using TL.Core.Enums.Application;

namespace TL.Core.Entities.Application
{
    public class EmployeeInApplication : Entity<int>
    {
        public virtual Employee Employee { get; set; }

        public int EmployeeId { get; set; }

        public virtual TLApplication Application { get; set; }

        public int ApplicationId { get; set; }

        public EmplInAppStatus Status { get; set; }
    }
}
