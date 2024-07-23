using TL.Core.Common;

namespace TL.Core.Entities.Empl
{
    public class Employee : Entity<int>
    {
        public Guid UserId { get; set; }
    }
}
