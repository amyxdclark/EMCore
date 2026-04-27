namespace EMCore.Domain.Subjects;

using EMCore.Domain.Common;

public class SubjectPlacement : TenantEntity
{
    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;

    public Guid? ParentSubjectId { get; set; }
    public Subject? ParentSubject { get; set; }

    public DateTimeOffset PlacedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? RemovedAt { get; set; }
    public string? Notes { get; set; }
}
