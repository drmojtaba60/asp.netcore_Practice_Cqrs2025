using MyCqrsPractice2025.Domain.Common.Events;

namespace MyCqrsPractice2025.Domain.Common.Entities;

public abstract class BaseEntity<TId>
{
    public TId Id { get; protected set; }

    private readonly List<DomainEvent> _domainEvents = new();
    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    protected void AddDomainEvent(DomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents() => _domainEvents.Clear();
}
