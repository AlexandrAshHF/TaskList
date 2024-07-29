using TL.Core.Common;
using TL.Core.Entities.Application;
using TL.Core.Entities.Empl;

namespace TL.Core.Entities
{
    /// <summary>
    /// Проект
    /// </summary>
    public class Project : AuditableEntity<int>
    {
        /// <summary>
        /// Название проекта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Пометка на удаление
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Родительский проект
        /// </summary>
        public virtual Project? ParrentProject { get; set; }
        public int ParrentProjectId { get; set; }

        /// <summary>
        /// Дочерние проекты
        /// </summary>
        public virtual ICollection<Project> InternalProjects { get; set; } = new List<Project>();

        /// <summary>
        /// Список задач проекта
        /// </summary>
        public virtual ICollection<TLApplication> Applications { get; set; } = new List<TLApplication>();

        /// <summary>
        /// Сотрудники, относящиеся к проекту
        /// </summary>
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

        /// <summary>
        /// Доступные статусы для заявок
        /// </summary>
        public virtual ICollection<ApplicationStatus> AvailableStatuses { get; set; } = new List<ApplicationStatus>();
    }
}