using TL.Core.Common;
using TL.Core.Enums.Authentication;

namespace TL.Core.ValueObjects.Authentication
{
    /// <summary>
    /// Разрешение
    /// </summary>
    public class Permission : Entity
    {
        /// <summary>
        /// Действие
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Ресурс
        /// </summary>
        public Resource Resource { get; set; }

        /// <summary>
        /// URL для разрешения
        /// </summary>
        public string Url { get; set; }
    }
}
