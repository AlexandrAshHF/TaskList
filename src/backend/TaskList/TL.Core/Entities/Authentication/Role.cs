using TL.Core.Common;
using TL.Core.ValueObjects.Authentication;

namespace TL.Core.Entities.Authentication
{
    /// <summary>
    /// Роль
    /// </summary>
    public class Role : Entity<int>
    {
        /// <summary>
        /// Название роли
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список пользователей с этой ролью
        /// </summary>
        public virtual ICollection<User> Users { get; set; } = new List<User>();

        /// <summary>
        /// Список разрешений для роли
        /// </summary>
        public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
    }
}
