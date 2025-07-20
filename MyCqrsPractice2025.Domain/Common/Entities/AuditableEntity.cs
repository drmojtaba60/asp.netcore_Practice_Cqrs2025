namespace MyCqrsPractice2025.Domain.Common.Entities;

public abstract class AuditableEntity<TId> : BaseEntity<TId>
{
    public DateTime CreatedAt { get; set; }
    public string? CreatedBy { get; set; }

    public DateTime? LastModifiedAt { get; set; }
    public string? LastModifiedBy { get; set; }
}