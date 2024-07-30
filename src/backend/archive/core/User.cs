using TL.Core.Common.Entity;

namespace TL.Core.Entities.Authentication
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User : AuditableEntity
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Хэш пароля
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// Запомнить аккаунт
        /// </summary>
        public bool IsRemembered { get; set; }

        /// <summary>
        /// Статус заблокирован или разблокирован
        /// </summary>
        public bool IsBlocked { get; set; }

        /// <summary>
        /// Список ролей пользователя
        /// </summary>
        public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
