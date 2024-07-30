using TL.Core.Common.Entity;
using TL.Core.Common.ValueObject;

namespace TL.Core.ValueObjects
{
    /// <summary>
    /// RGB для элементов
    /// </summary>
    public class Color : BaseObject
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Red;
            yield return Green;
            yield return Blue;
        }
    }
}
