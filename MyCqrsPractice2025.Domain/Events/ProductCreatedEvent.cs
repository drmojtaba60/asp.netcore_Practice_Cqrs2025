using MyCqrsPractice2025.Domain.Common.Events;

namespace MyCqrsPractice2025.Domain.Events;

public sealed class ProductCreatedEvent(int productId) : DomainEvent
{
    public int ProductId { get; } = productId;
}
