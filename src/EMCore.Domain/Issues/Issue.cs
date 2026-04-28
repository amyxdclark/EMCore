namespace EMCore.Domain.Issues;

using EMCore.Domain.Common;

public class Issue : TenantEntity
{
    public Guid IssueTypeId { get; set; }
    public IssueType IssueType { get; set; } = null!;

    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Status { get; set; } = "Open";

    public Guid? RelatedEntityId { get; set; }
    public string? RelatedEntityType { get; set; }

    public Guid? AssignedToUserId { get; set; }
    public DateTimeOffset? ResolvedAt { get; set; }
    public string? Resolution { get; set; }
}
