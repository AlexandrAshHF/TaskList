using TL.Core.Common;
using TL.Core.ValueObjects;

namespace TL.Core.Entities
{
    public class ApplicationStatus : Entity<int>
    {
        /// <summary>
        /// Название статуса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цвет статуса
        /// </summary>
        public virtual Color Color { get; set; }
        public int ColorId { get; set; }
    }
}
