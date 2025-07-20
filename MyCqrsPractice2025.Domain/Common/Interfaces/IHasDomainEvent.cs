using MyCqrsPractice2025.Domain.Common.Events;

namespace MyCqrsPractice2025.Domain.Common.Interfaces;
public interface IHasDomainEvent
{
    IReadOnlyCollection<DomainEvent> DomainEvents { get; }
    void ClearDomainEvents();
}
