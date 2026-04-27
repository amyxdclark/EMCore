namespace EMCore.Domain.Maintenance;

using EMCore.Domain.Common;

public class MaintenanceWorkOrder : TenantEntity
{
    public Guid SubjectId { get; set; }
    public Guid? MaintenanceScheduleId { get; set; }

    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Status { get; set; } = "Open";

    public DateTimeOffset OpenedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? ClosedAt { get; set; }
    public Guid? AssignedToUserId { get; set; }
}
