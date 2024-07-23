using TL.Core.Common;

namespace TL.Core.Entities.Authentication
{
    public class User : AuditableEntity
    {
        public string Username { get; set; }
        public string Email { get; private set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; private set; }
        public bool IsRemembered { get; set; }
        public bool IsBlocked { get; set; }

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
