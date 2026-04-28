namespace EMCore.Domain.Common;

/// <summary>
/// Base class for all tenant-scoped entities.
/// Every entity that belongs to a tenant carries the TenantId property.
/// </summary>
public abstract class TenantEntity
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
}
