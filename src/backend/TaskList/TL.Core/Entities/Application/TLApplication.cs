using TL.Core.Common;
using TL.Core.Enums.Application;

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
        /// HTML описание заявки
        /// </summary>
        public virtual Description Description { get; set; }
        public int DescriptionId { get; set; }

        public ApplicationStatus Status { get; set; }

        /// <summary>
        /// Сотрудники
        /// </summary>
        public virtual ICollection<EmployeeInApplication> Employees { get; set; } = new List<EmployeeInApplication>();
    }
}
