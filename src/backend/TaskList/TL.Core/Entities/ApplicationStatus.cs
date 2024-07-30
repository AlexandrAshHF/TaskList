using TL.Core.Common.Entity;
using TL.Core.Entities.Application;
using TL.Core.ValueObjects;

namespace TL.Core.Entities
{
    public class ApplicationStatus : BaseEntity<int>
    {
        /// <summary>
        /// Название статуса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цвет статуса
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Заявления в данном статусе
        /// </summary>
        public virtual ICollection<TLApplication> Applications { get; set; } = new List<TLApplication>();

        /// <summary>
        /// Проект в котором находится статус
        /// </summary>
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
