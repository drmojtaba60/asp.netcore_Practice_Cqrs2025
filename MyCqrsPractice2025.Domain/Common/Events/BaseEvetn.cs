namespace MyCqrsPractice2025.Domain.Common.Events;

public abstract class DomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}
