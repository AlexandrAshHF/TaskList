using TL.ApplicationDto.Common;
using TL.Core.ValueObjects;

namespace TL.ApplicationDto.Descriptions
{
    public class DescriptionDto : BaseDto<DescriptionDto, Description>
    {
        public string Marking { get; set; }
    }
}
