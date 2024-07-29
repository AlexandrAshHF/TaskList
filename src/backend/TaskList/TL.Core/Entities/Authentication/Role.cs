using TL.Core.Common;

namespace TL.Core.Entities.Authentication
{
    public class Role : Entity<int>
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();

        public List<Permission> Permissions { get; set; } = new List<Permission>();
    }
}
