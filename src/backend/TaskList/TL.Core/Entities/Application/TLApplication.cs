using TL.Core.Common;
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
        public virtual Description Description { get; set; }
        public int DescriptionId { get; set; }

        /// <summary>
        /// Статус задачи
        /// </summary>
        public virtual ApplicationStatus Status { get; set; }

        /// <summary>
        /// Проект, в котором находится задача
        /// </summary>
        public virtual Project Project { get; set; }

        /// <summary>
        /// Сотрудники, учавствющие в задаче
        /// </summary>
        public virtual ICollection<EmployeeInApplication> Employees { get; set; } = new List<EmployeeInApplication>();
    }
}
