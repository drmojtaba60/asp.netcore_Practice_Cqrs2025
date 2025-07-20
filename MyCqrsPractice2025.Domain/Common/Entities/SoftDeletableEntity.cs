namespace MyCqrsPractice2025.Domain.Common.Entities;

public abstract class SoftDeletableEntity<TId> : AuditableEntity<TId>
{
    public bool IsDeleted { get; set; }
}