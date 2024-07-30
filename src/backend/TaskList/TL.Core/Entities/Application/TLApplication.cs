using TL.Core.Common.Entity;
using TL.Core.ValueObjects;

namespace TL.Core.Entities.Application
{
    /// <summary>
    /// Завяка, задание
    /// </summary>
    public class TLApplication : AuditableEntity<int>
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Трудозатраты
        /// </summary>
        public TimeSpan LaborCosts { get; set; }

        /// <summary>
        /// Пометка на удаление
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Описание заявки
        /// </summary>
        public Description Description { get; set; }

        /// <summary>
        /// Статус задачи
        /// </summary>
        public virtual ApplicationStatus Status { get; set; }
        public int StatusId { get; set; }

        /// <summary>
        /// Проект, в котором находится задача
        /// </summary>
        public virtual Project Project { get; set; }
        public int ProjectId { get; set; }

        /// <summary>
        /// Сотрудники, учавствющие в задаче
        /// </summary>
        public virtual ICollection<EmployeeInApplication> Employees { get; set; } = new List<EmployeeInApplication>();

        /// <summary>
        /// Комменатрии к задаче
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
