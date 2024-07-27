using TL.Core.Common;
using TL.Core.Enums.Authentication;

namespace TL.Core.Entities.Authentication
{
    public class Permission : Entity
    {
        public Scope Scope { get; set; }

        public Resource Resource { get; set; }
    }
}
