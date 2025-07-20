namespace MyCqrsPractice2025.Domain.Common.ValueObjects;

public abstract class ValueObject
{
    protected abstract IEnumerable<object> GetEqualityComponents();

    public override bool Equals(object? obj)
    {
        if (obj is not ValueObject other)
            return false;

        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    public override int GetHashCode() =>
        GetEqualityComponents()
            .Aggregate(1, (current, obj) => current * 23 + (obj?.GetHashCode() ?? 0));
}
