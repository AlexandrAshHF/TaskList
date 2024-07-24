using TL.Core.Common;
using TL.Core.Enums.Authentication;

namespace TL.Core.Entities.Authentication
{
    public class ResourcePermission : Entity
    {
        public PermissionType Permission { get; set; }

        public ResourceType Resource { get; set; }
    }
}
