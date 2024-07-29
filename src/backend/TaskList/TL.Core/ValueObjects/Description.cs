using TL.Core.Common;
using TL.Core.Common.Exceptions;
using TL.Core.Entities;
using TL.Core.Entities.Application;

namespace TL.Core.ValueObjects
{
    public class Description : AuditableEntity<int>
    {
        public string Marking { get; private set; }

        public List<string> Images { get; private set; } = new List<string>();

        public virtual TLApplication Application { get; set; }
        public int ApplicationId { get; set; }

        public virtual Comment Comment { get; set; }
        public int CommentId { get; set; }

        public Description(string text)
        {
            SetMarking(text);
        }

        public void SetMarking(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new DomainException($"{nameof(Description)}.{nameof(Marking)}");
            }

            Marking = text;
        }
    }
}
