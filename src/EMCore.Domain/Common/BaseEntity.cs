namespace EMCore.Domain.Common;

/// <summary>
/// Base class for platform-level entities that are not tenant-scoped.
/// </summary>
public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
}
