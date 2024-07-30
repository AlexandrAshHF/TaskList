namespace TL.Core.Common.ValueObject
{
    public abstract class BaseObject
    {
        protected abstract IEnumerable<object> GetEqualityComponents();

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            var valueObj = (BaseObject)obj;

            return GetEqualityComponents().SequenceEqual(valueObj.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents().Aggregate(default(int), (hashcode, value) =>
            {
                return HashCode.Combine(hashcode, value.GetHashCode());
            });
        }

        public static bool operator ==(BaseObject? left, BaseObject? right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            return left.Equals(right);
        }

        public static bool operator !=(BaseObject? left, BaseObject? right)
        {
            return !(left == right);
        }
    }
}
