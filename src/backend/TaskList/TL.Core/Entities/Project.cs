using TL.Core.Common;
using TL.Core.Entities.Application;
using TL.Core.Entities.Empl;

namespace TL.Core.Entities
{
    public class Project : AuditableEntity<int>
    {
        public string Name { get; set; }
        public ICollection<TLApplication> Applications { get; set; } = new List<TLApplication>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
