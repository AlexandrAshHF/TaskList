using TL.Core.Common;
using TL.Core.Entities;
using TL.Core.Entities.Application;

namespace TL.Core.ValueObjects
{
    public class HtmlDescription : AuditableEntity<int>
    {
        public string Html { get; set; }

        public List<string> Images { get; set; }

        public virtual TLApplication Application { get; set; }
        public int ApplicationId { get; set; }

        public virtual Comment Comment { get; set; }
        public int CommentId { get; set; }
    }
}
