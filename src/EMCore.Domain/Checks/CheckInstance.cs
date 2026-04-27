namespace EMCore.Domain.Checks;

using EMCore.Domain.Common;

public class CheckInstance : TenantEntity
{
    public Guid CheckTemplateId { get; set; }
    public CheckTemplate CheckTemplate { get; set; } = null!;

    public Guid SubjectId { get; set; }
    public Guid PerformedByUserId { get; set; }

    public DateTimeOffset StartedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? CompletedAt { get; set; }
    public bool? Passed { get; set; }
    public string? Notes { get; set; }

    public ICollection<CheckResponse> Responses { get; set; } = new List<CheckResponse>();
}
