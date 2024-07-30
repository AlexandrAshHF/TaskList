using TL.Core.Common.Entity;
using TL.Core.Entities.Application;

namespace TL.Core.Entities.Empl
{
    public class Employee : BaseEntity<int>
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

        /// <summary>
        /// Комментарии, преимущественно к заявлениям
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
