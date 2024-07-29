using TL.Core.Common;

namespace TL.Core.ValueObjects
{
    /// <summary>
    /// RGB для элементов
    /// </summary>
    public class Color : Entity<int>
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    }
}
