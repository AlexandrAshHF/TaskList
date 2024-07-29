using TL.Core.Common;
using TL.Core.ValueObjects;

namespace TL.Core.Entities
{
    public class ApplicationStatus : Entity<int>
    {
        public string Name { get; set; }
        public virtual Color Color { get; set; }
    }
}
