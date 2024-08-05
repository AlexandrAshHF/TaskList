using TL.ApplicationDto.Common.Unification.Base;

namespace TL.ApplicationDto.Common
{
    public class QueryRequestDto
    {
        public Pagination? Pagination { get; set; }
        public Order? Order { get; set; }
        public List<Filter> Filters { get; set; } = new List<Filter>();
    }
}
