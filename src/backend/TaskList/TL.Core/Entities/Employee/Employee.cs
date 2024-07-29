using TL.Core.Common;
using TL.Core.Entities.Application;
using TL.Core.Entities.Authentication;

namespace TL.Core.Entities.Empl
{
    public class Employee : Entity<int>
    {
        /// <summary>
        /// ID аккаунта сотрудника
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Должность сотрудника
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Отношения сотрудника в заявлениях
        /// </summary>
        public virtual ICollection<EmployeeInApplication> EmployeeInApplications { get; set; } = new List<EmployeeInApplication>();
    }
}
