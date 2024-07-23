using TL.Core.Common;

namespace TL.Core.Entities.Empl
{
    public class EmployeePosition : Entity<int>
    {
        public string Name { get; set; } 
        public virtual ICollection<Employee> Employees { get; set;} = new List<Employee>();
    }
}
